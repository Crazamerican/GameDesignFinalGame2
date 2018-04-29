using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSetUp : MonoBehaviour {
    Button mybutton;
    GameObject manager;
	// Use this for initialization
	void Start () {
        mybutton = GetComponent<Button>();
        if(manager == null)
        {
            manager = GameObject.Find("SoundManager");
        }
        if(gameObject.name == "Play")
        {
            mybutton.onClick.AddListener(Play);
        }
        else if (gameObject.name == "Return")
        {
            mybutton.onClick.AddListener(Return);
        }
        else if (gameObject.name == "AttackPatternTouhou" )
        {
            mybutton.onClick.AddListener(Touhou);
        }
        else
        {
            mybutton.onClick.AddListener(Quit);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Play()
    {
        manager.GetComponent<Loader>().loadLevel("GameScene");
    }

    void Quit()
    {
        manager.GetComponent<Loader>().exitGame();
    }

    void Return()
    {
        manager.GetComponent<Loader>().loadLevel("Start");
    }

    void Touhou()
    {
        manager.GetComponent<MusicManager>().UNOwenWasHer();
    }
}
