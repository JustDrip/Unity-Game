using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Checkpoint : MonoBehaviour
{
    public Text Score;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (Score.text == "Schlüssel gefunden: 0/3" || Score.text == "Schlüssel gefunden: 1/3")
            {
                SceneManager.LoadScene("Schlaflabyrinth_1");
            }

        }
    }
}
