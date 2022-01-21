using static DI_Demo.Model.LifeTime.LifeTimeSample;

namespace DI_Demo.Model.LifeTime
{
    public class CustomService
    {
        public ISample Transient { get; private set; }
        public ISample Scoped { get; private set; }
        public ISample Singleton { get; private set; }

        public CustomService(
            ISampleTransient transient,
            ISampleScoped scoped,
            ISampleSingleton singleton)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
        }
    }
}
