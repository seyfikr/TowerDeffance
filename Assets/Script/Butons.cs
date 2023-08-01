using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butons : MonoBehaviour
{
    public GameObject StopPanel,stopButton;
    public void StopButton()
    {
        StopPanel.SetActive(true);
        Time.timeScale = 0;
        stopButton.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
    public void CountinueButton()
    {
        StopPanel.SetActive(false);
        Time.timeScale = 1;
        stopButton.SetActive(true);
    }

}
