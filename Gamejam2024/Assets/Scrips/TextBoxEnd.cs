using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxEnd : MonoBehaviour
{
    [SerializeField] private string[] text;
    private int currentText = 0;

    [SerializeField] private TMPro.TMP_Text textBox;
    [SerializeField] private GameObject finalScreen;

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
            finalScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
