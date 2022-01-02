using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private Image EndScreen;
    [SerializeField] private Text EndText;
    [SerializeField] private Button EndButton;
    [SerializeField] private Image EndImage;
    [SerializeField] private Text EndText2;
    [SerializeField] private Button EndRestart;
    [SerializeField] private Text EndRestartText;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndScreen.enabled = true;
            EndText.enabled = true;
            EndButton.enabled = true;
            EndImage.enabled = true;
            EndText2.enabled = true;
            EndRestart.enabled = true;
            EndRestartText.enabled = true;
        }   
    }
  
}
