using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {
    private bool cooldown;
    Button myButton;
    public float timer;
	// Use this for initialization
	void Awake () {
        myButton = GetComponent<Button>();
        
        if (myButton != null)
        {
            myButton.onClick.AddListener(OnButtonClick);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnButtonClick()
    {
        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown()
    {
        myButton.interactable = false;
        yield return new WaitForSeconds(timer);
        myButton.interactable = true;
    }


}
