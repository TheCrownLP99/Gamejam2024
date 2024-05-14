using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EarthquakeGame : MonoBehaviour
{
    [SerializeField] private float Speed = 10f;
    private float startMousePosition;
    private bool isRotating = false;
    [SerializeField] private Camera cam;
    private string oneTag = "1";

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

    // Start is called before the first frame update
    void Start()
    {
        hascklickt = false;
        t = minigameTime;
        perfectKlicks = 0;
        timeSlider.maxValue = minigameTime;
        isRotating = false;
    }

    void OnEnable()
    {
        hascklickt = false;
        t = minigameTime;
        perfectKlicks = 0;
        timeSlider.maxValue = minigameTime;
        isRotating = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMousePosition = Input.mousePosition.x;
            isRotating = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }
        if (isRotating == true)
        {
            float currentMousePosition = Input.mousePosition.x;
            float mouseMovment = currentMousePosition - startMousePosition;
            transform.Rotate(Vector3.up, -mouseMovment * Speed * Time.deltaTime);
            startMousePosition = currentMousePosition;
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Bestimmung der Mausposition beim klicken
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            //wenn der raycast ein objekt trifft
            if (Physics.Raycast(ray, out hitPoint))
            {
                //wenn der raycast den tank trifft und nah genug dran ist
                if (hitPoint.collider.CompareTag(oneTag))
                {
                    Debug.Log("test");
                }
            }
        }
    }

    public void Land1()
    {
        hascklickt = true;
    }
    public void Land2()
    {
        hascklickt = true;
    }
    public void Land3()
    {
        hascklickt = true;
    }
    public void Land4()
    {
        hascklickt = true;
    }
    public void Land5()
    {
        hascklickt = true;
    }
    public void Land6()
    {
        hascklickt = true;
    }
}
