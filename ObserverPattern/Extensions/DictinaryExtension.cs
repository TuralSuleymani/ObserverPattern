using ObserverPattern.Observer;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Extensions
{
  public static  class DictinaryExtension
    {
        public static bool ContainsValue(this Dictionary<IObserver, List<VacationType>> continer,IObserver key, VacationType vacationType)
        {
           Dictionary<IObserver,List<VacationType>>.ValueCollection vc = continer.Values;

            if (continer.ContainsKey(key))
            {
                foreach (var item in continer.Values)
                {
                    if (item.Contains(vacationType))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
