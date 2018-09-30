using UnityEngine;
using Zenject;

public class Test001Installer : MonoInstaller<Test001Installer>
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("string bind value");
        Container.Bind<Hoge>().AsSingle().NonLazy();
    }
}

public class Hoge
{
    public Hoge(string bindValue)
    {
        Debug.Log(bindValue);
    }
}
