using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// handles the player's bullet movement and collision with the enemy
/// </summary>
public class PlayerBulletCtrl : MonoBehaviour
{
    //1. declare a variable rb of type Rigidbody2D and public Vector2 velocity
    //2. get the ref to the Rigidbody2D in the Start method
    //3. assign the velocity in the Update method
    //4. test

    public Vector2 velocity;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = velocity;
    }
}
