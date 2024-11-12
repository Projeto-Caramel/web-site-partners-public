using System.Globalization;

namespace Caramel.Website.Partners.Models
{
    public class BarChartData
    {
        public BarChartData() { }

        public BarChartData(List<double?> mainData, List<double?> secondaryData)
        {
            MainData = mainData;
            SecondaryData = secondaryData;
        }

        public List<string> Labels { get => GetLastMonths(12); }
        public List<double?> MainData { get; set; }
        public List<double?> SecondaryData { get; set; }

        public List<string> GetLastMonths(int quantity)
        {
            List<string> months = new List<string>();
            DateTime currentDate = DateTime.Now.AddHours(3);

            for (int i = quantity - 1; i >= 0; i--)
            {
                // Subtrai o mês atual e obtém o nome do mês
                string monthName = currentDate.AddMonths(-i).ToString("MMM", CultureInfo.CreateSpecificCulture("pt-BR"));
                months.Add(monthName);
            }

            return months;
        }
    }
}
