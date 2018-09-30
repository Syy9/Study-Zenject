using UnityEngine;
using Zenject;

namespace Sample007
{
    public class Sample007Use : MonoBehaviour
    {
        Sample007 _sample;
        [Inject]
        public void Init(Sample007 sample)
        {
            _sample = sample;
            Debug.Log("Sample007Use : Init");
        }
    }
}
