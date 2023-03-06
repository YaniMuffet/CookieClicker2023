using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform parentObject;

    private void Start()
    {
        //while   do while   for   for each

        int count = 0;
        while(count < 10)
        {
            count += 1;
            SpawnObject();
        }

    }

    public void SpawnObject()
    {
        Instantiate(spawnPrefab, parentObject.transform.position, Quaternion.identity, parentObject);
    }

 
}
