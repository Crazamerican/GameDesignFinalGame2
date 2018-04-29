using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepsiCapController : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(0, speed * Time.deltaTime);
        if(transform.position.y > 12)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("We Hit");
        if(col.gameObject.tag == "Coke")
        {
            Debug.Log("A Coke Boi");
            col.gameObject.GetComponent<Health>().damaged();
            Destroy(gameObject);
        }
    }
}
