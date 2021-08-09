using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image black;
    public Animator anim;
    

    public void start() // Load the main game
    { 
        SceneManager.LoadScene(1);
    }

    public void Credits() // sends the user to the credits screen
    {
        SceneManager.LoadScene(2);
    }

    public void quit()// allows the user to quit the game
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void menuReturn() //allows the user to go back to the menu screen
    {
        StartCoroutine(Fading());
    }

    IEnumerator Fading() //fades onto the menu screen
    {
        anim.SetBool("CreditsFade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(0);
    }
}
