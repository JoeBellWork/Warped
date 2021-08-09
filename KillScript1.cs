using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillScript1 : MonoBehaviour
{
    public float speed;

    public Image black;
    public Text text;
    public Animator anim;
    public Animator textAnim;

    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // a triiger based method that reduces the time scale of the game to make the death look more dramatic
        {            
            Time.timeScale = 0.5f;
            StartCoroutine(Fading());
        }
    }    

    IEnumerator Fading() // run the fade animation for the death screen and then reload the scene
    {
        anim.SetBool("Fade", true);
        textAnim.SetBool("TextFade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(1);
    }
    

    void Update() // continously move the killbox up the screen
    {

        transform.position = new Vector2(transform.position.x, transform.position.y + (speed / 100));
    }
}
