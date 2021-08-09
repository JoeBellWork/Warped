using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCloudScript : MonoBehaviour
{

	
	void Start ()
    {
        Destroy(gameObject, 1f); // Deletes the particle affect after the character has jumped
	}	
}
