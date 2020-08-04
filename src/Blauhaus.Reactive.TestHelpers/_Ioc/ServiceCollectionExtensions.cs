using Blauhaus.Reactive.Abstractions.Schedulers;
using Blauhaus.Reactive.TestHelpers.MockBuilders;
using Blauhaus.TestHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Reactive.Testing;

namespace Blauhaus.Reactive.TestHelpers._Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static ReactiveSchedulersMockBuilder AddMockReactiveSchedulers(this MockContainer mocks)
        {
            return mocks.AddMock<ReactiveSchedulersMockBuilder, IReactiveSchedulers>().Invoke();
        }
         
    }
}