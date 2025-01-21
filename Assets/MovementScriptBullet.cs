using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptBullet : MonoBehaviour
{
    float speed = 0.02f;
    //public Vector2 objectPos = transform.position;
    public Vector3 worldPosition;
    // Start is called before the first frame update
    public Bullet bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 objectPos = transform.position;
        print((Camera.main.orthographicSize * Screen.width / Screen.height)/2);
        if (bullet.hasBeenFired == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                if (objectPos.y <= (Camera.main.orthographicSize * Screen.width / Screen.height) / 2)
                {
                    objectPos.y += speed;
                }

            }
            if (Input.GetKey(KeyCode.S))
            {
                if (objectPos.y >= -(Camera.main.orthographicSize * Screen.width / Screen.height) / 2)
                {
                    objectPos.y -= speed;
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (objectPos.x >= -(Camera.main.orthographicSize * Screen.width / Screen.height))
                {
                    objectPos.x -= speed;
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (objectPos.x <= (Camera.main.orthographicSize * Screen.width / Screen.height))
                {
                    objectPos.x += speed;
                }
            }
            transform.position = objectPos;
        }   
    }
}
