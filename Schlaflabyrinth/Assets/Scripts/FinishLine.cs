using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public Text Score;

    void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Player"))
        {
            if (Score.text == "Schl�ssel gefunden: 3/3")
            {
                SceneManager.LoadScene("Menu");
            }
   
        }
    }


}
