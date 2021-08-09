using UnityEngine;

public class Colour_Based_Collision : MonoBehaviour
{

    public Collider2D cPlayer; // collide for player
    public Material [] mPlayer; // an array for materials/ colours
    Renderer rend; //render the colours on the player   

    public GameObject[] platformsBlue; // an array of game objects
    public GameObject[] platformsRed; // an array of game objects
    public GameObject[] platformsGreen; // an array of game objects

    public Color Blue;
    public Color Red;
    public Color Green;


    void Start ()
    {
        
        cPlayer = GetComponent<Collider2D>(); // attach the collider to the script

        

        rend = GetComponent<Renderer>(); //attack the render to the script
        rend.enabled = true; // enable the render
        rend.sharedMaterial = mPlayer[0]; //prepare to render the material onto the player from the selected array
	}


    private void OnTriggerEnter2D(Collider2D col) // Trigger method to determin which material to render depending on which converter the player lands on
    {
        if (col.gameObject.tag == "Converter")
        {
            print("Player has toughed a gem");

            if (col.name == "Blue_Trigger")
            {
                rend.sharedMaterial = mPlayer[1];

            }
            else if (col.name == "Red_Trigger")
            {
                rend.sharedMaterial = mPlayer[2];

            }
            else if (col.name == "Green_Trigger")
            {
                rend.sharedMaterial = mPlayer[3];
                               
            }
            floorOnOff();
        }
    }

    private void floorOnOff() // A method that determins which platforms are considered transparent. However, this did not achieve a desired effect as the transparency was not causing any visible change.
    {
        if (rend.sharedMaterial == mPlayer[0])
        {
             
            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            Blue = platformsBlue[0].GetComponent<Renderer>().material.color;
            Blue.a = 0f;

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            Red = platformsRed[0].GetComponent<Renderer>().material.color;
            Red.a = 0;

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            Green = platformsGreen[0].GetComponent<Renderer>().material.color;
            Green.a = 0f;



            for (int i = 0; i < platformsBlue.Length; i++)
            {
                platformsBlue[i].GetComponent<BoxCollider2D>().enabled = false;
                
                platformsBlue[i].GetComponent<Material>().color = Blue;
            }

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            for (int i = 0; i < platformsRed.Length; i++)
            {
                platformsRed[i].GetComponent<BoxCollider2D>().enabled = false;
            }

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            for (int i = 0; i < platformsGreen.Length; i++)
            {
                platformsGreen[i].GetComponent<BoxCollider2D>().enabled = false;
            }

        }

        if (rend.sharedMaterial == mPlayer[1])
        {

            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            Blue = platformsBlue[0].GetComponent<Renderer>().material.color;
            Blue.a = 1f;

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            Red = platformsRed[0].GetComponent<Renderer>().material.color;
            Red.a = 0f;

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            Green = platformsGreen[0].GetComponent<Renderer>().material.color;
            Green.a = 0f;


            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            for (int i = 0; i < platformsBlue.Length; i++)
            {
                platformsBlue[i].GetComponent<BoxCollider2D>().enabled = true;
            }

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            for (int i = 0; i < platformsRed.Length; i++)
            {
                platformsRed[i].GetComponent<BoxCollider2D>().enabled = false;
            }

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            for (int i = 0; i < platformsGreen.Length; i++)
            {
                platformsGreen[i].GetComponent<BoxCollider2D>().enabled = false;
            }

        }


        if (rend.sharedMaterial == mPlayer[2])
        {

            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            Blue = platformsBlue[0].GetComponent<Renderer>().material.color;
            Blue.a = 0.5f;

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            Red = platformsRed[0].GetComponent<Renderer>().material.color;
            Red.a = 1f;

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            Green = platformsGreen[0].GetComponent<Renderer>().material.color;
            Green.a = 0.5f;


            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            for (int i = 0; i < platformsBlue.Length; i++)
            {
                platformsBlue[i].GetComponent<BoxCollider2D>().enabled = false;
            }

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            for (int i = 0; i < platformsRed.Length; i++)
            {
                platformsRed[i].GetComponent<BoxCollider2D>().enabled = true;
            }

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            for (int i = 0; i < platformsGreen.Length; i++)
            {
                platformsGreen[i].GetComponent<BoxCollider2D>().enabled = false;
            }

        }


        if (rend.sharedMaterial == mPlayer[3])
        {

            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            Blue = platformsBlue[0].GetComponent<Renderer>().material.color;
            Blue.a = 0.5f;

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            Red = platformsRed[0].GetComponent<Renderer>().material.color;
            Red.a = 0.5f;

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            Green = platformsGreen[0].GetComponent<Renderer>().material.color;
            Green.a = 1f;


            platformsBlue = GameObject.FindGameObjectsWithTag("Blue");
            for (int i = 0; i < platformsBlue.Length; i++)
            {
                platformsBlue[i].GetComponent<BoxCollider2D>().enabled = false;
            }

            platformsRed = GameObject.FindGameObjectsWithTag("Red");
            for (int i = 0; i < platformsRed.Length; i++)
            {
                platformsRed[i].GetComponent<BoxCollider2D>().enabled = false;
            }

            platformsGreen = GameObject.FindGameObjectsWithTag("Green");
            for (int i = 0; i < platformsGreen.Length; i++)
            {
                platformsGreen[i].GetComponent<BoxCollider2D>().enabled = true;
            }

        }
    }
}
