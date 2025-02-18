namespace TechnicalAirTechTest.Utilities
{
    public class CityAnalizer
    {
        public static List<KeyValuePair<string, int>> GetTopCities(int topN)
        {
            List<string> citiesList = new List<string>
            {
                "nasville",
                "nasville",
                "los angeles",
                "nasville",
                "Madrid",
                "memphis",
                "barcelona",
                "los angeles",
                "sevilla",
                "Madrid",
                "canary islands",
                "barcelona",
                "Madrid",
                "Madrid",
                "nasville",
                "barcelona",
                "london",
                "berlin",
                "Madrid",
                "nasville",
                "london",
                "Madrid",
                "Madrid",
            };

            return citiesList
                .GroupBy(city => city.ToLower())
                .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                .OrderByDescending(pair => pair.Value)
                .Take(topN)
                .ToList();
        }
    }
}
