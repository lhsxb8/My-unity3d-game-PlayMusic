using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_2 : MonoBehaviour {

    public int situation = 0;
    public AudioSource Sound;

    private float nextclick = 0.02f;
    private float rateclick = 0.02f;
    void Start()
    {

    }

    void Update()
    {
        situation = GameObject.Find("button").GetComponent<SituationChange>().situation;
        if (Input.GetKeyDown(KeyCode.Keypad2) && Time.time > nextclick)
        {
            nextclick = Time.time + rateclick;
            if (situation == 0)
            {
                
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/27-B -大字组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (situation == 1)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/15-B  -大字1组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (situation == -1)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/39-B  -小字组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (situation == 2)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/51-B    -小字1组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
        }

    }
}
