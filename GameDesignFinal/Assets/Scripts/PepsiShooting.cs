using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepsiShooting : MonoBehaviour {
    public GameObject prefab;
    public float coolDown;
    float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z) && timer < Time.time)
        {
            //Debug.Log("Something should happen");
            GameObject bulletCap = Instantiate(prefab) as GameObject;
            bulletCap.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1);
            timer = coolDown + Time.time;
        }
	}
}
