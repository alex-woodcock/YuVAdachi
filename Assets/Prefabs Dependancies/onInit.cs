using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onInit : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb2d;
    private Animator anim;
    public string character = "adachi";
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.Play("testImage");
    }
	
	// Update is called once per frame
	void Update () {
        /*
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
        if (moveHorizontal == 0 && moveVertical == 0)
        {
            anim.Play(character+"_idle0");
        }
        else
        {
            anim.Play("testImage");
        }
        */
        if (Input.GetKey("a"))
        {
            this.transform.position = new Vector2(this.transform.position.x - 0.15f, this.transform.position.y);
            anim.Play("testImage");
        }
        else
        {
            anim.Play(character + "_idle0");
        }
    }
}
