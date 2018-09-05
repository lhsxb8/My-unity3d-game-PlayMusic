using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SituationChange : MonoBehaviour {

    public int situation = 0;
	void Start () {
		
	}
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
            situation = 1;
        if (Input.GetKeyDown(KeyCode.W))
            situation = 0;
        if (Input.GetKeyDown(KeyCode.E))
            situation = -1;
        if (Input.GetKeyDown(KeyCode.R))
            situation = 2;
            
	}
}
