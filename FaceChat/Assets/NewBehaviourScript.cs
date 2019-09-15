using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class NewBehaviourScript : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        UnityEngine.XR.XRSettings.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
