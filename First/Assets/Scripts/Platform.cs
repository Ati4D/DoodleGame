using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]private float jump = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("OnCollisionEnter2D(), name: " + collision.collider.name);
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D player = collision.collider.GetComponent<Rigidbody2D>();
            if (player != null)
            {
                Vector2 velocity = player.velocity;
                velocity.y = jump;
                player.velocity = velocity;
            }
        }
    }
}
