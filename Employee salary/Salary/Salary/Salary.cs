using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Salary
    {
        private double basic;
        private double bonus;
        private double other;

        public Salary(double basic, double bonus, double other)
        {
            this.basic = basic;
            this.bonus = bonus;
            this.other = other;
        }
        public double Basic
        {
            get { return basic; }
        }
        public double Bonus
        {
            get { return bonus; }
        }
        public double Other
        {
            get { return other; }
        }
        public double TotalAmound()
        {
            double Total = basic + bonus + other;
            return Total;
        }
        public void Show()
        {
            Console.WriteLine("Basic:" + basic);
            Console.WriteLine("Bonus:" + bonus);
            Console.WriteLine("Other:" + other);
            Console.WriteLine("Total Salary:" + TotalAmound());
        }
    }
}
