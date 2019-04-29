using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCube : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public Inventory num;

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            num.cubeNum += 1; //adds one cube to inventory
        }
    }

        // Use this for initialization
        void Start ()
    {
        num = GameObject.Find("Grid").GetComponent<Inventory>();
	}
	
}
