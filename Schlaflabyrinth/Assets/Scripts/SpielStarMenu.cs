using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpielStarMenu : MonoBehaviour
{
    [SerializeField] private KeyCode Play = KeyCode.P;

    [SerializeField] private KeyCode Exit = KeyCode.Space;


    private void Update()
    {
        if (Input.GetKey(Play))
        {
            SceneManager.LoadScene("Schlaflabyrinth_1");
            
        }
        if (Input.GetKey(Exit))
        {
            Application.Quit();
        }
    }

}
