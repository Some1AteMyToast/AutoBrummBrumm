using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziellinie : MonoBehaviour
{
    public Text txtBestTime;
    public Text count;
    float time = 0;
    float bestTime = float.MaxValue;

    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Counterdreck.currentcount = Counterdreck.maxcount;
        count.text = "Counter: " + Counterdreck.currentcount;
        if (time < bestTime)
        {
            bestTime = time;
            txtBestTime.text = "Best Time: " + bestTime.ToString("0.##") + " Sekunden";
        }
        time = 0;
    }
}

    public static class Counterdreck
    {
        public static int maxcount = 3;
        public static int currentcount;
    }
