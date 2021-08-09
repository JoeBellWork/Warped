using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeScript : MonoBehaviour
{

	
	
	
	void Update ()
    {
		if(Input.GetKeyDown("escape")) // if the user has pressed the ESC key, return them to the main menu
        {
            SceneManager.LoadScene(0);
        }
	}
}
