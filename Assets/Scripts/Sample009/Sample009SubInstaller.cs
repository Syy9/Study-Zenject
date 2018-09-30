using UnityEngine;
using Zenject;

namespace Sample009
{
    public class Sample009SubInstaller : MonoInstaller<Sample009SubInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Hoge>().AsSingle();
        }
    }

    public class Hoge
    {

    }
}
