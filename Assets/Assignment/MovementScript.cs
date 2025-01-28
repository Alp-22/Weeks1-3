using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float speed = 0.01f;
    bool left = true, right = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = transform.position;
        Vector3 playerScale = transform.localScale;
        //If the player presses A go left and prevent the player from going past a certain point
        if (Input.GetKey(KeyCode.A) && playerPos.x > -15)
        {
            playerPos.x -= speed;
            right = true;
            if (left == true)
            {
                left = false;
                playerScale.x = -playerScale.x;
            }
        }
        //If the player presses D go right and prevent the player from going past a certain point
        if (Input.GetKey(KeyCode.D) && playerPos.x < 15)
        {
            playerPos.x += speed;
            left = true;
            if (right == true)
            {
                right = false;
                playerScale.x = -playerScale.x;
            }
        }
        transform.position = playerPos;
        transform.localScale = playerScale;
    }
}
