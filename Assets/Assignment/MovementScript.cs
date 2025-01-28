using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float speed = 0.01f;
    float accelerationLeft, accelerationRight;
    float timeLeft, timeRight;
    bool left = true, right = false;
    [SerializeField]
    private AnimationCurve movementCurve;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the acceleration of each direction with a different time value to evaluvate based on the curve
        accelerationLeft = movementCurve.Evaluate(timeLeft);
        accelerationRight = movementCurve.Evaluate(timeRight);
        Vector2 playerPos = transform.position;
        Vector3 playerScale = transform.localScale;
        //If the player presses A go left and prevent the player from going past a certain point
        if (Input.GetKey(KeyCode.A) && playerPos.x >= -15)
        {
            timeLeft += Time.deltaTime;
            playerPos.x -= speed*accelerationLeft;
            right = true;
            if (left == true)
            {
                left = false;
                playerScale.x = -playerScale.x;
            }
        }
        else
        {
            timeLeft = 0.1f;
        }
        //If the player presses D go right and prevent the player from going past a certain point
        if (Input.GetKey(KeyCode.D) && playerPos.x <= 15)
        {
            timeRight += Time.deltaTime;
            playerPos.x += speed*accelerationRight;
            left = true;
            if (right == true)
            {
                right = false;
                playerScale.x = -playerScale.x;
            }
        }
        else
        {
            timeRight = 0.1f;
        }
        //print(acceleration);
        transform.position = playerPos;
        transform.localScale = playerScale;
    }
}
