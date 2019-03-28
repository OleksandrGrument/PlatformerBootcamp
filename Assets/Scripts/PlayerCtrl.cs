using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [Tooltip("this is an positive integer, speed boost")]
    public int speedBoost;

    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerSpeed = Input.GetAxisRaw("Horizontal");
        if (playerSpeed != 0)
            MoveHorizontal(playerSpeed);
        else
            StopMoving();
    }

    void MoveHorizontal(float playerSpeed)
    {
        rigidbody.velocity = new Vector2();
    }

    void StopMoving()
    {
        rigidbody.velocity = new Vector2(2, rigidbody.velocity.y);
    }
}