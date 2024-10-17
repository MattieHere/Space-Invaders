using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PoweUps;

public class PoweUps : MonoBehaviour
{
    public enum PowerUpType
    {
        DS,
        HM,
        MG,

    }
    public PowerUpType powerUpType;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ApplyPowerUp(collision.gameObject);
            Destroy(gameObject);

        }

    }
    private void ApplyPowerUp(GameObject gameObject)
    {
        
        Player playerScript = gameObject.GetComponent<Player>(); 
        if (playerScript != null)
        {
            switch (powerUpType)
            {
                case PowerUpType.DS:
                    playerScript.ActiveDS(); 
                    break;

               
            }
        }
    }



    // Start is called before the first frame update
    void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    

