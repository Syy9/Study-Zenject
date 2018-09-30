using UnityEngine;
using Zenject;

namespace Sample005
{
    public class Sample005Installer : MonoInstaller<Sample005Installer>
    {
        public override void InstallBindings()
        {
        }
    }

    public interface IBar
    {
        void Hoge();
    }

    //Constructor Injection
    public class Foo
    {
        IBar _bar;
        public Foo(IBar bar)
        {
            _bar = bar;
        }
    }

    // Field Injection
    public class Foo2
    {
        [Inject] IBar _bar;
        [Inject] public IBar _bar2;
    }

    // Property Injection
    public class Foo3
    {
        [Inject]
        public IBar Bar { get; private set; }
    }

    //Method Injection
    public class Foo4
    {
        [Inject] IBar _bar;
        [Inject]
        public void Init(IBar bar)
        {
            _bar = bar;
        }
        [Inject]
        public void Init2()
        {
            
        }
    }
}
