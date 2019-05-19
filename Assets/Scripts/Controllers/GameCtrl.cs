using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the important features like keeping the score, restarting levels,
/// saving/loading data, updating the HUD etc
/// </summary>
public class GameCtrl : MonoBehaviour
{
    public static GameCtrl instance;
    public float restartDelay;

	void Awake()
	{
        if (instance == null)
            instance = this;
	}

	void Start()
	{
		
	}

	void Update()
	{
		
	}

    /// <summary>
    /// called when the player dies
    /// </summary>
    public void PlayerDied(GameObject player)
    {
        player.SetActive(false);

        Invoke("RestartLevel", restartDelay);
    }

    /// <summary>
    /// called when the player falls in water
    /// </summary>
    public void PlayerDrowned(GameObject player)
    {
        Invoke("RestartLevel", restartDelay);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
