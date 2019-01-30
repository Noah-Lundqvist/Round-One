using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMoveP1 : MonoBehaviour
{
    [SerializeField]
    private int playerIndex;

    private float speed;
    private new Rigidbody2D rigidbody;
    private float jumpVelocity;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        speed = 20f;
        jumpVelocity = 20f;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 velocity = rigidbody.velocity;
        velocity.x = Input.GetAxis("Horizontal" + playerIndex) * speed;
        if (Input.GetButtonDown("Jump" + playerIndex))
        {
            velocity.y = jumpVelocity;
        }
        
        rigidbody.velocity = velocity;
    }
}
