using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    Component[] sounds;
    List<AudioSource> sources;

    float timer;
	// Use this for initialization
	void Start () {
        sounds = GetComponents(typeof(AudioSource));
        sources = new List<AudioSource>();
        foreach(AudioSource sound in sounds)
        {
            sources.Add(sound);
        }
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer < Time.time && !sources[0].isPlaying)
        {
            sources[1].Pause();
            sources[0].Play();
        }
    }

    public void UNOwenWasHer()
    {
        if(sources[0].isPlaying)
        {
            sources[0].Pause();
            sources[1].Play();
            timer = Time.time + 5.0f;
        }
    }
}
