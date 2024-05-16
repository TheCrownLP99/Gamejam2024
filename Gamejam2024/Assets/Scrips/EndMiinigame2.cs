using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndMiinigame2 : MonoBehaviour
{
    private GameMaster gameMaster;
    [SerializeField] GameObject earthqukeGameScript;
    private EarthquakeGame earthquakeGame;

    [SerializeField] private TMPro.TMP_Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
        earthquakeGame = earthqukeGameScript.GetComponent<EarthquakeGame>();
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + earthquakeGame.perfectKlicks;
    }

    public void EndMinigame()
    {
        gameObject.SetActive(false);
        gameMaster.textEnded = true;
    }
}
