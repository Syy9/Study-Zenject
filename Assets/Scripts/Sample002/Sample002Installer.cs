using UnityEngine;
using Zenject;

/// <summary>
/// Check to bind Same Type
/// Result ↓
/// [throws error : ZenjectException: Found multiple matches when only one was expected for type 'System.Int32' while building object with type 'Sample002'.]
/// * but if not bind [Sample002] , not throw error.
/// </summary>
/// <typeparam name="Sample002Installer"></typeparam>
public class Sample002Installer : MonoInstaller<Sample002Installer>
{
    public override void InstallBindings()
    {
        Container.Bind<int>().FromInstance(-1);
        Container.Bind<int>().FromInstance(3);
        Container.Bind<Sample002>().AsSingle().NonLazy();
    }
}

public class Sample002
{
    public Sample002(int bindValue)
    {
        Debug.Log("bind value =" + bindValue);
    }
}
