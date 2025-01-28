using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptCamera : MonoBehaviour
{
    float speed = 0.01f;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.z = -10;
        if (Input.GetKey(KeyCode.A) && cameraPos.x > -5)
        {
            cameraPos.x -= speed;
        }
        if (Input.GetKey(KeyCode.D) && cameraPos.x < 5)
        {
            cameraPos.x += speed;
        }
        transform.position = cameraPos;
    }
}
