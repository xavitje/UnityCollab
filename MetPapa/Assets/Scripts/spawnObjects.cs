using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class spawnObjects : MonoBehaviour
{
    public GameObject[] gameObjects;

    [SerializeField] float spawnTime = 3f; //timeframe variable
    private float tempCounter = 0f; //timeframe temp variable

    void FixedUpdate()
    {

        if (tempCounter <= 0f)  //check if the counter equals 0
        {
            SpawnObject();  //spawn the object
            tempCounter = spawnTime;  //reset the timer or cd
        }
        else
        {
            tempCounter -= Time.deltaTime;  //take down time 
        }

    }
    void SpawnObject()
    {
        int randomIndex = Random.Range(0, gameObjects.Length);
        GameObject clone = Instantiate(gameObjects[randomIndex], transform.position, Quaternion.AngleAxis(90, Vector3.left));
        Destroy(clone, 10f);

    }
}
