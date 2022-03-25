using System;
namespace WorkerTask
{
    class Worker : Person
    {
        public double SalaryPerHour;
        public int WorkHour;

        public Worker(string name, string surname, byte age, double salaryPerHour, int workHour) : base(name, surname, age)
        {
            this.SalaryPerHour = salaryPerHour;
            this.WorkHour = workHour;
        }
        public Worker(string name, string surname, byte age, double salaryPerHour) : base(name, surname, age)
        {
            this.SalaryPerHour = salaryPerHour;
        }
        public void CalcSalary(double salaryPerHour, byte age, int workHour = 0)
        {
            if (age < 18)
            {
                Console.WriteLine("Yasi 18-den asagilar isleye bilmez!");
            }
            else
            {
                double salaryPerMonth = salaryPerHour * workHour;
                Console.WriteLine(salaryPerMonth); 
            }
        }
    }
}
