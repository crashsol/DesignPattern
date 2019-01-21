using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    /// <summary>
    /// 工资计算抽象类
    /// </summary>
   public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();

    }
}
