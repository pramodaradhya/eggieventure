using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour
{
    // public Transform player;
    // public Vector3 offset;
    private float _degree = 15;
    private float _speedx = 6f;
    private float _speedy = 6f;
    public GameOverController gameOverController;
    private Rigidbody2D rb;
    public PlayerHealth playerHealth;
    public Boss_Attack boss_Attack;
    public PlaySound playSound;



    // Start is called before the first frame update
    private void Start()
    {
        playSound = GetComponent<PlaySound>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void KillPlayer()
    {
        
        
        
        //Debug.Log("player killed by enemy");
        playerHealth.health = playerHealth.health - boss_Attack.attackDamage;
        playerHealth.Updatehealth();
        playSound.Play(0);

        if (playerHealth.health <= 0 )
        {
            gameOverController.PlayerDied();
        }

       // this.enabled = false;


    }
  

    internal static  void PlayerDeathAnimation()
    {
        // gameOverController.PlayerDied();
        //playSound.Play(1);
        
        
        Debug.Log("player killed by enemy");
        //GameOverController.RestartLevel();
      //  SceneManager.LoadScene(0);
        
    }

   


    // Update is called once per frame
    private void Update()
    {
        
            if(playerHealth.health > 0)
        {
            float dirx = Input.GetAxis("Horizontal");

            if (dirx >= 1)
            {

                float degree = -_degree;
                gameObject.transform.Rotate(0, 0, degree, Space.Self);
            }
            else if (dirx <= -1)
            {

                float degree = _degree;
                gameObject.transform.Rotate(0, 0, degree, Space.Self);
            }
            rb.velocity = new Vector2(dirx * _speedx, rb.velocity.y);


            if (Input.GetButtonDown("Jump"))
            {
                
                rb.velocity = new Vector2(rb.velocity.x, _speedy);
            }
        }

        //  transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position

    }
    

}

