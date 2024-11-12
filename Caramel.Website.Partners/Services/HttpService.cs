using Caramel.Website.Partners.Models.Exceptions;
using Caramel.Website.Partners.Models.Responses;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.JSInterop;
using System.Diagnostics;
using System.Net;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

public class HttpService
{
    private readonly string _baseUrl;
    private readonly ISessionStorageService _sessionStorage;
    private readonly JsonSerializerOptions _options;

    public HttpService(string baseUrl, ISessionStorageService sessionStorage)
    {
        _baseUrl = baseUrl;
        _sessionStorage = sessionStorage;
        _options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals
        };
    }

    private IFlurlRequest CreateRequest(string uri)
    {
        var token = _sessionStorage.GetItem<string>("token");
        return new FlurlRequest(_baseUrl + uri)
        .AllowHttpStatus("2xx")
        .WithOAuthBearerToken(token)
        .WithSettings(x => x.JsonSerializer = new DefaultJsonSerializer(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals
        }));
    }

    public async Task<HttpServiceResponse<T>> GetAsync<T>(string uri)
    {
        try
        {
            var response = await CreateRequest(uri).GetAsync();
            return await ProcessResponse<T>(response);
        }
        catch (FlurlHttpException ex)
        {
            return await ProcessErrorResponse<T>(ex);
        }
    }

    public async Task<HttpServiceResponse> PostAsync<TRequest>(string uri, TRequest data)
    {
        try
        {
            var response = await CreateRequest(uri).PostJsonAsync(data);
            return await ProcessResponse(response);
        }
        catch (FlurlHttpException ex)
        {
            return await ProcessErrorResponse(ex);
        }
    }

    public async Task<HttpServiceResponse> PatchAsync(string uri)
    {
        try
        {
            var response = await CreateRequest(uri).PatchAsync();
            return await ProcessResponse(response);
        }
        catch (FlurlHttpException ex)
        {
            return await ProcessErrorResponse(ex);
        }
    }

    public async Task<HttpServiceResponse<T>> PostAsync<TRequest, T>(string uri, TRequest data)
    {
        try
        {
            var response = await CreateRequest(uri).PostJsonAsync(data);
            return await ProcessResponse<T>(response);
        }
        catch (FlurlHttpException ex)
        {
            var error = $"{ex.StatusCode} - {await ex.GetResponseStringAsync()}";
            return await ProcessErrorResponse<T>(ex);
        }
    }

    public async Task<HttpServiceResponse<T>> PutAsync<TRequest, T>(string uri, TRequest data)
    {
        try
        {
            var response = await CreateRequest(uri).PutJsonAsync(data);
            return await ProcessResponse<T>(response);
        }
        catch (FlurlHttpException ex)
        {
            return await ProcessErrorResponse<T>(ex);
        }
    }

    public async Task<HttpServiceResponse> DeleteAsync<TRequest>(string uri, TRequest data)
    {
        try
        {
            var response = await CreateRequest(uri).SendJsonAsync(HttpMethod.Delete, data);
            return await ProcessResponse(response);
        }
        catch (FlurlHttpException ex)
        {
            return await ProcessErrorResponse(ex);
        }
    }

    private async Task<HttpServiceResponse<T>> ProcessResponse<T>(IFlurlResponse response)
    {
        var httpServiceResponse = new HttpServiceResponse<T>
        {
            StatusCode = (HttpStatusCode)response.StatusCode,
            RawContent = await response.ResponseMessage.Content.ReadAsStringAsync()
        };

        if (response.ResponseMessage.IsSuccessStatusCode)
        {
            httpServiceResponse.Content = JsonSerializer.Deserialize<T>(httpServiceResponse.RawContent, _options);
        }
        else
        {
            var businessException = JsonSerializer.Deserialize<BusinessException>(httpServiceResponse.RawContent, _options);
            var errorDetails = businessException.ErrorDetails ?? [];
            httpServiceResponse.ErrorDetails = errorDetails;
        }

        return httpServiceResponse;
    }

    private async Task<HttpServiceResponse> ProcessResponse(IFlurlResponse response)
    {
        var httpServiceResponse = new HttpServiceResponse
        {
            StatusCode = (HttpStatusCode)response.StatusCode,
            Content = await response.ResponseMessage.Content.ReadAsStringAsync()
        };

        if (!response.ResponseMessage.IsSuccessStatusCode)
        {
            var businessException = JsonSerializer.Deserialize<BusinessException>(httpServiceResponse.Content, _options);
            var errorDetails = businessException.ErrorDetails ?? [];
            httpServiceResponse.ErrorDetails = errorDetails;
        }

        return httpServiceResponse;
    }

    private async Task<HttpServiceResponse<T>> ProcessErrorResponse<T>(FlurlHttpException ex)
    {
        var response = new HttpServiceResponse<T>
        {
            StatusCode = ex.Call.Response != null ? (HttpStatusCode)ex.Call.Response.StatusCode : HttpStatusCode.InternalServerError,
            RawContent = ex.Call.Response != null ? await ex.GetResponseStringAsync() : ex.Message
        };

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            response.ErrorDetails = ["Acesso negado."];
        }
        else
        {
            var businessException = JsonSerializer.Deserialize<BusinessException>(response.RawContent, _options);
            response.ErrorDetails = businessException?.ErrorDetails ?? [];
        }

        Console.WriteLine(response.RawContent);
        return response;
    }

    private async Task<HttpServiceResponse> ProcessErrorResponse(FlurlHttpException ex)
    {
        var response = new HttpServiceResponse
        {
            StatusCode = ex.Call.Response != null ? (HttpStatusCode)ex.Call.Response.StatusCode : HttpStatusCode.InternalServerError,
            RawContent = ex.Call.Response != null ? await ex.GetResponseStringAsync() : ex.Message
        };

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            response.ErrorDetails = ["Acesso negado."];
        }
        else
        {
            var businessException = JsonSerializer.Deserialize<BusinessException>(response.RawContent, _options);
            response.ErrorDetails = businessException?.ErrorDetails ?? [];
        }

        Console.WriteLine(response.RawContent);
        return response;
    }
}
