using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touhou : MonoBehaviour {
    bool vert;
    bool leftStart;

	// Use this for initialization
	void Start () {
		if (enabled)
        {
            gameObject.GetComponent<CokeCapMovement>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<CokeCapMovement>().enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(vert)
        {
            transform.position = transform.position + new Vector3(0, -5) * Time.deltaTime;
        }
        else if (leftStart)
        {
            transform.position = transform.position + new Vector3(5, 0) * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + new Vector3(-5, 0) * Time.deltaTime;
        }

        if(transform.position.x > 15 || transform.position.x < -15 || transform.position.y < -8)
        {
            Destroy(gameObject);
        }
		
	}

    public void setVert(bool theBool)
    {
        vert = theBool;
    }

    public void setStart(bool start)
    {
        leftStart = start;
    }
}
