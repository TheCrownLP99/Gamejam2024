using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private GameObject infoScreen;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }

    public void Info()
    {
        infoScreen.SetActive(true);
    }
    public void Back()
    {
        infoScreen.SetActive(false);
    }
}
