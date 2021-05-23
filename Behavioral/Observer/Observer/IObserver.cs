namespace Observer
{
    public interface IObserver
    {
        /// <summary>
        /// Get updates from subject
        /// </summary>
        /// <param name="isubject"></param>
        void Update(ISubject isubject);
    }
}
