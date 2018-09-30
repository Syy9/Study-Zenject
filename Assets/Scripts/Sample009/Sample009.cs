using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Sample009
{
    public class Sample009 : MonoBehaviour
    {
        [Inject]
        public void Init(Foo foo,Bar bar, Hoge hoge)
        {
            Debug.Log("Sample009 Init");
        }
    }
}
