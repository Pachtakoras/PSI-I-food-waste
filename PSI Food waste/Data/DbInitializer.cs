﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSI_Food_waste.Models;

namespace PSI_Food_waste.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            Guid guid = Guid.NewGuid();
            Guid guid2 = Guid.NewGuid();
            if(context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product{RestId = guid, Name = "Margarita", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid, Name = "Italiska", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid, Name = "Havaju", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid, Name = "Socioji", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid, Name = "Peperoni", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid2, Name = "Burger", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid2, Name = "Fries", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"},
                new Product{RestId = guid2, Name = "Big burger", Size=ProductSize.Small, IsGlutenFree = false, Price = 10, DiscountedPrice = 5, Discount = 50,Description="Kvietinių miltų paplotėlis, pesto padažas, mozzarella, baltieji svogūnai, artišokai, žalios alyvuogės, saulėje džiovinti pomidorai, Džiugo sūris, česnakinis aliejus", PictureUrl = "https://www.lamaistas.lt/uploads/modules/recipes/without-watermark/29238.jpg"}
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var restaurants = new Restaurant[]
            {
                new Restaurant {Id = guid2, Title = "Burger street ", City = "Vilnius", Adress = "Vilniaus g. ", PictureUrl = "https://imageproxy.wolt.com/venue/60a1f821c6df001844f76fed/10a81d36-b6cd-11eb-858e-ce279a5c61e0_men.jpeg"},
                new Restaurant {Id = guid, Title = "Cili pica", City = "Kaunas", Adress = "Kauno g. 15", PictureUrl = "https://imageproxy.wolt.com/venue/5c88ebd41df13b000a63805e/1273afe269cd3ae5d49b04d813a1f4e8"}
            };

            context.Restaurants.AddRange(restaurants);
            context.SaveChanges();
        }
    }
}
