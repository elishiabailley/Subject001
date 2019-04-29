using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    public GameObject portalBlue;
    public GameObject portalOrange;
    public GameObject bluePortalCreated;
    public GameObject orangePortalCreated;
    public GameObject cube;
    public GameObject cubeCreated;

    public float cubeNum; //amount of cubes player has collected

    public void CreateCube(GameObject button)
    {
        if (button.name == "Slot 1")
        {
            if (cubeCreated)
            {
                Destroy(cubeCreated); //destroys cube if there is already one in the scene
            }

            if (cubeNum == 1) //player can only place a cube if they have one in their inventory
            {
                cubeCreated = Instantiate(cube, button.transform.position, Quaternion.identity);
            }
            
        }
    }

    public void CreatePortal(GameObject button)
    {
        if (button.name == "Slot 4")
        {
            if (orangePortalCreated)
            {
                Destroy(orangePortalCreated);
            }

            orangePortalCreated = Instantiate(portalOrange, button.transform.position, Quaternion.identity);

        }
        if (button.name == "Slot 5")
        {
            if (bluePortalCreated)
            {
                Destroy(bluePortalCreated);
            }

            bluePortalCreated = Instantiate(portalBlue, button.transform.position, Quaternion.identity);
        }
    }
}
