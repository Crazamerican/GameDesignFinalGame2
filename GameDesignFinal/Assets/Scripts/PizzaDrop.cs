using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaDrop : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + new Vector3(0, -1) * Time.deltaTime * speed;
        if( transform.position.x < -12 || transform.position.x > 12 || transform.position.y < -8)
        {
            Destroy(gameObject);
        }
	}
}
