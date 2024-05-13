using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AstroidGame : MonoBehaviour
{
    [SerializeField] private Slider destructionSlider;
    [SerializeField] private AudioSource sound;
    [SerializeField] private GameObject minigame;

    [SerializeField] private Slider planetSlider;
    [SerializeField] private Transform spawnPositionLeft;
    [SerializeField] private Transform spawnPositionRight;

    [SerializeField] private GameObject astoidObject;

    [SerializeField] private int astoid = 10;

    [SerializeField] private float timeDown = 0.01f;

    private int i = 0;
    private float timeAstriods = 0;
    private float timeBetweenAstriots = 0;

    [SerializeField] private float timeBetweenAstriotsDefult = 1;

    public int hitAstroids;

    // Start is called before the first frame update

    void Start()
    {
        planetSlider.value = 0.5f;
        hitAstroids = 0;
        i = 0;
        destructionSlider.maxValue = astoid;
        timeBetweenAstriots = timeBetweenAstriotsDefult;
    }

    void OnEnable()
    {
        planetSlider.value = 0.5f;
        hitAstroids = 0;
        i = 0;
        destructionSlider.maxValue = astoid;
        timeBetweenAstriots = timeBetweenAstriotsDefult;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        destructionSlider.value = hitAstroids;
        timeAstriods = timeAstriods + Time.deltaTime;
        Debug.Log("test");
        if (timeAstriods >= timeBetweenAstriots)
        {
            if (i < astoid)
            {
                Debug.Log("test1");
                i++;
                SpawnAstroids();
                timeAstriods = 0;
            }
            else if (timeAstriods >= 2)
            {
                minigame.SetActive(false);
            }
        }
    }
    private void SpawnAstroids()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(spawnPositionLeft.position.x, spawnPositionRight.position.x), spawnPositionLeft.position.y, spawnPositionLeft.position.z);
        Instantiate(astoidObject, randomSpawnPosition, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        sound.Play();
        hitAstroids++;
        timeBetweenAstriots = timeBetweenAstriots - timeDown;
    }

}