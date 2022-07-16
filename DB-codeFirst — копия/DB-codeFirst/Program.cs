using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using DB_codeFirst.DbModels;
using System.Data.SqlTypes;

namespace DB_codeFirst
{
    public sealed class Program
    {
        internal static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
               // context.Database.EnsureCreated();

                var firstOffice = context.Office.SingleOrDefault(x => x.OfficeId == 1);

                if (firstOffice is not null)
                {
                    firstOffice.Title = "lalala";
                }

                //context
                //    .Title
                //    .Add(new Title
                //    {
                //        Name = "sec"

                //    });

                //context
                //    .Office
                //    .Add(new Office
                //    {
                //        Title = "no",
                //        Location = "45 hjks"
                //    });

                //context
                //    .Employee
                //    .Add(new Employee
                //    {
                //        FirstName = "Austin",
                //        LastName = "Powers",
                //        HiredDate = DateTime.Parse("06-06-2019 00:00:00"),
                //        DateOfBirth = DateTime.Parse("07-02-1988 00:00:00"),
                //        OfficeId = 1,
                //        TitleId = 1
                //    });

                //context
                //    .EmployeeProjects
                //    .Add(new EmployeeProject
                //    {
                //        Rate = 4,
                //        StartedDate = DateTime.Parse("07-06-2019 00:00:00"),
                //        EmployeeId = 1,
                //        ProjectId = 1
                //    });


                context.SaveChanges();

                var today = DateTime.Now;

                IQueryable date1 = context.Employee.Select(p => (today - p.HiredDate).TotalDays.ToString());
                IQueryable date2 = context.EmployeeProjects.Select(p => (today - p.StartedDate).TotalDays.ToString());

                foreach (var date in date1)
                {
                    Console.WriteLine(date.ToString());
                }


                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        tran.CreateSavepoint("start");
                        var first = context.Projects.SingleOrDefault(x => x.ProjectId == 1);
                        var second = context.Title.SingleOrDefault(x => x.Titleid == 1);

                        if (second is not null && first is not null)
                        {
                            first.Name = "o no";
                            second.Name = "mymymymy";
                        }

                        context.SaveChanges();
                        tran.Commit();
                        //context.Database.ExecuteSqlCommand(@"UPDATE People SET Age = Age + 1 WHERE Name = 'Sam'");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                    }
                }

                var f = new Employee
                {
                    FirstName = "lady",
                    LastName = "gaga",
                    HiredDate = DateTime.Parse("06-06-2019 00:00:00"),
                    DateOfBirth = DateTime.Parse("07-02-1988 00:00:00"),
                    OfficeId = 3,
                    TitleId = 2,
                    Title = new Title
                    {
                        Name = "meow"
                    }
                };

                context.Add(f);

                var s = new Project
                {
                    Name = "k",
                    Budget = 100,
                    Starteddate = DateTime.Parse("09-10-2020 00:00:00"),
                    ClientId = 6,
                    Client = new Client
                    {
                        FirstName = "o",
                        LastName = "k",
                        DateOfBirth = DateTime.Parse("09-10-2020 00:00:00"),
                        Request = "game"
                    }
                };

                context.Add(s);

                context.SaveChanges();


                var remove = context.Employee.SingleOrDefault(x => x.EmployeeId == 8);
                if (remove != null)
                {
                    context.Employee.Remove(remove);
                    context.SaveChanges();
                }

                var groups = context.Employee.GroupBy(x => x.Title.Name).Where(p => !(p.Key.Contains('a')));

                var tables = context.Client.Join(context.Projects,
                    c => c.ClientId,
                    p => p.ProjectId,
                    (c, p) => new
                    {
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Request = c.Request,
                        Budget = p.Budget
                    });

                foreach (var t in tables)
                    Console.WriteLine("{0} {1}: {2} - {3} ", t.FirstName, t.LastName, t.Request, t.Budget);
            }


            Console.WriteLine("done");
        } 
    }
}


