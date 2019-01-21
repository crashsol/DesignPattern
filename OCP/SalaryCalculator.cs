using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
   public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerReports;

        public SalaryCalculator(List<BaseSalaryCalculator> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var item in _developerReports)
            {
                totalSalaries += item.CalculateSalary();
               
            }
            return totalSalaries;
        }
    }
}
