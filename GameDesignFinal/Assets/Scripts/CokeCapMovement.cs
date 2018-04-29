using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeCapMovement : MonoBehaviour {
    Transform player;
    Vector3 movement;
    public float speed;
	// Use this for initialization
	void Start () {
        movement = Vector3.zero;
        player = GameObject.Find("PepsiCanPlayer").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null)
        {
            if(movement.Equals(Vector3.zero))
            {
                calculateMovement();
            }
            transform.position = transform.position + movement * speed * Time.deltaTime;
        }
        if(transform.position.x > 15 || transform.position.x < -15 || transform.position.y < -8 || player == null)
        {
            Destroy(gameObject);
        }
	}

    private void calculateMovement()
    {
        movement = new Vector3(player.position.x - transform.position.x, player.position.y - transform.position.y);
    }

    public void setTarget(Transform target)
    {
        player = target;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Pepsi")
        {
            col.gameObject.GetComponent<Health>().damaged();
            Destroy(gameObject);
        }
    }
}
