using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject game;

    public static bool stopSpawn;

    void OnEnable()
    {
        stopSpawn = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){

       
      Debug.Log("hit");

      if (col.gameObject.tag == "obstacle"){

          stopSpawn = true;

          game.SetActive(false);
   }
 }

}
