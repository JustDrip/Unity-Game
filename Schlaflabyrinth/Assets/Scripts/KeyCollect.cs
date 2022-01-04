using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyCollect : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene("Menu");
            //EndScreen.enabled = true;
            //EndText.enabled = true;
            //EndButton.enabled = true;
            //EndImage.enabled = true;
            //EndText2.enabled = true;
            //EndRestart.enabled = true;
            //EndRestartText.enabled = true;
            //EndImage2.enabled = true;
        }
    }


}


