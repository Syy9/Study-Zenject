using UnityEngine;
using Zenject;

public class Test001Installer : MonoInstaller<Test001Installer>
{
    void Awake()
    {
        Debug.Log("Test001Installer Awake");
    }

    void Start()
    {
        Debug.Log("Test001Installer Start");
    }

    void Update()
    {
        Debug.Log("Test001Installer Update");
    }

    public override void InstallBindings()
    {
        Debug.Log("InstallBindings Start");
        Container.Bind<string>().FromInstance("string bind value");
        Container.Bind<Hoge>().AsSingle().NonLazy();

        Debug.Log("InstallBindings End");
    }
}

public class Hoge
{
    [Inject] string fieldBindValue;
    public Hoge(string bindValue)
    {
        Debug.Log(bindValue);
        Debug.Log(fieldBindValue);
    }
}
