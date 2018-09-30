using UnityEngine;
using Zenject;

namespace Sample007
{
    public class Sample007Installer : MonoInstaller<Sample007Installer>
    {
        public GameObject prefab;
        public override void InstallBindings()
        {
            // Container.Bind<Sample007>().FromComponentSibling();
            // Container.Bind<Sample007>().FromComponentInParents();
            // Container.Bind<Sample007>().FromComponentInChildren();
            // Container.Bind<Sample007>().FromComponentInNewPrefab(prefab).AsSingle(); // require Score
            // Container.Bind<Sample007>().FromComponentInNewPrefabResource("Sample007").AsTransient(); // require Score

            // Container.Bind<IFoo>().To<IBar>().FromResolve();
            // Container.Bind<IBar>().To<Foo>();
        }
    }

    public interface IFoo
    {

    }

    public interface IBar : IFoo
    {

    }

    public class Foo : IBar
    {

    }
}
