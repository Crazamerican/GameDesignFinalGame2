using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern1 : MonoBehaviour {
    float targetX, targetY, startX, startY;
    bool hitStartPoint;
    bool started;
    bool rotated;

    Transform target;

    Vector3 toStart;
    Vector3 toTarget;
	// Use this for initialization
	void Start () {
        hitStartPoint = false;
        toStart = Vector3.zero;
        started = false;
        target = GameObject.Find("PepsiCanPlayer").transform;
        rotated = false;
    }
	
	// Update is called once per frame
	void Update () {

		if(!hitStartPoint)
        {
            if (toStart.Equals(Vector3.zero) && (startY != 0 || startX != 0))
            {
                calculateToStartVector();
                started = true;
            }
            if (Mathf.Abs(startX - transform.position.x) < .1f && Mathf.Abs(startY - transform.position.y) < .1f && started)
            {
                hitStartPoint = true;
                //Debug.Log("We hit the start");
            }
            transform.position = transform.position + new Vector3(toStart.x, toStart.y) * .8f * Time.deltaTime;
        }
        else if (!rotated && hitStartPoint)
        {
            rotateToDirection();
        }
        else
        {
            
            //Debug.Log(to)
            if (toTarget.Equals(Vector3.zero))
            {
                calculateToTargetVector();
            }
            //rotateToDirection();
            transform.position = transform.position + toTarget * Time.deltaTime;
        }

        if(transform.position.x > 12 || transform.position.x < -12 || transform.position.y > 7 || transform.position.y < -7)
        {
            Destroy(gameObject);
        }
	}

    private void rotateToDirection()
    {
        if (toTarget.Equals(Vector3.zero))
        {
            calculateToTargetVector();
        }
        float angle = Mathf.Atan2(toTarget.y, toTarget.x) * Mathf.Rad2Deg;
        if(angle < 0)
        {
            angle = angle + 360;
        }
        Vector3 tar = new Vector3(0, 0, angle - 90);
        Debug.Log(Vector3.Distance(transform.eulerAngles, tar));
        if(Vector3.Distance(transform.eulerAngles, tar) > .5f)
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, tar, 1.5f * Time.deltaTime);
        }
        else
        {
            transform.eulerAngles = tar;
            rotated = true;
        }
        
    }

    private void calculateToTargetVector()
    {
        Debug.Log("toTargetVector should happen at least once");
        toTarget = new Vector3(target.position.x - transform.position.x, target.position.y - transform.position.y);
    }

    private void calculateToStartVector()
    {
        //Debug.Log("toStartVector should happen at least once");
        toStart = new Vector3(startX - transform.position.x, startY - transform.position.y);
    }

    public void movement(float targetX1, float targetY1, float startX1, float startY1)
    {
        Debug.Log("this should happen upon creation");
        this.targetX = targetX1;
        this.targetY = targetY1;
        this.startX = startX1;
        this.startY = startY1;
    }


    
}
