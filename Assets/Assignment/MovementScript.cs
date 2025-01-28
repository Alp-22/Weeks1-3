using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = transform.position;
        //If the player presses A go left and prevent the player from going past a certain point
        if (Input.GetKey(KeyCode.A) && playerPos.x > -15)
        {
            playerPos.x -= speed;
        }
        //If the player presses D go right and prevent the player from going past a certain point
        if (Input.GetKey(KeyCode.D) && playerPos.x < 15)
        {
            playerPos.x += speed;
        }
        transform.position = playerPos;
    }
}
