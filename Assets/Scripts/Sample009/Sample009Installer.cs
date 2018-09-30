using UnityEngine;
using Zenject;

namespace Sample009
{
    public class Sample009Installer : MonoInstaller<Sample009Installer>
    {
        public GameObject subGameObjectContextPrefab;
        public override void InstallBindings()
        {
            Container.Bind<Foo>().FromSubContainerResolve().ByMethod(InstallFooFacade).AsSingle();
            Container.Bind<Bar>().FromSubContainerResolve().ByInstaller<BarFacadeInstaller>().AsSingle();
            Container.Bind<Hoge>().FromSubContainerResolve().ByNewPrefab(subGameObjectContextPrefab).AsSingle();
        }

        void InstallFooFacade(DiContainer subCOntainer)
        {
            subCOntainer.Bind<Foo>().AsTransient();
        }
    }

    public class BarFacadeInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<Bar>().AsSingle();
        }
    }

    public class Foo
    {

    }
    public class Bar
    {

    }
}
