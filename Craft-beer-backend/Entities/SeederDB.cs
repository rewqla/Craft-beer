﻿using Craft_beer_backend.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Craft_beer_backend.Entities
{
    public class SeederDB
    {
        public static void SeedData(IServiceProvider services,
            IWebHostEnvironment env, IConfiguration config)
        {
            try
            {
                using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                    var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    var roleName = "Admin";
                    var result = managerRole.CreateAsync(new DbRole
                    {
                        Name = roleName
                    }).Result;

                    string email = "admin@gmail.com";
                    var user = new DbUser
                    {
                        Email = email,
                        FirstName = "Степан",
                        LastName = "Непан",
                        UserName = email,
                        PhoneNumber = "+380974355566",
                        Birthday = "12-04-2000"
                    };
                    result = manager.CreateAsync(user, "12345678").Result;
                    result = manager.AddToRoleAsync(user, roleName).Result;

                    roleName = "User";
                    result = managerRole.CreateAsync(new DbRole
                    {
                        Name = roleName
                    }).Result;

                    email = "user@gmail.com";
                    user = new DbUser
                    {
                        Email = email,
                        UserName = email,
                        FirstName = "Вадим",
                        LastName = "Лірник",
                        PhoneNumber = "+380974355116",
                        Birthday = "23-12-1994"
                    };
                    result = manager.CreateAsync(user, "12345678").Result;
                    result = manager.AddToRoleAsync(user, roleName).Result;

                    var beers = new List<CraftBeer>
                {
                    new CraftBeer
                    {
                        Name = "Bud",
                        Price = 40,
                        Volume = 0.5,
                        ABV = 5.0,
                        Description = "Пиво Bud – всесвітньо відомий король серед пива був вперше представлений Адольфусом Бушем ще у 1876 році. Відтоді й досі BUD вариться з дотриманням високих стандартів якості, незмінних з плином часу.",
                        ImageUrl = "https://img3.zakaz.ua/09.1663274872.ad72436478c_2022-09-16_Victoria/09.1663274872.SNCPSG10.obj.0.1.jpg.oe.jpg.pf.jpg.1350nowm.jpg.1350x.jpg"
                    },
                    new CraftBeer
                    {
                        Name = "Гребуча Корова",
                        Price = 64,
                        Volume = 0.33,
                        ABV = 6.0,
                        Description = "Пиво Гребуча корова – це класичний віденський лагер, має збалансований смак, невелику гірчинку, виражений фруктовий післясмак та аромат.",
                        ImageUrl = "https://www.beer.ua/wp-content/uploads/2022/10/Pyvo-Hrebucha-Korova.png"
                    },
                    new CraftBeer
                    {
                        Name = "Captain Salt",
                        Price = 66,
                        Volume = 0.33,
                        ABV = 5.0,
                        Description = "На кособокій лавці у таверні, оповитий димом з потертої люльки, старий морський вовк вдихає аромат з келиха, робить ковток і чує шум бурхливих хвиль," +
                        "крики мартинів, гомін матросів, шурхіт піску незвіданих островів під ногами, бачить напнуті вітрила і відчуває гарячі поцілунки південних красунь з далеких портів і " +
                        "солоні долоні океану. Потроху видиво зникає. Ще один келих Captain Salt, будь ласка. Персональне море у келиху – так ми уявляли собі наш перший гозе.",
                        ImageUrl = "https://www.beer.ua/wp-content/uploads/2022/09/Captain-Salt-Varvar-Brew.webp"
                    }
                };
                    context.CraftBeers.AddRange(beers);

                    var deliveryCompanies = new List<DeliveryCompany>
                {
                    new DeliveryCompany{Name ="Нова пошта"},
                    new DeliveryCompany{Name ="Укрпошта" },
                };
                    context.DeliveryCompanies.AddRange(deliveryCompanies);
                    context.SaveChanges();

                    var deliveryAddresses = new List<DeliveryAddress>
                {
                      new DeliveryAddress{City="Рівне",Address="33010, вул. Дубенська, 46",DeliveryCompany=deliveryCompanies.FirstOrDefault(x=>x.Id==2)},
                      new DeliveryAddress{City="Луцьк  ",Address="Відділення №19 (до 30 кг): вул. Рівненська, 109",DeliveryCompany=deliveryCompanies.FirstOrDefault(x=>x.Id==1)},
                      new DeliveryAddress{City="Вінниця ",Address="Відділення №11 (до 30 кг на одне місце): вул. Стрілецька, 14, прим. 178",DeliveryCompany=deliveryCompanies.FirstOrDefault(x=>x.Id==1)},
                };
                    context.DeliveryAddresses.AddRange(deliveryAddresses);
                    context.SaveChanges();

                    var orderStatuses = new List<OrderStatus>
                {
                    new OrderStatus{Name ="Скасоване" },
                    new OrderStatus{Name ="Відхилене"},
                    new OrderStatus{Name ="Нове"},
                    new OrderStatus{Name ="У процесі обробки"},
                    new OrderStatus{Name ="Відправлене"},
                    new OrderStatus{Name ="Успішно виконане"}
                };
                    context.OrderStatuses.AddRange(orderStatuses);
                    context.SaveChanges();

                    var customerInfos = new List<CustomerInfo>
                {
                    new CustomerInfo{FirstName="Карина",LastName="Малина",Phone="0973274663",DbUser=manager.FindByIdAsync("1").Result},
                    new CustomerInfo{FirstName="Максим",LastName="Млин",Phone="0651232158",DbUser=manager.FindByIdAsync("2").Result},
                    new CustomerInfo{FirstName="Віктор",LastName="Неминайко",Phone="0642156621",DbUser=manager.FindByIdAsync("2").Result}
                };
                    context.CustomerInfos.AddRange(customerInfos);
                    context.SaveChanges();

                    context.Orders.Add(new Order
                    {
                        UniqueCode = "123-144-676",
                        Date = DateTime.UtcNow.ToString("dd-MM-yyyy"),
                        DeliveryAddress = deliveryAddresses.FirstOrDefault(x => x.Id == 1),
                        DbUser = manager.FindByIdAsync("1").Result,
                        CustomerInfo = customerInfos.FirstOrDefault(x => x.Id == 1),
                        OrderStatus = orderStatuses.FirstOrDefault(x => x.Name == "Нове"),
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem{Count=10,ItemPrice=40,CraftBeer=context.CraftBeers.FirstOrDefault(x=>x.Id==1)},
                        }
                    });

                    context.Orders.Add(new Order
                    {
                        UniqueCode = "123-144-677",
                        Date = DateTime.UtcNow.ToString("dd-MM-yyyy"),
                        DeliveryAddress = deliveryAddresses.FirstOrDefault(x => x.Id == 2),
                        DbUser = manager.FindByIdAsync("2").Result,
                        CustomerInfo = customerInfos.FirstOrDefault(x => x.Id == 2),
                        OrderStatus = orderStatuses.FirstOrDefault(x => x.Name == "Успішно виконане"),
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem{Count=5,ItemPrice=40,CraftBeer=context.CraftBeers.FirstOrDefault(x=>x.Id==1)},
                            new OrderItem{Count=2,ItemPrice=64,CraftBeer=context.CraftBeers.FirstOrDefault(x=>x.Id==2)},
                            new OrderItem{Count=1,ItemPrice=66,CraftBeer=context.CraftBeers.FirstOrDefault(x=>x.Id==3)},
                        }
                    });

                    context.Orders.Add(new Order
                    {
                        UniqueCode = "123-144-678",
                        Date = DateTime.UtcNow.ToString("dd-MM-yyyy"),
                        DeliveryAddress = deliveryAddresses.FirstOrDefault(x => x.Id == 3),
                        DbUser = manager.FindByIdAsync("2").Result,
                        CustomerInfo = customerInfos.FirstOrDefault(x => x.Id == 3),
                        OrderStatus = orderStatuses.FirstOrDefault(x => x.Name == "У процесі обробки"),
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem{Count=3,ItemPrice=40,CraftBeer=context.CraftBeers.FirstOrDefault(x=>x.Id==1)},
                            new OrderItem{Count=3,ItemPrice=66,CraftBeer=context.CraftBeers.FirstOrDefault(x=>x.Id==3)},
                        }
                    });

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
