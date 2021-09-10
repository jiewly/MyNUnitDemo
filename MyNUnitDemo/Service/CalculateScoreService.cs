using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Service
{
    public class CalculateScoreService
    {
        public bool Execute(string score)
        {
            int number;
            bool success = int.TryParse(score, out number);

            if (success)
            {
                var response = number >= 50 ? true : false;
                return response;
            }
            else
            {
                throw new Exception("Error! Please input number.");
            }
        }
    }
}