﻿using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly IEnumerable<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() { 
                new Restaurant{ Id = 1,Name = "Scott's Pizza",Location="Maryland",Cuisine = CuisineType.Italian},
                new Restaurant{ Id = 2,Name = "Cinnamon Club",Location="Georgia",Cuisine = CuisineType.Indian},
                new Restaurant{ Id = 3,Name = "La Costa",Location="California",Cuisine = CuisineType.Mexican}

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
