using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public interface IVacationTypeObserver:ISubject
    {
        /// <summary>
        /// Add observer to specific vacationType
        /// </summary>
        /// <param name="o"></param>
        /// <param name="vt"></param>
        void AddObserver(IObserver o, VacationType vt);

        /// <summary>
        /// Remove observer from specific vacationType
        /// </summary>
        /// <param name="o"></param>
        /// <param name="vt"></param>
        void RemoveObserver(IObserver o, VacationType vt);
    }
}
