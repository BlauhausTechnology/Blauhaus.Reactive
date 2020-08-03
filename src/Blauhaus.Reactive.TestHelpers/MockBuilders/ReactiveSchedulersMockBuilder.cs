using System.Reactive.Concurrency;
using Blauhaus.Reactive.Abstractions.Schedulers;
using Blauhaus.TestHelpers.MockBuilders;
using Microsoft.Reactive.Testing;

namespace Blauhaus.Reactive.TestHelpers.MockBuilders
{
    public class ReactiveSchedulersMockBuilder : BaseMockBuilder<ReactiveSchedulersMockBuilder, IReactiveSchedulers>
    {
        public ReactiveSchedulersMockBuilder()
        {
            With(x => x.Immediate, Scheduler.Immediate);
            With(x => x.CurrentThread, Scheduler.Immediate);
            With(x => x.NewThread, Scheduler.Immediate);
            With(x => x.TaskPool, Scheduler.Immediate);
            With(x => x.ThreadPool, Scheduler.Immediate);
        }
         
        public TestScheduler With_Test_ImmediateScheduler()
        {
            var testScheduler = new TestScheduler();
            With(x => x.Immediate, testScheduler);
            return testScheduler;
        }
        
        public TestScheduler With_Test_CurrentThreadScheduler()
        {
            var testScheduler = new TestScheduler();
            With(x => x.CurrentThread, testScheduler);
            return testScheduler;
        }
        
        public TestScheduler With_Test_NewThreadScheduler()
        {
            var testScheduler = new TestScheduler();
            With(x => x.NewThread, testScheduler);
            return testScheduler;
        }
        public TestScheduler With_Test_TaskPoolScheduler()
        {
            var testScheduler = new TestScheduler();
            With(x => x.TaskPool, testScheduler);
            return testScheduler;
        }
        
        public TestScheduler With_Test_ThreadPoolScheduler()
        {
            var testScheduler = new TestScheduler();
            With(x => x.ThreadPool, testScheduler);
            return testScheduler;
        }
    }
}