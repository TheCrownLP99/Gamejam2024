using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndMiinigame1 : MonoBehaviour
{
    private GameMaster gameMaster;
    [SerializeField] GameObject astroidGameScript;
    private AstroidGame astroidGame;

    [SerializeField] private TMPro.TMP_Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
        astroidGame = astroidGameScript.GetComponent<AstroidGame>();
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + astroidGame.hitAstroids;
    }

    public void EndMinigame()
    {
        gameObject.SetActive(false);
        gameMaster.textEnded = true;
    }
}
