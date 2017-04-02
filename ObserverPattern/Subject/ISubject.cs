using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    public interface ISubject
    {
        /// <summary>
        /// Add observer
        /// </summary>
        /// <param name="o"></param>
        void AddObserver(IObserver o);
        /// <summary>
        /// Remove observer completely
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);

        /// <summary>
        /// Notify all observers..
        /// </summary>
        /// <param name="info"></param>
        void NotifyObservers();
    }
}
