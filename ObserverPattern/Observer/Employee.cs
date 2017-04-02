using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
   internal class Employee:IObserver
    {
       
        public byte Age { get; set; }

        public string FIO
        {
            get;set;
        }

        public void Register(ISubject subject)
        {
            subject.AddObserver(this);
        }

        public void UnRegister(ISubject subject)
        {
            subject.RemoveObserver(this);
        }

        public void Notify(string info)
        {
            Console.WriteLine(info);
        }

      
    }
}
