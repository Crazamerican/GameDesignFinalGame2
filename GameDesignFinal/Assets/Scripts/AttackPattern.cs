using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern : MonoBehaviour {
    //Out missile Coke Bottle of DEATH
    public GameObject cokeBottle;

    public Transform player;

    //Where we want to send the bottles to
    float targetX;
    float targetY;

    //The Height where the bottles will start
    float startY;

    //List<GameObject> enemies;
	// Use this for initialization
	void Start () {
        //enemies = new List<GameObject>();
        startY = 3;

        targetX = player.position.x + 2;
        targetY = player.position.y + 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void bottleAttackPatternOne(int num)
    {
        for(int i = 0; i < num; i++)
        {
            GameObject newBottle = Instantiate(cokeBottle) as GameObject;
            newBottle.transform.position = new Vector3(0, 6);
            AttackPattern1 atk = newBottle.GetComponent<AttackPattern1>();
            atk.enabled = true;
            atk.movement(targetX, targetY, -8 + 16*i/num, 3);
        }
    }

    public void bottleAttackPatternTwo(int num)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject newBottle = Instantiate(cokeBottle) as GameObject;
            newBottle.transform.position = new Vector3(0, 6);
            AttackPattern2 atk = newBottle.GetComponent<AttackPattern2>();
            atk.enabled = true;
            atk.movement(targetX, targetY, -8 + 16 * i / num, 4);
        }
    }

    public void bottleAttackPatternThree()
    {
        for(int i = 0; i < 6; i++)
        {
            GameObject newBottle = Instantiate(cokeBottle) as GameObject;
            newBottle.transform.position = new Vector3(0, 6);
            AttackPatternThree atk = newBottle.GetComponent<AttackPatternThree>();
            atk.enabled = true;
            atk.movement(targetX, targetY, -8 + i * 3, 4.5f);
        }
    }
}
