using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light light;
    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            light.enabled = !light.enabled;
        }
        
    }
}
