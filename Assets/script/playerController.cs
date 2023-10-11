using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public GameObject player;
    public GameObject pickup1;
    public GameObject pickup2;
    public GameObject pickup3;
    public GameObject pickup4;
    public GameObject pickup5;
    public GameObject restartButton;
    public GameObject goText;
    public GameObject win;
    public Text score;
    private Rigidbody2D rb2d;
    private bool isDead;
    private float upForce;
    public float speed = 0.5f;
    Vector2 position;
    public int scoreint = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        position = transform.position;
        upForce = 300f;
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Horizontal");
        
        Vector2 dir=new Vector2(x,0);
        rb2d.AddForce(dir*5);
        if(Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, 1) * upForce);
        }

    }
    void OnCollisionEnter2D(Collision2D othercollider2d)
    {
        
        if (othercollider2d.gameObject.name == "dead")
        {
            restartButton.SetActive(true);
            goText.SetActive(true);
            player.SetActive(false);
            //restartButton.SetActive(true);
        }

        if (othercollider2d.gameObject.name == "Pickup")
        {
            scoreint++;
            score.text = "Score: " + scoreint.ToString();
            pickup1.SetActive(false);
        }
        if (othercollider2d.gameObject.name == "Pickup2")
        {
            scoreint++;
            score.text = "Score: " + scoreint.ToString();
            pickup2.SetActive(false);
        }
        if (othercollider2d.gameObject.name == "Pickup3")
        {
            scoreint++;
            score.text = "Score: " + scoreint.ToString();
            pickup3.SetActive(false);
        }
        if (othercollider2d.gameObject.name == "Pickup4")
        {
            scoreint++;
            score.text = "Score: " + scoreint.ToString();
            pickup4.SetActive(false);
        }
        if (othercollider2d.gameObject.name == "Pickup5")
        {
            scoreint++;
            score.text = "Score: " + scoreint.ToString();
            pickup5.SetActive(false);
        }

        if (scoreint==5)
        {
            win.SetActive(true);
            player.SetActive(false);
            restartButton.SetActive(true);
        }
        
        

    }
    public void Restart()
    {
        
        SceneManager.LoadScene(0);
    }
    
}
