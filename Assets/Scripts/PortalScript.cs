using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public bool isClicked; //is a portal placed
    public LayerMask usableArea;
    public int portalType;
    public PortalScript bluePortal;
    public PortalScript orangePortal;
    public PortalScript bluePortalCreated;
    public PortalScript orangePortalCreated;

    // Use this for initialization
    void Start ()
    {
        isClicked = true;
     
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("Orange").GetComponent<PortalScript>().isClicked == false && portalType == 1 && isClicked == false)
            {
                Vector2 portalPosition = GameObject.FindGameObjectWithTag("Orange").transform.position;
                collision.transform.position = portalPosition + (collision.GetComponent<aiMove>().direction * 2);
            }

            if (GameObject.FindGameObjectWithTag("Blue").GetComponent<PortalScript>().isClicked == false && portalType == 2 && isClicked == false)
            {
                Vector2 portalPosition = GameObject.FindGameObjectWithTag("Blue").transform.position;
                collision.transform.position = portalPosition + (collision.GetComponent<aiMove>().direction * 2);
            }
        }
    }
	// Update is called once per frame
	void Update ()
    {
        bool touchesArea = Physics2D.OverlapPoint(transform.position, usableArea);

        if (Input.GetMouseButtonDown(0) && touchesArea)
        {
            isClicked = false;
            
        }

		if (isClicked == true)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);

        }


	}
}
