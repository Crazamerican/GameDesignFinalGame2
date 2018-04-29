using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPattern : MonoBehaviour {
    //Out missile Coke Bottle of DEATH
    public GameObject cokeBottle;
    public GameObject cokeCap;
    public Transform player;

    public Button pattern1But;
    public Button pattern2But;
    public Button pattern3But;
    public Button touhouBut;

    //Where we want to send the bottles to
    float targetX;
    float targetY;

    //The Height where the bottles will start
    float startY;

    //cool down timers for each of the attacks
    public float pattern1Cooldown;
    float pattern1Timer;
    public float pattern2Cooldown;
    float pattern2Timer;
    public float pattern3Cooldown;
    float pattern3Timer;
    public float touhouCooldown;
    float touhouTimer;
	// Use this for initialization
	void Start () {
        //enemies = new List<GameObject>();
        startY = 3;

        pattern1Cooldown = 0;
        pattern2Cooldown = 0;
        pattern3Cooldown = 0;
        touhouCooldown = 0;

        targetX = player.position.x + 2;
        targetY = player.position.y + 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void bottleAttackPatternOne(int num)
    {
            for (int i = 0; i < num; i++)
            {
                GameObject newBottle = Instantiate(cokeBottle) as GameObject;
                newBottle.transform.position = new Vector3(0, 6);
                AttackPattern1 atk = newBottle.GetComponent<AttackPattern1>();
                atk.enabled = true;
                atk.movement(targetX, targetY, -8 + 16 * i / num, 3);
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
            for (int i = 0; i < 6; i++)
            {
                GameObject newBottle = Instantiate(cokeBottle) as GameObject;
                newBottle.transform.position = new Vector3(0, 6);
                AttackPatternThree atk = newBottle.GetComponent<AttackPatternThree>();
                atk.enabled = true;
                atk.movement(targetX, targetY, -8 + i * 3, 4.5f);
            }
    }

    public void touhouAttackPattern()
    {
            for (int i = 0; i < 10; i++)
            { //Along the top
                GameObject newCap = Instantiate(cokeCap) as GameObject;
                newCap.gameObject.transform.position = new Vector3(-8 + i * 1.5f, 5);
                newCap.GetComponent<touhou>().enabled = true;
                newCap.GetComponent<touhou>().setVert(true);
            }
            for (int i = 0; i < 10; i++)
            { //from the left
                GameObject newCap = Instantiate(cokeCap) as GameObject;
                newCap.gameObject.transform.position = new Vector3(-9, 5 - i * 1.5f);
                newCap.GetComponent<touhou>().enabled = true;
                newCap.GetComponent<touhou>().setStart(true);
            }
            for (int i = 0; i < 10; i++)
            { //from the left
                GameObject newCap = Instantiate(cokeCap) as GameObject;
                newCap.gameObject.transform.position = new Vector3(9, 5 - i * 1.5f);
                newCap.GetComponent<touhou>().enabled = true;
                newCap.GetComponent<touhou>().setStart(false);
            }
    }
}
