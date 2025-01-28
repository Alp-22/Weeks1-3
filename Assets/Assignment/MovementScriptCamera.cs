using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptCamera : MonoBehaviour
{
    float speed = 0.01f;
    public Vector3 cameraPosTemp = new Vector3(0,0,0);
    float accelerationLeft, accelerationRight;
    float timeLeft, timeRight;
    //public GameObject player;
    // Start is called before the first frame update
    [SerializeField]
    private AnimationCurve cameraCurve;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Repeat the same code as the player movement script for acceleration
        accelerationLeft = cameraCurve.Evaluate(timeLeft);
        accelerationRight = cameraCurve.Evaluate(timeRight);
        Vector3 cameraPos = transform.position;
        //Set the cameraposition z value so it doesn't break
        cameraPos.z = -10;
        if (Input.GetKey(KeyCode.A))
        {
            //cameraPosTemp alters its value even if the camera stops to account for the player moving, the 15 value is as far as the player can go
            if (cameraPosTemp.x >= -15)
            {
                cameraPosTemp.x -= speed*accelerationLeft;
            }
            //Makes it so the camera can't move again until the player centers itself on the camera
            if (cameraPos.x >= -5 && cameraPosTemp.x <= 5)
            {
                timeLeft += Time.deltaTime;
                cameraPos.x -= speed*accelerationLeft;
            }
            else
            {
                timeLeft = 0.1f;
            }
        }
        else
        {
            timeLeft = 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Repeat of previous if statement for the other side
            if (cameraPosTemp.x <= 15)
            {
                cameraPosTemp.x += speed*accelerationRight;
            }
            if (cameraPos.x <= 5 && cameraPosTemp.x >= -5)
            {
                timeRight += Time.deltaTime;
                cameraPos.x += speed*accelerationRight;
            }
            else
            {
                timeRight = 0.1f;
            }
        }
        else
        {
            timeRight = 0.1f;
        }
        //print(cameraPosTemp.x);
        transform.position = cameraPos;
    }
}
