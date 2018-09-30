using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Sample004
{
    public class Sample004 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            var foo = new Foo();
            foo.DoSomething();

            var foo2 = new Foo2(new SomeService());
            foo2.DoSomething();
        }
    }

    public interface ISomeService
    {
        void Action();
    }

    public class SomeService : ISomeService
    {
        public void Action()
        {
            //do something
        }
    }

    public class Foo
    {
        ISomeService _service;
        public Foo()
        {
            _service = new SomeService();
        }

        public void DoSomething()
        {
            _service.Action();
        }
    }

    public class Foo2
    {
        ISomeService _service;
        public Foo2(ISomeService service)
        {
            _service = service;
        }

        public void DoSomething()
        {
            _service.Action();
        }
    }
}
