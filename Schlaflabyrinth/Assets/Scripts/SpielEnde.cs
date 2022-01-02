using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpielEnde : MonoBehaviour
{

    [SerializeField] private KeyCode Exit = KeyCode.V;
    [SerializeField] private KeyCode Restart = KeyCode.R;
    

    private void Update()
    {
        if (Input.GetKey(Exit))
        {
            SceneManager.LoadScene("Menu");
            //Application.Quit();
        }
        if (Input.GetKey(Restart))
        {
            SceneManager.LoadScene("Schlaflabyrinth_1");
        }
    }

}
