namespace Observer
{
    public interface ISubject
    {
        // Attach observers in subject
        void Attach(IObserver observer);

        // Detach observers in subject
        void Detach(IObserver observer);

        // Notify all observers about event
        void Notify();
    }
}
