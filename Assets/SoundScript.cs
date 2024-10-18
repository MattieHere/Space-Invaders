using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{

    public static AudioClip EnemyDeathSound, FireSound;
    static AudioSource AudioS;



    void Start()
    {
        FireSound = Resources.Load<AudioClip>("fire");
        EnemyDeathSound = Resources.Load<AudioClip>("EnemyDeath");

        AudioS = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                AudioS.PlayOneShot(FireSound);
                break;
            case "EnemyDeath":
                AudioS.PlayOneShot(EnemyDeathSound);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
