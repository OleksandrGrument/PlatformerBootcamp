using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// handles the coin behavior when the player interacts with it
/// </summary>
public class CoinCtrl : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);    // destroys the coin
        }
	}

}
