using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Seen_kawaru : MonoBehaviour {
    Animator kirikae;
	// Use this for initialization
	void Start () {
        this.kirikae = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("hagimaridouga");
        }
        this.kirikae.speed = 0.3f;
	}
}
