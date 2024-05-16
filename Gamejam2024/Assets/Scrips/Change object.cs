using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changeobject : MonoBehaviour
{
    [SerializeField] private GameObject[] probs;

    private float devidedHumanAndProbs;
    private float stebs = 0;
    private int currentProb = 0;


    private GameMaster gameMaster;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("Gamemaster").GetComponent<GameMaster>();
        devidedHumanAndProbs = gameMaster.population / probs.Length;
        stebs = gameMaster.population - devidedHumanAndProbs;

        for (int i = 0; i < probs.Length; i++)
        {
            GameObject obj = probs[i];
            int randomizeArray = Random.Range(0, i);
            probs[i] = probs[randomizeArray];
            probs[randomizeArray] = obj;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (stebs >= gameMaster.population)
        {
            Debug.Log("test1");
            if (currentProb <= probs.Length)
            {
                Debug.Log("test2");
                Transform normal = probs[currentProb].transform.GetChild(0);
                Transform Dead = probs[currentProb].transform.GetChild(1);
                normal.gameObject.SetActive(false);
                Dead.gameObject.SetActive(true);
                Debug.Log("test3");
                currentProb++;
                stebs = stebs - devidedHumanAndProbs;
                Debug.Log("test4");
                Debug.Log("currentProb: " + currentProb + " probs.Length: " + probs.Length + " normal: " + normal.gameObject + "Dead: " + Dead.gameObject);
            }
        }
    }
}
