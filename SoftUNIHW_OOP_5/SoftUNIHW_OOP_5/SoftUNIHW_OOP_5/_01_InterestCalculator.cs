using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_5
{
    public delegate decimal CalculateInterest(decimal sumOfMoney, double interest, int years);
    class InterestCalculator
    {
        private decimal sum;
        private double interest;
        private int years;
        private CalculateInterest method;
        private decimal result;

        public InterestCalculator(decimal sum, double interest, int years, CalculateInterest method)
        {
            this.sum = sum;
            this.interest = interest;
            this.years = years;
            this.method = method;
            this.result = this.method(this.sum, this.interest, this.years);
        }

        public string PrintCalculation()
        {
            return String.Format("\tMoney \tInterest \tYears \tResult\n\t{0} \t{1} \t\t{2} \t{3:C}", this.sum, this.interest, this.years, this.result);
        }

        public static void Test()
        {
            InterestCalculator firstcalc = new InterestCalculator(500, 5.6d, 10, Interest.CalculateCompoundInterest);
            Console.WriteLine(firstcalc.PrintCalculation());
            InterestCalculator secondcalc = new InterestCalculator(2500, 7.2d, 15, Interest.CalculateSimpleIntrest);
            Console.WriteLine(secondcalc.PrintCalculation());
        }
    }

    class Interest
    {
        public static decimal CalculateSimpleIntrest(decimal sumOfMoney, double interest, int years)
        {
            decimal intrest = sumOfMoney;
            interest = (double) sumOfMoney * (1 + ((interest / 100) * years));
            return (decimal)interest;
        }

        public static decimal CalculateCompoundInterest(decimal sumOfMoney, double interest, int years)
        {
            int length = 12;
            interest = (double)sumOfMoney * Math.Pow((double) (1 + ((interest / 100) / length)), (years * length));
            return (decimal)interest;
        } 
    }
}
