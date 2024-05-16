using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public bool textEnded;

    [SerializeField] private GameObject startText;

    public float population;
    public float playTime = 0;
    [SerializeField] private TMPro.TMP_Text populationText;
    [SerializeField] private Slider populationSlider;

    [SerializeField] private TMPro.TMP_Text timerText;

    [SerializeField] private GameObject endMenu;

    [Header("Astroids Game")]
    [SerializeField] private float astroidsCooldownPreset = 10;
    private float astroidsCooldown;
    [SerializeField] private Slider astroidsSlider;
    [SerializeField] private GameObject astroidsGame;

    [Header("Earthquake Game")]
    [SerializeField] private float earthquakeCooldownPreset = 9;
    private float earthquakeCooldown;
    [SerializeField] private Slider earthquakeSlider;
    [SerializeField] private GameObject earthquakeGame;

    [Header("Tronado Game")]
    [SerializeField] private float tornadoCooldownPreset = 8;
    private float tornadoCooldown;
    [SerializeField] private Slider tornadoSlider;

    [Header("Tsunami Game")]
    [SerializeField] private float tsunamiCooldownPreset = 7;
    private float tsunamiCooldown;
    [SerializeField] private Slider tsunamiSlider;

    // Start is called before the first frame update
    void Start()
    {
        startText.SetActive(true);

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        populationSlider.maxValue = population;

        astroidsCooldown = astroidsCooldownPreset;
        earthquakeCooldown = earthquakeCooldownPreset;
        tornadoCooldown = tornadoCooldownPreset;
        tsunamiCooldown = tsunamiCooldownPreset;

        astroidsSlider.maxValue = astroidsCooldownPreset;
        earthquakeSlider.maxValue = earthquakeCooldownPreset;
        tornadoSlider.maxValue = tornadoCooldownPreset;
        tsunamiSlider.maxValue = tsunamiCooldownPreset;
    }

    // Update is called once per frame
    void Update()
    {
        if (population <= 0)
        {
            population = 0;
        }
        if (population <= 0 && textEnded == true)
        {
            EndGame();
        }
        else if (textEnded == true)
        {
            playTime = playTime + Time.deltaTime;
            astroidsCooldown = astroidsCooldown + Time.deltaTime;
            earthquakeCooldown = earthquakeCooldown + Time.deltaTime;
            tornadoCooldown = tornadoCooldown + Time.deltaTime;
            tsunamiCooldown = tsunamiCooldown + Time.deltaTime;
        }

        populationText.text = "" + population.ToString("n0");
        populationSlider.value = population;
        astroidsSlider.value = astroidsCooldown;
        earthquakeSlider.value = earthquakeCooldown;
        tornadoSlider.value = tornadoCooldown;
        tsunamiSlider.value = tsunamiCooldown;

        int minutes = (int)playTime / 60;
        int seconds = (int)playTime - 60 * minutes;
        int milliseconds = (int)(1000 * (playTime - minutes * 60 - seconds));
        timerText.text = "" + string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    private void EndGame()
    {
        endMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }

    public void Astroids()
    {
        if (astroidsCooldown >= astroidsCooldownPreset)
        {
            astroidsCooldown = 0;
            textEnded = false;
            astroidsGame.SetActive(true);
        }
    }
    public void Earthquake()
    {
        if (earthquakeCooldown >= earthquakeCooldownPreset)
        {
            earthquakeCooldown = 0;
            textEnded = false;
            earthquakeGame.SetActive(true);
        }
    }
    public void Tornado()
    {
        if (tornadoCooldown >= tornadoCooldownPreset)
        {
            tornadoCooldown = 0;
        }
    }
    public void Tsunami()
    {
        if (tsunamiCooldown >= tsunamiCooldownPreset)
        {
            tsunamiCooldown = 0;
        }
    }
}
