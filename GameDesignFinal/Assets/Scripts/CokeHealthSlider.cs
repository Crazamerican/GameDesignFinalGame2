using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CokeHealthSlider : MonoBehaviour {
    public Slider healthbar;
    Health health;
	// Use this for initialization
	void Start () {
        health = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateSlider()
    {
        healthbar.value = health.getHealth();
    }
}
