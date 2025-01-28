using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptCamera : MonoBehaviour
{
    float speed = 0.01f;
    public Vector3 cameraPosTemp = new Vector3(0,0,0);
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 cameraPos = transform.position;
        cameraPos.z = -10;
        if (Input.GetKey(KeyCode.A))
        {
            if (cameraPosTemp.x > -15)
            {
                cameraPosTemp.x -= speed;
            }
            if (cameraPos.x > -5 && cameraPosTemp.x < 5)
            {
                cameraPos.x -= speed;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (cameraPosTemp.x < 15)
            {
                cameraPosTemp.x += speed;
            }
            if (cameraPos.x < 5 && cameraPosTemp.x > -5)
            {
                cameraPos.x += speed;
            }
        }
        print(cameraPosTemp.x);
        transform.position = cameraPos;
    }
}
