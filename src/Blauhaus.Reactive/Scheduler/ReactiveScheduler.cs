using System.Reactive.Concurrency;
using Blauhaus.Reactive.Abstractions.Scheduler;

namespace Blauhaus.Reactive.Scheduler
{
    public class ReactiveScheduler : IReactiveScheduler
    {
        public IScheduler CurrentThread => System.Reactive.Concurrency.Scheduler.CurrentThread;
        public IScheduler Immediate => System.Reactive.Concurrency.Scheduler.Immediate;
        public IScheduler NewThread => NewThreadScheduler.Default;
        public IScheduler ThreadPool => ThreadPoolScheduler.Instance;
        public IScheduler TaskPool => TaskPoolScheduler.Default;
    }
}