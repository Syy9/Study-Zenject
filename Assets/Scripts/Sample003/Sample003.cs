using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// Simple Inject Sample
/// </summary>
public class Sample003 : MonoBehaviour {

    [Inject] string stringInjection;
    void Awake()
    {
        Debug.Log("Awake : " + stringInjection);
    }

    void Start()
    {
        Debug.Log("Start : " + stringInjection);
    }

    void Update()
    {
        Debug.Log(stringInjection);
    }
}
