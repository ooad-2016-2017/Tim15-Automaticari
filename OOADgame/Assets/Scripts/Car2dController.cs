using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car2dController : MonoBehaviour {

    float speedForce = 10f;
    float torqueForce = 200f;
    float driftFactorSticky = 0.2f;
    float driftFactorSlippy = 0.7f;
    float maxStickyVelocity = 2.5f;
    float minSlippyVelocity = 1.5f;

    // Use this for initialization
    void Start () {
		
	}
	
    void Update()
    {
       
    }

	// Update is called once per frame
	void FixedUpdate () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

      /*  float driftFactor = driftFactorSticky;
        if(RightVelocity().magnitude > maxStickyVelocity)
        {
            driftFactor = driftFactorSlippy;
        }*/
        

        rb.velocity = ForwardVelocity() + RightVelocity()*driftFactorSlippy;

        if (Input.GetButton("Accelerate"))
        {
            rb.AddForce(transform.up * speedForce);
        }

        if (Input.GetButton("Brakes"))
        {
            rb.AddForce(transform.up * -speedForce/2f);
        }

        float tf = Mathf.Lerp(0, torqueForce, rb.velocity.magnitude / 3);
        

        rb.angularVelocity = Input.GetAxis("Horizontal") * tf;


	}

    Vector2 ForwardVelocity()
    {
        return transform.up * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.up);
    }

    Vector2 RightVelocity()
    {
        return transform.right * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.right);
    }
    /*
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Inner Wall")
        {
            //Replace 'Game Over' with your game over scene's name.
            Destroy(col.gameObject);
        }
    }*/
    
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(gameObject.name + " has collided with " + col.gameObject.name);
        if(col.gameObject.tag == "Finish")
        {
            // Destroy(gameObject);
            SceneManager.LoadScene("nekanova");
        }
        
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
       /// Debug.Log(gameObject.name + " was triggered by " + other.gameObject.name);
        if (other.gameObject.tag == "Hrana")
        {
            ScoreScript.scoreValue += 10;
            Destroy(other.gameObject);
         
        }

        if(other.gameObject.name == "zastava")
        {
            TimeScript.timeValue += 45;
        }
    }
    
}
