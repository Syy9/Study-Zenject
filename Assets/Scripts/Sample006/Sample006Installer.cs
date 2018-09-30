using UnityEngine;
using Zenject;

namespace Sample006
{
    public class Sample006Installer : MonoInstaller<Sample006Installer>
    {
        public override void InstallBindings()
        {
            // Container.Bind<Foo>().AsSingle();
            // Container.Bind<IBar>().To<Bar>().AsSingle();

            // Container.Bind<Bar>().AsTransient();
            // Container.Bind<Bar>().AsCached();

            // Container.Bind<Foo>().FromNew();
            // Container.Bind<Hoge>().FromInstance(new Hoge());
            // Container.BindInstance(new Hoge());
            // Container.BindInstance(5.13f);
            // Container.BindInstance("hoge");

            // Container.Bind<Hoge>().FromMethod(CreateHogeMethod);
        }

        Hoge CreateHogeMethod(InjectContext context)
        {
            return new Hoge();
        }
    }

    public interface IBar { }
    public class Bar : IBar { }

    public class Foo
    {
        IBar _bar;
        public Foo(IBar bar)
        {
            _bar = bar;
        }
    }

    public class Hoge
    {

    }
}
