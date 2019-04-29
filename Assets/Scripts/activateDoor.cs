using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDoor : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public Collider2D door;
    public Collider2D cube;
    public Collider2D pressure;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            door.enabled = true; //enables door collider when cube collides with pressure pad
        }    
    }
}
