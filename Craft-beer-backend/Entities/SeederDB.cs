using Craft_beer_backend.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OilShop.Entities
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

                    roleName = "User";
                    result = managerRole.CreateAsync(new DbRole
                    {
                        Name = roleName
                    }).Result;

                    string email = "admin@gmail.com";
                    var user = new DbUser
                    {
                        Email = email,
                        UserName = email,
                        FullName = "Stepan New",
                        PhoneNumber = "+380974355566"
                    };
                    result = manager.CreateAsync(user, "12345678").Result;
                    result = manager.AddToRoleAsync(user, roleName).Result;

                    email = "user@gmail.com";
                    user = new DbUser
                    {
                        Email = email,
                        UserName = email,
                        FullName = "Hidan New",
                        PhoneNumber = "+380974355116"
                    };
                    result = manager.CreateAsync(user, "12345678").Result;
                    result = manager.AddToRoleAsync(user, roleName).Result;

                    context.CraftBeers.Add(new CraftBeer
                    {
                        Name = "Bud",
                        Price = 40,
                        Volume = 0.5,
                        ABV = 5.0,
                        Description = "Пиво Bud – всесвітньо відомий король серед пива був вперше представлений Адольфусом Бушем ще у 1876 році. Відтоді й досі BUD вариться з дотриманням високих стандартів якості, незмінних з плином часу.",
                        ImageUrl = "https://img3.zakaz.ua/09.1663274872.ad72436478c_2022-09-16_Victoria/09.1663274872.SNCPSG10.obj.0.1.jpg.oe.jpg.pf.jpg.1350nowm.jpg.1350x.jpg"
                    });

                    context.CraftBeers.Add(new CraftBeer
                    {
                        Name = "Гребуча Корова",
                        Price = 64,
                        Volume = 0.33,
                        ABV = 6.0,
                        Description = "Пиво Гребуча корова – це класичний віденський лагер, має збалансований смак, невелику гірчинку, виражений фруктовий післясмак та аромат.",
                        ImageUrl = "https://www.beer.ua/wp-content/uploads/2022/10/Pyvo-Hrebucha-Korova.png"
                    });

                    context.CraftBeers.Add(new CraftBeer
                    {
                        Name = "Captain Salt",
                        Price = 66,
                        Volume = 0.33,
                        ABV = 5.0,
                        Description = "На кособокій лавці у таверні, оповитий димом з потертої люльки, старий морський вовк вдихає аромат з келиха, робить ковток і чує шум бурхливих хвиль," +
                        "крики мартинів, гомін матросів, шурхіт піску незвіданих островів під ногами, бачить напнуті вітрила і відчуває гарячі поцілунки південних красунь з далеких портів і " +
                        "солоні долоні океану. Потроху видиво зникає. Ще один келих Captain Salt, будь ласка. Персональне море у келиху – так ми уявляли собі наш перший гозе.",
                        ImageUrl = "https://www.beer.ua/wp-content/uploads/2022/09/Captain-Salt-Varvar-Brew.webp"
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
