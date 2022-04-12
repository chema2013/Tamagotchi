using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
     public GameObject[] prefab;
     public float spawnTime;
    public float spawnDelay;

    void OnEnable()
    {
        //makes the script a coroutine
        InvokeRepeating("spawn", spawnTime, spawnDelay);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
{
    GameObject select = prefab[Random.Range(0, 2)];

    float posx = Random.Range(5, 8);

    //sets variables that will be used in the new vector3
               float positionX = posx;

               if(select == prefab[0])
    {
        //defined the vector3 position using the player's position as reference
               Vector3 position = new Vector3(positionX, 1.7829f, 0f);

               GameObject obs;

           obs = Instantiate (select, position, Quaternion.identity); 

           obs.transform.SetParent (transform);
    }
    else
    {
        //defined the vector3 position using the player's position as reference
               Vector3 position = new Vector3(positionX, 1.54f, 0f);

            GameObject obs;

           obs = Instantiate (select, position, Quaternion.identity);

           obs.transform.SetParent (transform);
    }

    bool stop = Character.stopSpawn;

    if(stop == true)
    {
        CancelInvoke("spawn");

        foreach (Transform child in transform)
         {
             Destroy(child.gameObject);
         }

    }

               
}

}
