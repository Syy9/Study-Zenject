using UnityEngine;
using Zenject;

public class Sample003Installer : MonoInstaller<Sample003Installer>
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("sample003 value");
    }
}
