using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeMovement : MonoBehaviour {
    public float coolDown;
    float timer;

    float posX;
    float posY;
	// Use this for initialization
	void Start () {
        timer = Time.time + coolDown;
        posX = 0;
        posY = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(timer < Time.time)
        {
            pickRandomPosition();
            timer = Time.time + coolDown;
        }
        moveToPosition();
		
	}

    private void moveToPosition()
    {
        if(transform.position.x != posX)
        {
            transform.position = transform.position +  new Vector3((posX - transform.position.x) * 1f * Time.deltaTime, 0);
        }
        if(transform.position.y != posY)
        {
            transform.position = transform.position + new Vector3(0,(posY - transform.position.y) * 1f * Time.deltaTime);
        }
    }

    private void pickRandomPosition()
    {
        posX = UnityEngine.Random.Range(-9, 9);
        posY = UnityEngine.Random.Range(0, 4.5f);
        while(Mathf.Pow((posX - transform.position.x),2) + Mathf.Pow((posY - transform.position.y), 2) < 2)
        {
            posX = UnityEngine.Random.Range(-9, 9);
            posY = UnityEngine.Random.Range(0, 4.5f);
        }
    }
}
