using UnityEngine;
using Zenject;

namespace Sample008
{
    public class Sample008Installer : MonoInstaller<Sample008Installer>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().FromFactory<FooFactory>();
            Container.Bind<Bar>().FromResolveGetter<Foo>(x => x.GetBar());
        }
    }

    public class Bar
    {
        public Bar()
        {
            Debug.Log("Bar Constructer");
        }
    }
    public class Foo
    {
        public Foo()
        {
            Debug.Log("Foo Constructer");
        }
        public Bar GetBar()
        {
            return new Bar();
        }
    }
    public class FooFactory : IFactory<Foo>
    {
        public Foo Create()
        {
            Debug.Log("FooCactory Create");
            return new Foo();
        }
    }
}
