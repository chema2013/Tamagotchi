using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    float happiness = 50.00f;
    float starvation = 30.00f;
    public float health = 80.00f;

    public GameObject Happiness;
    public GameObject Starvation;
    public GameObject Health;

    Image HappinessBar;
    Image StarvationBar;
    Image HealthBar;

    public GameObject minigame;

    public GameObject idle;

    public GameObject sleep;

    public GameObject Asleep;

    public GameObject Eating;

    public GameObject Jump;

    public GameObject Death;

    // Start is called before the first frame update
    void Start()
    {
        HappinessBar = Happiness.GetComponent<Image>();
        StarvationBar = Starvation.GetComponent<Image>();
        HealthBar = Health.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        happiness -= 0.20f * Time.deltaTime;
        starvation -= 0.40f * Time.deltaTime;
        health -= 0.10f * Time.deltaTime;

        if (Asleep.activeSelf)
        {
            health += 1.20f * Time.deltaTime;
            if (health > 100.00f)
            {
                health = 100.00f;
            }
        }

        if (minigame.activeSelf)
        {
            happiness += 2.25f * Time.deltaTime;
            if (happiness > 100.00f)
            {
                happiness = 100.00f;
            }
        }

        if (happiness < 0.00f)
        {
            happiness = 0.00f;

            health -= 0.80f * Time.deltaTime;
        }

        if (starvation < 0.00f)
        {
            starvation = 0.00f;

            health -= 0.80f * Time.deltaTime;
        }

        if (health < 0.00f)
        {
            health = 0.00f;
            starvation = 0.00f;
            happiness = 0.00f;

            minigame.SetActive(false);

            idle.SetActive(false);

            sleep.SetActive(false);

            Asleep.SetActive(false);

            Eating.SetActive(false);

            Jump.SetActive(false);

            Death.SetActive(true);

        }

        HappinessBar.fillAmount = happiness / 100.00f;
        StarvationBar.fillAmount = starvation / 100.00f;
        HealthBar.fillAmount = health / 100.00f;
    }

    public void Feed()
    {
        starvation += 30.00f;
        if (starvation > 100.00f)
        {
            starvation = 100.00f;
        }
    }

}
