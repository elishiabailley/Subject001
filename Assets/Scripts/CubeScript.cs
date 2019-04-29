using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public bool isClicked;

    // Use this for initialization
    void Start ()
    {
        isClicked = true;

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isClicked = false;

        }

        if (isClicked == true)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);

        }
    }
}
