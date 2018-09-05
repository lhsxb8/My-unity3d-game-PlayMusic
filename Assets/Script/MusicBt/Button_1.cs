using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_1 : MonoBehaviour {

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
        if ( Input.GetKeyDown(KeyCode.Keypad1)&&Time.time>nextclick)
        {
            nextclick = Time.time + rateclick;
            if (situation == 0)
            {
                //Debug.Log("a");
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/25-A -大字组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if(situation == 1)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/13-A   -大字1组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if(situation == -1)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/37-A  -小字组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
            if(situation == 2)
            {
                gameObject.GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("钢琴音色WAV/49-A  -小字1组", typeof(AudioClip));
                gameObject.GetComponent<AudioSource>().Play();
            }
        }

    }
}
