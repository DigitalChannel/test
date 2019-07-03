using OdeFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="Scots Pizza",Location="Nairobi",cuisine=cuisineType.Indian},
                new Restaurant{Id=2,Name="Papas Pizza",Location="Accra",cuisine=cuisineType.Italian},
                new Restaurant{Id=3,Name="Eddiys Pizza",Location="Mombasa",cuisine=cuisineType.Mexican},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
