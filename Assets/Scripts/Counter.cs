using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text txtminusc;
    void Start()
    {
        txtminusc.text = "Counter: " + Counterdreck.maxcount;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(Counterdreck.currentcount > 0)
        {
            Counterdreck.currentcount--;
        }
        txtminusc.text = "Counter: " + Counterdreck.currentcount;
    }
}
