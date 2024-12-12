using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D myRigidbody;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(0,0);

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 7.55)
        {
            myRigidbody.velocity = new Vector2(1, 0) * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -7.55)
        {
            myRigidbody.velocity = new Vector2(-1, 0) * speed;
        }
    }
}
