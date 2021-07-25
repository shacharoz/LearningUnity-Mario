using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControler : MonoBehaviour
{
    public KeyCode FireKey = KeyCode.Space;
    public GameObject BulletPrefab;

    void Update()
    {
        //if user click
        if (Input.GetKeyDown(FireKey))
        {
            CreateBullet();
        }
    }

    private void CreateBullet()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}



/*
        if (Time.time - timeCountSinceLastSpawn >= TimeGapBetweenAutomaticFire)
        {
            timeCountSinceLastSpawn = Time.time;

            CreateBullet();
        }
        */

    /*
     void Start()
    {
        /
        Debug.Log("Before sleep "+ Time.time); //0
        
        //you cannot sleep the game thread
        Thread.Sleep(5000);

        Debug.Log("After sleep " + Time.time); //5
        /

    }

    private float timeCountSinceLastSpawn = 0;
public int TimeGapBetweenAutomaticFire = 30; //Rate of Fire
*/