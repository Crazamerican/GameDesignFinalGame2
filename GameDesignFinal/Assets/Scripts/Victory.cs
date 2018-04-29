using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour {
    public GameObject can;
    public Image image;
    Canvas victoryScreen;

    public Sprite Pepsi;
    public Sprite Coke;
	// Use this for initialization
	void Start () {
		
	}
	
	public void PepsiWin()
    {
        if (can == null)
        {
            can = GameObject.Find("WinScreen");
        }
        can.SetActive(true);
        image.sprite = Pepsi;
    }

    public void CokeWin()
    {
        if (can == null)
        {
            can = GameObject.Find("WinScreen");
        }
        can.SetActive(true);
        image.sprite = Coke;
    }
}
