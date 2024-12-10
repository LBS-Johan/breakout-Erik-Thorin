using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Block : MonoBehaviour
{

    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        PlayerScore.score += 1;
    }
}
