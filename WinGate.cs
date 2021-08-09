using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGate : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision) // if the play hits the wingate, send them to the credits screen
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }

}
