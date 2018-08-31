using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    GameObject player;
    GameObject camera;
	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("yousei3");
        this.camera = GameObject.Find("Camera");
		
	}
	
	// Update is called once per frame
	void Update() { 
        Vector3 playere = this.player.transform.position;
        Vector3 camara = this.camera.transform.position;

        if (this.player.transform.position.x > 9.7f)
        {
            transform.position = new Vector3(transform.position.x, this.player.transform.position.y+2, transform.position.z);
        }
        else if(this.player.transform.position.x < -12.2f)
        {
            transform.position = new Vector3(transform.position.x, this.player.transform.position.y+2, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(this.player.transform.position.x, this.player.transform.position.y+2, transform.position.z);
        }
	}
}
