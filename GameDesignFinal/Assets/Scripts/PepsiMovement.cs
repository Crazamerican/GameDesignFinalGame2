using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepsiMovement : MonoBehaviour {

    public float xspeed;
    public float yspeed;

    public GameObject background;
    float backgroundWidth;
    float backgroundHeight;

    PepsiShooting shooting;

    float boundsWidthMin;
    float boundsWidthMax;
    float boundsHeightMin;
    float boundsHeightMax;

    // Use this for initialization
    void Start () {
        backgroundWidth = background.GetComponent<SpriteRenderer>().bounds.size.x;
        backgroundHeight = background.GetComponent<SpriteRenderer>().bounds.size.y;
        boundsWidthMin =  - (1 / 2) * backgroundWidth;
        boundsHeightMin =  - (1 / 2) * backgroundHeight;
        boundsWidthMax = (1 / 2) * backgroundWidth;
        boundsHeightMax = (1 / 2) * backgroundHeight;
        shooting = GetComponent<PepsiShooting>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A) && transform.position.x > -9)
        {
            transform.position = transform.position + new Vector3(-xspeed, 0);
            
        }
        if(Input.GetKey(KeyCode.D) && transform.position.x < 9)
        {
            transform.position = transform.position + new Vector3(xspeed, 0);
        }
        if(Input.GetKey(KeyCode.W) && transform.position.y < 4.5)
        {
            transform.position = transform.position + new Vector3(0, yspeed);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -4.5)
        {
            transform.position = transform.position + new Vector3(0, -yspeed);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "pizza")
        {
            Destroy(col.gameObject);
            GetComponent<PepsiShooting>().Upgrade();
        }
    }
}
