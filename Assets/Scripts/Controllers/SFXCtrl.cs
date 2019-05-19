using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// handles the particles effects and other special effects for the game
/// </summary>
public class SFXCtrl : MonoBehaviour
{
    public static SFXCtrl instance;     // allows other scripts to access public methods in this class without making objects of this class
    public SFX sfx;

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
    /// shows the coin sparkle effect when the player collects the coin
    /// </summary>
    public void ShowCoinSparkle(Vector3 pos)
    {
        Instantiate(sfx.sfx_coin_pickup, pos, Quaternion.identity);
    }

    /// <summary>
    /// shows the bullet sparkle effect when the player collects the bullet powerup
    /// </summary>
    public void ShowBulletSparkle(Vector3 pos)
    {
        Instantiate(sfx.sfx_bullet_pickup, pos, Quaternion.identity);
    }

    /// <summary>
    /// shows the player landing dust particle effect
    /// </summary>
    public void ShowPlayerLanding(Vector3 pos)
    {
        Instantiate(sfx.sfx_playerLandsp, pos, Quaternion.identity);
    }

    /// <summary>
    /// shows the splash effect when player falls in water
    /// </summary>
    public void ShowSplash(Vector3 pos)
    {
        Instantiate(sfx.sfx_splash, pos, Quaternion.identity);
    }

    /// <summary>
    /// shows the box breaking effect
    /// </summary>
    public void HandleBoxBreaking(Vector3 pos)
    {
        // position of the first fragment
        Vector3 pos1 = pos;
        pos1.x -= 0.3f;

        // position of the second fragment
        Vector3 pos2 = pos;
        pos2.x += 0.3f;

        // position of the third fragment
        Vector3 pos3 = pos;
        pos3.x -= 0.3f;
        pos3.y -= 0.3f;

        // position of the fourth fragment
        Vector3 pos4 = pos;
        pos4.x += 0.3f;
        pos4.y += 0.3f;

        // show the four broken framgments
        // these fragments or broken pieces have jump scripts attached
        // so after instantiation, they will jump apart
        Instantiate(sfx.sfx_fragment_1, pos1, Quaternion.identity);
        Instantiate(sfx.sfx_fragment_2, pos2, Quaternion.identity);
        Instantiate(sfx.sfx_fragment_2, pos3, Quaternion.identity);
        Instantiate(sfx.sfx_fragment_1, pos4, Quaternion.identity);
    }
}
