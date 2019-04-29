using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiMove : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public Rigidbody2D aiSprite;
    public Vector2 direction;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            //changes to opposite direction when hitting a wall
            direction = direction * -1;
        }

        //ignore collision between ai layer and portal tile layer
        Physics2D.IgnoreLayerCollision(10, 12);
        Physics2D.IgnoreLayerCollision(11, 12);
    }
    
    // Use this for initialization
    void Start ()
    {
        direction = new Vector2(0.5f, 0);

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(direction * Time.deltaTime);

    }
}
