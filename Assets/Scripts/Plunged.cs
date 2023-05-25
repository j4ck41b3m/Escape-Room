using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunged : MonoBehaviour
{
    bool plunged;
    public GameObject plunger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plunged)
        {
            transform.position = plunger.transform.position;
            transform.rotation = plunger.transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("plunge"))
        {
            plunged = true;
            plunger = other.gameObject;
        }
    }
}
