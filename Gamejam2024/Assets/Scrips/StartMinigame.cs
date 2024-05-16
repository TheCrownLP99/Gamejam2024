using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartMinigame : MonoBehaviour
{
    [SerializeField] private string[] text;
    private int currentText = 0;

    private bool wasSeen = false;

    [SerializeField] private TMPro.TMP_Text textBox;
    [SerializeField] private GameObject gameScreen;

    private GameMaster gameMaster;

    void Start()
    {
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
    }
    private void OnEnable()
    {
        if (wasSeen == true)
        {
            currentText = 0;
            gameMaster.textEnded = true;
            gameScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (wasSeen == true)
        {
            currentText = 0;
            gameMaster.textEnded = true;
            gameScreen.SetActive(true);
            gameObject.SetActive(false);
        }
        textBox.text = "" + text[currentText];
    }

    public void Next()
    {
        currentText++;
        if (currentText >= text.Length)
        {
            wasSeen = true;
            currentText = 0;
            gameMaster.textEnded = true;
            gameScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
