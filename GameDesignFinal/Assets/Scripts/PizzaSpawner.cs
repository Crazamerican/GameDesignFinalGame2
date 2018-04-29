using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSpawner : MonoBehaviour {
    public GameObject pizza;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RollTheDice()
    {
        if(Random.Range(0,10) > 7)
        {
            GameObject newPizza = Instantiate(pizza) as GameObject;
            newPizza.transform.position = gameObject.transform.position;
        }
    }

}
