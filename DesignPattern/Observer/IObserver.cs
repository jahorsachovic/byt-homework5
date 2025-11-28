

namespace DesignPattern.Observer
{
    public interface IObserver
    {
        void Update(Subject subject, string availability);
    }
}
