using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    float a = 0;
    float b = 0;
    float c = 0;
    float kei;
    float k = 0;
    GameObject v;
    Rigidbody2D tikara;
	// Use this for initialization
	void Start () {
        this.tikara = GetComponent<Rigidbody2D>();
        this.v = GameObject.Find("syuayaku_1");
	}
	
	// Update is called once per frame
	void Update () {
        this.kei = Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
        {
             this.k = 2;
            this.tikara.AddForce(transform.right * this.k);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.k = 0;
            this.tikara.AddForce(transform.right  *this.k);
        }
        /*
        if (this.b == 0)
        {
            this.a += 0.01f;
            transform.position = new Vector3(transform.position.x, this.a, 0);
        }
        if(transform.position.y> 0.3f)
        {
            this.b = 1;
        }
        if(this.b ==1)
        {
            this.a = 0;
            this.a -= 0.01f;
            transform.Translate(transform.position.x,this.a, 0);
        }
        if(transform.position.y<0)
        {
            this.b = 0;
        }*/
        
    if(this.kei < 1 )
        {
            this.a = 0.1f;
            this.tikara.AddForce(transform.up * this.a);
        }
    if(this.kei > 1)
        {
            this.b = 1;
        }
    if(this.b ==1)
        {
            this.a = -0.1f;
            this.tikara.AddForce(transform.up * this.a);
        }
      
       

    }
}
