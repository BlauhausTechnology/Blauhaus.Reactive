using System.Reactive.Concurrency;

namespace Blauhaus.Reactive.Abstractions.Scheduler
{
    public interface IReactiveScheduler
    {
        IScheduler CurrentThread { get; }
        IScheduler Immediate { get; }
        IScheduler NewThread { get; }
        IScheduler ThreadPool { get; }
        IScheduler TaskPool { get; } 
    }
}