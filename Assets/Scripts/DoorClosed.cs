using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosed : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public GameObject other;

    // Use this for initialization
    void Start ()
    {
        other.GetComponent<Collider2D>().enabled = false; //disables collider on start
    }
}
