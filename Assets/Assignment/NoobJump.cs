using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NoobJump : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.02f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 noobPos = transform.position;
            noobPos.y += speed;
        Vector2 destination = new Vector2(0, 1);
        //destination.y += speed / 4;
        if (noobPos.y >= 5)
        {
            speed *= -1;
        }
        if (noobPos.y <= 2)
        {
            speed *= -1;
        }
        //transform.position = Vector2.Lerp(noobPos, destination, Time.deltaTime);
        transform.position = noobPos;
    }
}
