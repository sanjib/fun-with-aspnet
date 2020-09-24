using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Monthly investment is required.")]
        [Range(1, 500, ErrorMessage = "Monthly investment amount should be between 1 to 500.")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Yearly interest rate is required.")]
        [Range(0.1, 10, ErrorMessage = "Yearly interest rate should be between 0.1 to 10 percent.")]
        public decimal? YearlyInterestRatePercent { get; set; }

        [Required(ErrorMessage = "Years is required.")]
        [Range(1, 50, ErrorMessage = "Years should be between 1 to 50.")]
        public int? NumberOfYearsToInvest { get; set; }

        public decimal? CalculateFutureValue()
        {
            decimal? monthlyInterestRate = YearlyInterestRatePercent / 12 / 100;
            int? months = NumberOfYearsToInvest * 12;
            decimal? futureValue = 0;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}
