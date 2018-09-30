using UnityEngine;
using Zenject;
/// <summary>
/// Bind lifecycle check
/// Lifecycle is ↓
/// 1. InstallBindings Start
/// 2. InstallBindings End
/// 3. string bind value
/// 4. Null
/// 5. Sample001Installer Awake
/// 6. Sample001Installer Start
/// 7. Sample001Installer Update
/// </summary>
/// <typeparam name="Sample001Installer"></typeparam>
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
