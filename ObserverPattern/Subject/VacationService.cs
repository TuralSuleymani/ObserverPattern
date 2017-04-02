using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;
using ObserverPattern.Extensions;
namespace ObserverPattern.Subject
{
    public class VacationService : IVacationTypeObserver, IVacationObserver
    {
        //can use repository pattern here..Feel free to experiment..
        private Dictionary<IObserver, List<VacationType>> _data;

        private List<Vacation> _vacations;
        public VacationService()
        {
            _data = new Dictionary<Observer.IObserver, List<ObserverPattern.VacationType>>();
            _vacations = new List<ObserverPattern.Vacation>();
        }
        public void AddObserver(IObserver o)
        {
            _data.Add(o, AddAllVacation());
        }

        private List<VacationType> AddAllVacation()
        {
            List<VacationType> vt = new List<VacationType>();
            string[] arr = Enum.GetNames(typeof(VacationType));
            foreach (var item in arr)
            {
                vt.Add((VacationType)Enum.Parse(typeof(VacationType), item));
            }
            return vt;
        }

        public void AddObserver(IObserver o, VacationType vt)
        {
            if (_data.ContainsKey(o))
                _data[o].Add(vt);
            else
                _data.Add(o, new List<VacationType>() { vt });
        }

        public void NotifyObservers()
        {
            foreach (Vacation vacation in _vacations)
            {
                foreach (KeyValuePair<IObserver, List<VacationType>> item in _data)
                {
                    if(item.Value.Contains(vacation.VacationType))
                    {
                      Console.WriteLine(String.Format("Dear {0},We have {1} vacation with price {2}$", item.Key.FIO, vacation.VacationType, vacation.Price)); 
                    }
                }
            }

           
        }

        public void RemoveObserver(IObserver o)
        {
            if (_data.ContainsKey(o))
                _data.Remove(o);
        }

        public void RemoveObserver(IObserver o, VacationType vt)
        {
            
               if( _data.ContainsValue(o,vt))
                {
                _data.Remove(o);
                }
        }

        public void AddVacation(Vacation vacation)
        {
            if(!_vacations.Contains(vacation))
            _vacations.Add(vacation);
        }

        public void RemoveVacation(Vacation vacation)
        {
            if (_vacations.Contains(vacation))
                _vacations.Remove(vacation);
        }
    }
}
