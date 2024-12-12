using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BallBounce : MonoBehaviour
{
    public Rigidbody2D ballRigidbody;
    public float speed;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        PlayerScore.score = 0;
        Invoke("StartMoving", timer);
    }

    // Update is called once per frame
    void Update()
    {
        ballRigidbody.velocity = ballRigidbody.velocity.normalized * speed;

        if (transform.position.y <= -5.5)
        {
            //transform.position = new Vector2(0.01f, -0.2f);
            ballRigidbody.velocity = new Vector2(0,0);
            //RestartGame();
            GameOver();
        }
        
    }

    void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    
    void StartMoving()
    {
       
        ballRigidbody.velocity = new Vector2(0, -1);
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
