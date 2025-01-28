using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class NoobGround : MonoBehaviour
{
    bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 objectPos = transform.position;
        mousePos.z = 0f;
        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
        }
        if (clicked == true)
        {
            objectPos.x -= 0.002f;
        }
        transform.position = objectPos;
    }
}
