using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WitActivator : MonoBehaviour
{
    public bool pressed;
    public float timer;
    public TextMeshProUGUI message;
    [SerializeField] private Wit wit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (pressed == true)
        {
            wit.Activate();

        }
        timer =+ Time.deltaTime;
        if (timer >= 10)
        {
            wit.Deactivate();

        }
    }

    private void OnValidate()
    {
        if (!wit) wit = GetComponent<Wit>();
        timer = 0;
    }

}
