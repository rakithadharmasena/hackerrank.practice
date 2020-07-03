using HackerrankPractice.Recurrsion;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankPractice.Services
{
    public class SolutionFactory
    {
        private readonly IServiceProvider serviceProvider;

        public SolutionFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }


        public ISolution GetSolution(int userSelection)
        {
            ISolution solution = null;
            switch (userSelection)
            {
                case 1:
                    solution = (ISolution)serviceProvider.GetService(typeof(DavisStairCase));
                    break;
                default:
                    break;
            }
            return solution;
        }
    }
}
