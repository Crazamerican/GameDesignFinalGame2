using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int maxHealth;
    public int currentHealth;
    AudioSource sound;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void damaged()
    {
        currentHealth--;
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
