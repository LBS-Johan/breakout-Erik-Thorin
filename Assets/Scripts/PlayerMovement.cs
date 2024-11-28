using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D MyRigidbody;

    public int Speed;

    // Start is called before the first frame update
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MyRigidbody.velocity = new Vector2(0,0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyRigidbody.velocity = new Vector2(1, 0) * Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MyRigidbody.velocity = new Vector2(-1, 0) * Speed;
        }
    }
}
