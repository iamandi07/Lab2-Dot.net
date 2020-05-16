using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Persistance.Context;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Expenses

namespace Lab2.Domain.Model
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExpensesContext(serviceProvider.GetRequiredService<DbContextOptions<ExpensesContext>>()))
            {
                // Look for any movies.
                if (context.ExpensesClasses.Any())
                {
                    return;   // DB table has been seeded
                }

                const string V = "2020-04-07T15:00:00";
                context.ExpensesClasses.AddRange(
                    new Expenses
                    {
                        Id = 1,
                        Description = "apple",
                        Sum = 25.25,
                        Location = "Kaufland",
                        Date = V,
                        Currency = "ron",
                        Type = "food",
                        Importance = Expenses.Importance.low,
                        Expenses.Status = Expenses.Status.optional
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
