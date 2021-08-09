using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScrolling : MonoBehaviour
{
    public GameObject text;

    public float speed;
    public float waitTime;
    

    IEnumerator Scroll() // after a set time, reset the location of the text to the bottom of the screen
    {      

        yield return new WaitForSeconds(waitTime);
        text.transform.position = new Vector2(transform.position.x, -30);
        StartCoroutine(Scroll());
    }


    
    void Start() // start the Ienumerator so that it functions throughout the scene
    {
        StartCoroutine(Scroll());
    }

    
    void Update() // a continuously scrolling script moving a text upwards along the screen
    {
        text.transform.position = new Vector2(transform.position.x, transform.position.y + speed / 2);
        
    }
}
