using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;

namespace HelloWorld.BL
{
    public class SearchService
    {
        private List<Search> _searches = new List<Search>
        {
            new Search
            {
                Id = 1,
                Location = "London",
                CheckIn = new DateTime(2017, 06, 08, 20, 55, 1),
                CheckOut = new DateTime(2017, 06, 10, 20, 55, 1)
            },
            new Search
            {
                Id = 2,
                Location = "Manchester",
                CheckIn = new DateTime(2017, 06, 08, 21, 55, 1),
                CheckOut = new DateTime(2017, 06, 10, 21, 55, 1)
            },
            new Search
            {
                Id = 3,
                Location = "Leeds",
                CheckIn = new DateTime(2017, 06, 08, 22, 55, 1),
                CheckOut = new DateTime(2017, 06, 10, 22, 55, 1)
            }
        };

       public IEnumerable<Search> GetSearches(string filter = null)
        {
            return String.IsNullOrWhiteSpace(filter) ? _searches : _searches.Where( c => c.Location.StartsWith(filter));
        }


        public void DeleteSearch(int searchId)
        {
            var search = _searches.SingleOrDefault(s => s.Id == searchId);

            _searches.Remove(search);
        }





    }
}
