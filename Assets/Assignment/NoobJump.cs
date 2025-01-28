using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NoobJump : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.005f;
    Vector3 startPosition;
    [SerializeField]
    private AnimationCurve curve;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 noobPos = transform.position;
        noobPos.y += speed;
        Vector3 destination = new Vector3(0, 5, 0);
        //destination.y += speed / 4;
        if (noobPos.y >= 5)
        {
            speed *= -1;
        }
        if (noobPos.y <= 2)
        {
            speed *= -1;
        }
        transform.position = Vector3.Lerp(noobPos, destination, curve.Evaluate(Time.deltaTime));
        //transform.position = noobPos;
    }
}
