using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepsiShooting : MonoBehaviour {
    public GameObject prefab;
    public float coolDown;
    float timer;

    int upgrade;
	// Use this for initialization
	void Start () {
        timer = 0;
        upgrade = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftShift) && timer < Time.time)
        {
            spawnBullets();
        }
	}

    void spawnBullets()
    {
        timer = coolDown + Time.time;
        if(upgrade == 1)
        {
            GameObject bulletCap = Instantiate(prefab) as GameObject;
            bulletCap.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1);
        }
        else if (upgrade == 2)
        {
            GameObject bulletCap = Instantiate(prefab) as GameObject;
            bulletCap.transform.position = new Vector3(gameObject.transform.position.x - .2f, gameObject.transform.position.y + 1);
            GameObject bulletCap2 = Instantiate(prefab) as GameObject;
            bulletCap2.transform.position = new Vector3(gameObject.transform.position.x + .2f, gameObject.transform.position.y + 1);
        }
        else
        {
            GameObject bulletCap = Instantiate(prefab) as GameObject;
            bulletCap.transform.position = new Vector3(gameObject.transform.position.x - .3f, gameObject.transform.position.y + 1);
            GameObject bulletCap2 = Instantiate(prefab) as GameObject;
            bulletCap2.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1);
            GameObject bulletCap3 = Instantiate(prefab) as GameObject;
            bulletCap3.transform.position = new Vector3(gameObject.transform.position.x + .3f, gameObject.transform.position.y + 1);

        }
    }

    public void Upgrade()
    {
        if( upgrade < 3)
        {
            upgrade++;
        } 
        else
        {
            upgrade = 3;
        }
        //upgrade < 3 ? upgrade++ : 3;
    }
}
