using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLA : MonoBehaviour {
    Rigidbody2D jyuuryoku;
    float idou = 0f;
    float idou2 = 0f;
    GameObject kyara;
    float a;
    float b;
    float c;
    Vector3 muki;
    Animator anime;
    // Use this for initialization
    void Start () {
        this.jyuuryoku = GetComponent<Rigidbody2D>();
        this.kyara = GameObject.Find("kyara1");
        this.anime = GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.idou =3;
            this.jyuuryoku.AddForce(transform.right * this.idou);
            transform.localScale = new Vector3(1, 1, 1);
            this.muki = new Vector3();
        }
        
      if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.idou = 0;
            this.jyuuryoku.AddForce(transform.right * this.idou);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.idou = -3;
            this.jyuuryoku.AddForce(transform.right * this.idou);
            transform.localScale = new Vector3(-1, 1, 1);

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.idou = 0;
            this.anime.SetTrigger("ueTigger");
            this.jyuuryoku.AddForce(transform.right * this.idou);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.idou = 1;
            this.jyuuryoku.AddForce(transform.up * this.idou);
           

        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            this.idou = 0;
            this.jyuuryoku.AddForce(transform.up * this.idou);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.idou = -1;
            this.jyuuryoku.AddForce(transform.up * this.idou);
         

        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.idou = 0;
            this.jyuuryoku.AddForce(transform.up * this.idou);
        }
        
        {
            if (transform.position.y < 0)
            {
                this.idou2 = 4;
            }
            if (transform.position.y > 0)
            {
                this.idou2 = 4;
            }
            a = transform.position.y* idou2 * 0.0025f;
            transform.position = new Vector3
                (transform.position.x, transform.position.y - a, transform.position.z);
        }
        this.anime.speed = this.idou;
       
    }
}
