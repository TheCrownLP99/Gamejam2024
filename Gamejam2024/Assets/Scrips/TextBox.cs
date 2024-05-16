using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    private GameMaster gameMaster;

    [SerializeField] private string[] text;
    private int currentText = 0;

    [SerializeField] private TMPro.TMP_Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "" + text[currentText];
    }

    public void Next()
    {
        currentText++;
        if (currentText >= text.Length)
        {
            Debug.Log("text end");
            gameMaster.textEnded = true;
            gameObject.SetActive(false);
        }
    }
}
