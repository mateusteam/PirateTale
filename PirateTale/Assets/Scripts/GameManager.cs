using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int bullets = 4;
    private HudManager hudManager;
    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        hudManager = FindObjectOfType<HudManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootBullet()
    {
        if (bullets > 0)
        {
            bullets--;
        }
        hudManager.SetBulletCount(bullets);
    }

    public void RechargeBullet()
    {
        if (bullets < 4)
        {
            if (bullets + 2 > 4)
            {
                bullets = 4;
            } else
            {
                bullets += 2;
            }

            audioManager.PlaySFX(audioManager.recharge);
        }

        hudManager.SetBulletCount(bullets);
    }

    public int GetBullet()
    {
        return bullets;
    }
}
