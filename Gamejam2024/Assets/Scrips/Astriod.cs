using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astriod : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float Speed = -1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        rb.velocity = new Vector3(0, -Speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Object.Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(gameObject,0.0001f);
    }
}
