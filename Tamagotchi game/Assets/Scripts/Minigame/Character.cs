using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject game;

    public GameObject cha;

    public static bool stopSpawn;

    public GameObject Player;

    public bool isJumping;

    float jump = 6f;

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
        if(Input.GetKeyDown("space") && isJumping == false)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            //checks if the player is currently jumping
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col){

       
      Debug.Log("hit");

      if (col.gameObject.tag == "obstacle"){

          stopSpawn = true;

          cha.SetActive(true);

          game.SetActive(false);

          Player.GetComponent<Player>().health -= 30.00f;
        }

        if (col.gameObject.tag == "floor"){

          isJumping = false;
        }
 }

}
