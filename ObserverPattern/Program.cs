using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    static class Program
    { 
        static void Main()
        {
            VacationService vs = new Subject.VacationService();

            Employee e = new Employee()
            {
                Age = 34,
                FIO = "Simon Baker"
            };

            Employee e2 = new Employee()
            {
                Age = 34,
                FIO = "Timur Tamike"
            };

            vs.AddVacation(new Vacation() { Price = 7000, VacationType = VacationType.CSHARP, Description = "Leading Sorfware Developer vacation" });
            vs.AddVacation(new Vacation() { Price = 7000, VacationType = VacationType.PHP, Description = "Leading Sorfware Developer vacation" });

            vs.AddObserver(e, VacationType.CSHARP);
            vs.AddObserver(e2, VacationType.JQUERY);
            vs.AddObserver(e2, VacationType.PHP);
            vs.NotifyObservers();

            Console.ReadLine();
        }
    }
}
