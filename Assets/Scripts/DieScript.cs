using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieScript : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
        void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
