using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int Lives = 3;
    public Image[] livesUI;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy Projectile")
        {
            Destroy(collision.collider.gameObject);
            Lives -= 1;
            for(int i = 0; i < livesUI.Length; i++)
            {
                if(i < Lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if(Lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Projectile")
        {
            Destroy(collision.gameObject);
            Lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < Lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (Lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
