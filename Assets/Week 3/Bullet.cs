using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    public float negative = 1;
    public bool hasBeenFired = false;
    public bool topTouched = false, bottomTouched = false, leftTouched = false, rightTouched = false;
    public int bounces = 0;

    void Update()
    {
        if(hasBeenFired == true)
        {
            Movement();
        }
        else
        {
            PointAtMouse();
        }
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void Movement()
    {
        Vector2 objectPos = transform.position;
        transform.position += transform.up * speed * Time.deltaTime;
        if (objectPos.y <= (Camera.main.orthographicSize * Screen.width / Screen.height) / 2 && !topTouched)
        {
            negative = 1;
        }
        else if (!topTouched)
        {
            topTouched = true;
            negative = -1;
            transform.up = transform.up * negative;
            bottomTouched = false;
            rightTouched = false;
            leftTouched = false;
            bounces++;
        }

        

        if (objectPos.y >= -(Camera.main.orthographicSize * Screen.width / Screen.height) / 2 && !bottomTouched)
        {
            negative = 1;
        }
        else if(!bottomTouched)
        {
            bottomTouched = true;
            negative = -1;
            transform.up = transform.up * negative;
            topTouched = false;
            leftTouched = false;
            rightTouched = false;
            bounces++;
        }    

        if (objectPos.x >= -(Camera.main.orthographicSize * Screen.width / Screen.height) && !rightTouched)
        {
            negative = 1;
        }
        else if (!rightTouched)
        {
            rightTouched = true;
            negative = -1;
            transform.up = transform.up * negative;
            topTouched = false;
            topTouched = false;
            leftTouched = false;
            bottomTouched = false;
            bounces++;
        }

        if (objectPos.x <= (Camera.main.orthographicSize * Screen.width / Screen.height) && !leftTouched)
        {
            negative = 1;
        }
        else if (!leftTouched)
        {
            leftTouched = true;
            negative = -1;
            transform.up = transform.up * negative;
            topTouched = false;
            bottomTouched = false;
            rightTouched = false;
            bounces++;
        }
        //transform.Translate((Vector2)transform.position + Vector2.up * speed * Time.deltaTime);
        if (bounces >= 2)
        {
            Destroy(gameObject);
        }
    }
}
