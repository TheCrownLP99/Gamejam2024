using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EarthquakeGame : MonoBehaviour
{
    [SerializeField] private Slider timeSlider;
    [SerializeField] private AudioSource sound;
    [SerializeField] private GameObject minigame;

    private bool hascklickt = false;

    [SerializeField] private GameObject land1;
    [SerializeField] private GameObject land2;
    [SerializeField] private GameObject land3;
    [SerializeField] private GameObject land4;
    [SerializeField] private GameObject land5;
    [SerializeField] private GameObject land6;

    [SerializeField] private float minigameTime= 10f;

    private float t;
    private int randomNumber;

    public int perfectKlicks;

    private GameMaster gameMaster;

    [SerializeField] private float death = 100000;

    // Start is called before the first frame update
    void Start()
    {
        hascklickt = false;
        t = minigameTime;
        perfectKlicks = 0;
        timeSlider.maxValue = minigameTime;
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
        //randomNumber = Random.Range(0, 6);
        //Activate();

    }

    void OnEnable()
    {
        hascklickt = false;
        t = minigameTime;
        perfectKlicks = 0;
        timeSlider.maxValue = minigameTime;
        randomNumber = Random.Range(0, 6);
        Activate();
    }
    // Update is called once per frame
    void Update()
    {
        t = t - Time.deltaTime;
        timeSlider.value = t;

        if (t <= 0)
        {
            randomNumber = Random.Range(0, 6);
            float hitCalualted = perfectKlicks / 2;
            gameMaster.population = gameMaster.population - (death * hitCalualted);
            minigame.SetActive(false);
        }
    }

    public void Land1()
    {
        hascklickt = true;
        land1.SetActive(false);
        if (randomNumber == 0)
        {
            perfectKlicks++;
            while (randomNumber == 0)
            {
                randomNumber = Random.Range(0, 6);
            }
            Activate();
        }
    }
    public void Land2()
    {
        hascklickt = true;
        land2.SetActive(false);
        if (randomNumber == 1)
        {
            perfectKlicks++;
            while (randomNumber == 1)
            {
                randomNumber = Random.Range(0, 6);
            }
            Activate();
        }
    }
    public void Land3()
    {
        hascklickt = true;
        land3.SetActive(false);
        if (randomNumber == 2)
        {
            perfectKlicks++;
            while (randomNumber == 2)
            {
                randomNumber = Random.Range(0, 6);
            }
            Activate();
        }
    }
    public void Land4()
    {
        hascklickt = true;
        land4.SetActive(false);
        if (randomNumber == 3)
        {
            perfectKlicks++;
            while (randomNumber == 3)
            {
                randomNumber = Random.Range(0, 6);
            }
            Activate();
        }
    }
    public void Land5()
    {
        hascklickt = true;
        land5.SetActive(false);
        if (randomNumber == 4)
        {
            perfectKlicks++;
            while (randomNumber == 4)
            {
                randomNumber = Random.Range(0, 6);
            }
            Activate();
        }

    }
    public void Land6()
    {
        hascklickt = true;
        land6.SetActive(false);
        if (randomNumber == 5)
        {
            perfectKlicks++;
            while (randomNumber == 5)
            {
                randomNumber = Random.Range(0, 6);
            }
            Activate();
        }

    }

    public void Activate()
    {
        if (randomNumber == 0)
        {
            land1.SetActive(true);
        }
        else if (randomNumber == 1)
        {
            land2.SetActive(true);
        }
        else if (randomNumber == 2)
        {
            land3.SetActive(true);
        }
        else if (randomNumber == 3)
        {
            land4.SetActive(true);
        }
        else if (randomNumber == 4)
        {
            land5.SetActive(true);
        }
        else if (randomNumber == 5)
        {
            land6.SetActive(true);
        }
    }
}
