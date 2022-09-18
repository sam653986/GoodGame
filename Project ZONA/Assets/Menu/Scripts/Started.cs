using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Started : MonoBehaviour
{
    public GameObject panel;

    public string Level;
    public void StartToPlay()
    {
        SceneManager.LoadScene(Level);
    }

    public void ToExiting()
    {
        Application.Quit();
    }
    public void Open()
    {
        panel.SetActive(true);
    }
    public void Close()
    {
        panel.SetActive(false);
    }
}
