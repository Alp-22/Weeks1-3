using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject square;
    public Bullet bullet;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if(bullet == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    public void Spawn()
    {
        GameObject bulletGO = Instantiate(prefab, transform.position, transform.rotation);
        bullet = bulletGO.GetComponent<Bullet>();
    }

    void Fire()
    {
        bullet.hasBeenFired = true;
        bullet = null;
    }
}
