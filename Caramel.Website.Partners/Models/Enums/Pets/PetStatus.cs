using System.ComponentModel;

namespace Caramel.Website.Partners.Models.Enums.Pets
{
    public enum PetStatus
    {
        [Description("Todos")]
        Unknown = 0,
        [Description("Disponível")]
        Available = 1,
        [Description("Indisponível")]
        Unavailable = 2,
        [Description("Adotado pelos processos das ONGs")]
        AdoptOng = 3,
        [Description("Adotado pelo APP")]
        AdoptApp = 4
    }

    public static class PetStatusEnumMapper
    {
        public static Dictionary<PetStatus, string> Mapper = new()
        {
            { PetStatus.Available, "Disponível" },
            { PetStatus.AdoptOng, "Adotado Ong" },
            { PetStatus.AdoptApp, "Adotado App" },
            { PetStatus.Unavailable, "Indísponível" },
        };
    }
}
