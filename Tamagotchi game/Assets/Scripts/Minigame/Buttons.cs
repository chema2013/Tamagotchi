using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject minigame;

    public GameObject idle;

    public GameObject sleep;

    public GameObject Asleep;

    public GameObject Eating;

    public GameObject Jump;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        minigame.SetActive(true);

        idle.SetActive(false);

        sleep.SetActive(false);

        Asleep.SetActive(false);

        Eating.SetActive(false);

        Jump.SetActive(false);
    }

}
