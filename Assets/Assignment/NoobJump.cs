using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NoobJump : MonoBehaviour
{
    //Initialize variables
    float speed = 0.005f;
    float speedCurve;
    float time;
    bool reachedTop = false, reachedBottom = false, curveUp = true, curveDown = false;
    Vector3 startPosition;
    Vector3 destination;
    //Two curves one for going up one for going down
    [SerializeField]
    private AnimationCurve curve;
    [SerializeField]
    private AnimationCurve curve2;
    void Start()
    {
        //Initialize the start position and initial destination
        startPosition = transform.position;
        destination = new Vector3(2.968f, 5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 noobPos = transform.position;
        //speedCurve = speed + Time.deltaTime;
        //noobPos.y += curve.Evaluate(speedCurve);
        noobPos.y += speed;
        time += Time.deltaTime;
        //Vector3 destination = new Vector3(2.968f, 5, 0);
        //destination.y += speed / 4;
        if (noobPos.y >= 5)
        {
            speed *= -1;
            //Set destination to going down
            destination = new Vector3(2.968f, 2f, 0);
            startPosition = transform.position;
            reachedTop = true;
            reachedBottom = false;
        }
        if (noobPos.y <= 2)
        {
            speed *= -1;
            //Set destination to going up
            destination = new Vector3(2.968f, 5f, 0);
            startPosition = transform.position;
            reachedBottom = true;
            reachedTop = false;
        }
        if (reachedTop == true)
        {
            //When the noob reaches the top it resets the timer and adjusts booleans
            time = 0;
            reachedTop = false;
            curveUp = false;
            curveDown = true;
        }
        if (reachedBottom == true)
        {
            time = 0;
            reachedBottom = false;
            curveUp = true;
            curveDown = false;
        }
        //print(reachedTop);
        //If the noob is moving up then the curve slows down as you get to the top
        if (curveUp == true)
        {
            transform.position = Vector3.Lerp(startPosition, destination, curve.Evaluate(time));
        }
        //If the noob is moving down then the curve speeds up as you get to the bottom
        if (curveDown == true)
        {
            transform.position = Vector3.Lerp(startPosition, destination, curve2.Evaluate(time));
        }
        //transform.position = noobPos;
    }
}
