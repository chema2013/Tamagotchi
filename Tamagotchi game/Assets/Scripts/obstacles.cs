using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float speed = 2f;

    void OnEnable()
    {
        //makes the script a coroutine
        StartCoroutine(waiter());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


     IEnumerator waiter()
{

    //waits 3 second before making another action
    yield return new WaitForSeconds(7);

    //once the time is completed it destroys the object
    Destroy(gameObject);
}
}
