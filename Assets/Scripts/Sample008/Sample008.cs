using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Sample008
{
    public class Sample008 : MonoBehaviour
    {
        [Inject]
        void Init(Bar bar)
        {
            Debug.Log("Sample008 Init");
        }
    }
}
