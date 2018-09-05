using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadMusicRun : MonoBehaviour {

    public float speed = 2f;
	void Start () {
		
	}
	

	void Update () {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
}
