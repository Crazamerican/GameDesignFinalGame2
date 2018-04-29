using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
    public void loadLevel(string level)
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
