using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bullet;
    public float force = 2;

    private AudioManager audioManager;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        if (gameManager.GetBullet() > 0)
        {
            GameObject currBullet = Instantiate(bullet, transform.position, bullet.transform.rotation);
            currBullet.GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.Impulse);
            audioManager.PlaySFX(audioManager.cannonBall);
            gameManager.ShootBullet();
        }
    }
}
