using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField]
    GameObject dustCloud; // spawn the dust loud particle effect if the user collides with one of the following taggs below.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Platform"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
        }
        if (other.gameObject.tag.Equals("Converter"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
        }
        if (other.gameObject.tag.Equals("Blue"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
        }
        if (other.gameObject.tag.Equals("Red"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
        }
        if (other.gameObject.tag.Equals("Green"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
        }
    }
}
