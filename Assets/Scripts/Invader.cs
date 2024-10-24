using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class Invader : MonoBehaviour


{
    public int ScoreValue = 100;
    public Sprite[] animationSprites = new Sprite[2];
    public float animationTime;
    public GameObject EnemyParticle;

    SpriteRenderer spRend;
    int animationFrame;

    private Alien alienScript;

    public void Die()
    {
        if (alienScript != null)
        {
            alienScript.OnAlienDeath();
            Destroy(gameObject);

        }
        Debug.Log("Invader died!");
    }





    private void Awake()
    {
        spRend = GetComponent<SpriteRenderer>();
        spRend.sprite = animationSprites[0];
    }

    void Start()
    {
        //Anropar AnimateSprite med ett visst tidsintervall
        InvokeRepeating(nameof(AnimateSprite), animationTime, animationTime);
        alienScript = GetComponent<Alien>();    
    }

    //pandlar mellan olika sprited för att skapa en animation
    private void AnimateSprite()
    {
        animationFrame++;
        if (animationFrame >= animationSprites.Length)
        {
            animationFrame = 0;
        }
        spRend.sprite = animationSprites[animationFrame];
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Die();
        if (collision.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            //Skapar ljud och partiklar på död/Achitphon
            Instantiate(EnemyParticle, transform.position, Quaternion.identity);
            SoundScript.PlaySound("EnemyDeath");
            GameObject.Find("Main Camera").GetComponent<ScreemShake>().shake = 3f;
            GameManager.Instance.OnInvaderKilled(this);
        }   
        else if(collision.gameObject.layer == LayerMask.NameToLayer("Boundary")) //nått nedre kanten
        {
            GameManager.Instance.OnBoundaryReached();
        }
    }

}
