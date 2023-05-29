using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keylock : MonoBehaviour
{
    int keynumber;
    GameObject[] keys;
    public GameObject door;
    Animator anim;
    AudioSource audi;
    public AudioClip clap;
    public bool opened;
    // Start is called before the first frame update
    void Start()
    {
        audi = GetComponent<AudioSource>();
        anim = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        keys = GameObject.FindGameObjectsWithTag("key");
        keynumber = keys.Length;
        if (keynumber <= 0 && opened == false)
        {
            anim.Play("sesame");
            opened = true;
            audi.PlayOneShot(clap);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            other.tag = "Untagged";
            other.GetComponent<Grabbable>().enabled = false;
            other.GetComponent<HandGrabInteractable>().enabled = false;

        }
    }
}
