using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject minigame;

    public GameObject idle;

    public GameObject sleep;

    public GameObject Asleep;

    public GameObject Eating;

    public GameObject Jump;

    public GameObject Player;

    void OnEnable()
    {
        Debug.Log("start");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
        Debug.Log("quit");
    }

    if(Input.GetKeyDown(KeyCode.R)){
             Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
         }

    }

    public void Play()
    {
        if (idle.activeSelf)
        {
            minigame.SetActive(true);

            idle.SetActive(false);

            sleep.SetActive(false);

            Asleep.SetActive(false);

            Eating.SetActive(false);

            Jump.SetActive(false);
        }
    }

    public void Sleep()
    {
        if (idle.activeSelf)
        {

            minigame.SetActive(false);

            idle.SetActive(false);

            sleep.SetActive(true);

            Asleep.SetActive(false);

            Eating.SetActive(false);

            Jump.SetActive(false);

            StartCoroutine(sleepCoroutine());
        }
    }

    public void Feed()
    {

        if (!Eating.activeSelf && idle.activeSelf)
        {

            minigame.SetActive(false);

            idle.SetActive(false);

            sleep.SetActive(false);

            Asleep.SetActive(false);

            Eating.SetActive(true);

            Jump.SetActive(false);

            StartCoroutine(feedCoroutine());

        }
    }

    public void Back()
    {

        minigame.SetActive(false);

        idle.SetActive(true);

        sleep.SetActive(false);

        Asleep.SetActive(false);

        Eating.SetActive(false);

        Jump.SetActive(false);

    }

    IEnumerator sleepCoroutine()
    {
        yield return new WaitForSeconds(3);
        if (!idle.activeSelf && sleep.activeSelf && !Asleep.activeSelf && !Eating.activeSelf && !Jump.activeSelf)
        {
            Asleep.SetActive(true);

            sleep.SetActive(false);
        }
    }

    IEnumerator feedCoroutine()
    {
        yield return new WaitForSeconds(3);

        if (!idle.activeSelf && !sleep.activeSelf && !Asleep.activeSelf && Eating.activeSelf && !Jump.activeSelf)
        {
            idle.SetActive(true);

            Eating.SetActive(false);

            Player.GetComponent<Player>().Feed();
        }
    }
}
