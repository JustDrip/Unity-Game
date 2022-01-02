using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpielEnde : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Schlaflabyrinth_1");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
