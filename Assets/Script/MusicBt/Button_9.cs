using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_9 : MonoBehaviour {

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
        if (Input.GetKeyDown(KeyCode.Keypad9) && Time.time > nextclick)
        {
            nextclick = Time.time + rateclick;
            if (situation == 0)
            {

                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/39-B  -小字组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (situation == 1)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/27-B -大字组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (situation == -1)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/52-C    -小字2组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (situation == 2)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/63-B   -小字2组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
        }

    }
}
