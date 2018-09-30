using UnityEngine;
using Zenject;

public class Sample001Installer : MonoInstaller<Sample001Installer>
{
    void Awake()
    {
        Debug.Log("Sample001Installer Awake");
    }

    void Start()
    {
        Debug.Log("Sample001Installer Start");
    }

    void Update()
    {
        Debug.Log("Sample001Installer Update");
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
