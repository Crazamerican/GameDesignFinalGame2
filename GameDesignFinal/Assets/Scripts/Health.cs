using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int maxHealth;
    public int currentHealth;
    AudioSource sound;
    GameObject manager;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        sound = GetComponent<AudioSource>();
        manager = GameObject.Find("VictoryConditions");
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void damaged()
    {
        currentHealth--;
        if(gameObject.GetComponent<PepsiHealthSlider>() != null)
        {
            gameObject.GetComponent<PepsiHealthSlider>().updateSlider();
        }
        if(currentHealth <= 0)
        {
            if(!sound.isPlaying)
            {
                sound.Play();
            }
            if(gameObject.name == "CokeBottle(Clone)")
            {
                GetComponent<PizzaSpawner>().RollTheDice();
            }
            else if (gameObject.name == "CokeRocket")
            {
                manager.GetComponent<Victory>().PepsiWin();
            } 
            else if (gameObject.name == "PepsiCanPlayer")
            {
                manager.GetComponent<Victory>().CokeWin();
            }
            Destroy(gameObject);
        }
    }

    public int getHealth()
    {
        return currentHealth;
    }

    public void setHealth(int num)
    {
        maxHealth = num;
        currentHealth = num;
    }
}
