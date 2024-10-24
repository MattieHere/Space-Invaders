using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public GameObject[] PowerUps;
    public float dropChance = 1f;

   public void OnAlienDeath()
    {
        if (Random.Range(0f, 1f) < dropChance)
        {
            int randomIndex = Random.Range(0, PowerUps.Length);
            GameObject selectedPowerUp = PowerUps[randomIndex];
            Instantiate(selectedPowerUp, transform.position, Quaternion.identity);

        }
        Debug.Log("Onaliendeath funkar");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
