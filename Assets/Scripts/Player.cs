using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    public Laser laserPrefab;
    Laser laser;
    float speed = 5f;

    public float ShootCD = 0.5f;
    public float lastShootTIme;

    GameObject shield;






    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += speed * Time.deltaTime;
        }

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= lastShootTIme + ShootCD)
        {
            laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            lastShootTIme = Time.time;
        }
    }
   public IEnumerator ActiveDS()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= lastShootTIme + ShootCD)
        {
            ShootCD = 0.2f;
            yield return new WaitForSeconds(1f);

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Missile") || collision.gameObject.layer == LayerMask.NameToLayer("Invader"))
        {
            GameManager.Instance.OnPlayerKilled(this);
        }
        
  

    }




}
