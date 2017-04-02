using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    //Can be renamed as ISubscriber also..
    public interface IObserver
    {
        void Register(ISubject subject);
        void UnRegister(ISubject subject);
        void Notify(string info);
        string FIO { get; set; }

    }
}
