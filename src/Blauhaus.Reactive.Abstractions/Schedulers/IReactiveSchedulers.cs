using System.Reactive.Concurrency;

namespace Blauhaus.Reactive.Abstractions.Schedulers
{
    public interface IReactiveSchedulers
    {
        IScheduler CurrentThread { get; }
        IScheduler Immediate { get; }
        IScheduler NewThread { get; }
        IScheduler ThreadPool { get; }
        IScheduler TaskPool { get; } 
    }
}