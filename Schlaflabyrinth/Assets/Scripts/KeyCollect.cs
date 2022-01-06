using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyCollect : MonoBehaviour
{
    public static int Keycounter = 1;
    public Text Scorechange;
    public GameObject Key;

    
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Scorechange.text = "Schlüssel gefunden: " + Keycounter + "/3";

            Key.active = false;

            if (Keycounter >= 2)
            {
                Keycounter = 3;
            }
            else
            {
                Keycounter++;
            }
            
        }
    }

    

}


