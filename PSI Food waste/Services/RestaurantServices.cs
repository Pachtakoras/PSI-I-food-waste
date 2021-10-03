﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using PSI_Food_waste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSI_Food_waste.Services
{
    public static class RestaurantServices
    {
        static List<Restaurant> Restaurants { get; }

        static int nextID = 1;
        static RestaurantServices()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Name = "Chilli pica", Adress = "Kauno g. 15", Id = 1, WorkerID = 1 
                }
            };
        }
        public static List<Restaurant> GetAll() => Restaurants;
        public static Restaurant Get(int id) => Restaurants.FirstOrDefault(p => p.Id  == id);

        public static void Add(Restaurant Restaurant)
        {
            Restaurant.Id = nextID++;
            Restaurants.Add(Restaurant);
        }
        public static void Update(Restaurant Restaurant)
        {
            var index = Restaurants.FindIndex(p => p.Id == Restaurant.Id);
            if (index == -1)
                return;

            Restaurants[index] = Restaurant;
        }
    }
}
