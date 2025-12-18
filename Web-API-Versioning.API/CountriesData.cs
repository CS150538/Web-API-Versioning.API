using Web_API_Versioning.API.Models.Domain;

namespace Web_API_Versioning.API
{
    public class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                new Country { Id = 1, Name = "India" },
                new Country { Id = 2, Name = "United States" },
                new Country { Id = 3, Name = "Canada" },
                new Country { Id = 4, Name = "United Kingdom" },
                new Country { Id = 5, Name = "Australia" },
                new Country { Id = 6, Name = "Germany" },
                new Country { Id = 7, Name = "France" },
                new Country { Id = 8, Name = "Japan" },
                new Country { Id = 9, Name = "China" },
                new Country { Id = 10, Name = "Brazil" }
            };

            return countries.Select(c=> new Country
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
        }
    }
}
