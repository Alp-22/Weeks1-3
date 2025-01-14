using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ClockScript : MonoBehaviour
{
    float speed = 200;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(0, 0, 0);
        Vector3 axis = new Vector3(0, 0, 1);
        transform.RotateAround(point, axis, -Time.deltaTime * speed);
 
    }
}
