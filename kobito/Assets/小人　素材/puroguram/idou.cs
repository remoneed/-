using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour {
    float yokoidou = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.yokoidou += -0.2f;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.yokoidou += 0.2f;
        }
        transform.Translate(this.yokoidou, 0, 0);
        this.yokoidou *= 0.98f;
	}
}
