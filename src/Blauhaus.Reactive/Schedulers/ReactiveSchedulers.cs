using System.Reactive.Concurrency;
using Blauhaus.Reactive.Abstractions.Schedulers;

namespace Blauhaus.Reactive.Schedulers
{
    public class ReactiveSchedulers : IReactiveSchedulers
    {
        public IScheduler CurrentThread => Scheduler.CurrentThread;
        public IScheduler Immediate => Scheduler.Immediate;
        public IScheduler NewThread => NewThreadScheduler.Default;
        public IScheduler ThreadPool => ThreadPoolScheduler.Instance;
        public IScheduler TaskPool => TaskPoolScheduler.Default;
    }
}