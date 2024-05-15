using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    private GameMaster gameMaster;

    private float bestscore;
    private float score;

    [SerializeField] private TMPro.TMP_Text scoreText;
    [SerializeField] private TMPro.TMP_Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
        bestscore = PlayerPrefs.GetFloat("Best", 100000000);
    }

    private void Update()
    {
        score = gameMaster.playTime;
        if (score <= bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetFloat("Best", bestscore);
        }

        int minutes = (int)score / 60;
        int seconds = (int)score - 60 * minutes;
        int milliseconds = (int)(1000 * (score - minutes * 60 - seconds));
        scoreText.text = "Score: " + string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);

        int minutesBest = (int)bestscore / 60;
        int secondsBest = (int)bestscore - 60 * minutesBest;
        int millisecondsBest = (int)(1000 * (bestscore - minutesBest * 60 - secondsBest));
        bestScoreText.text = "Highscore: " + string.Format("{0:00}:{1:00}:{2:000}", minutesBest, secondsBest, millisecondsBest);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
