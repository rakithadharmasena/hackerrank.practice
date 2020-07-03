using HackerrankPractice.Recurrsion;
using HackerrankPractice.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace HackerrankPractice
{
    class Program
    {
        private static ServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            RegisterServices();
            var solutionsFactory = _serviceProvider.GetService<SolutionFactory>();

            string userInput = string.Empty;
            //Solutions
            var solutions = new List<string>
            {
                "Davis' Staircase"
            };

            Console.WriteLine("Welcome To Gaba's Practice Ground\n");
            
            do
            {
                Console.WriteLine();
                for (int i = 0; i < solutions.Count; i++)
                {
                    Console.WriteLine("{0}.{1}", i + 1, solutions[i]);
                }
                
                Console.WriteLine("Enter Program Number and press ENTER to continue\n");
                Console.WriteLine("Enter q to quit\n");
                userInput = Console.ReadLine();

                int selection;
                if (int.TryParse(userInput, out selection))
                {
                    solutionsFactory.GetSolution(selection).Execute();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            } while (userInput!="q");
        }

        //have to write the DI part by hand as it is not provided out of the box
        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<SolutionFactory>();
            services.AddSingleton<DavisStairCase>()
                .AddSingleton<ISolution, DavisStairCase>(s => s.GetService<DavisStairCase>());
            _serviceProvider = services.BuildServiceProvider(true);
        }
    }
}
