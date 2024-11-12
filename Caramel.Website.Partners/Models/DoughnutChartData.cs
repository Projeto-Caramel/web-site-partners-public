namespace Caramel.Website.Partners.Models
{
    public class DoughnutChartData
    {
        public DoughnutChartData() { }

        // Temporário - até a chamada das APIs
        public DoughnutChartData(int mainData, int secondaryData, string mainColor, string secondaryColor)
        {
            MainData = mainData;
            SecondaryData = secondaryData;
            MainColor = mainColor;
            SecondaryColor = secondaryColor;
        }

        public string MainLabel { get; set; }
        public string SecondaryLabel { get; set; }
        public double MainData { get; set; }
        public double SecondaryData { get; set; }
        public string MainColor { get; set; }
        public string SecondaryColor { get; set; }
    }
}
