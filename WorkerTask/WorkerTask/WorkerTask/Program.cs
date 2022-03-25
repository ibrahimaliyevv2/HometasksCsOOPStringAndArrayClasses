using System;

namespace WorkerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Eflatun";
            string surname = "Qubadov";
            byte age = 19;
            double salary = 12;
            int workhour = 5;

            Worker worker = new Worker(name, surname, age, salary);
            worker.CalcSalary(salary, age, workhour);
           
        }
    }
}
