using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
   public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var item in _developerReports)
            {
                totalSalaries += item.HourlyRate * item.WorkingHours;
            }
            return totalSalaries;
        }
    }
}
