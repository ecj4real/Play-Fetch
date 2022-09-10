using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private static DateTime defaultTime;
    private int allowSpawnTime = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DateTime currentTime = DateTime.Now;
            if ((currentTime - defaultTime).TotalSeconds >= allowSpawnTime)
            {
                defaultTime = DateTime.Now;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            }
        }
    }
}
