using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunmovement : MonoBehaviour
{

    public browning bro;
    public float verticalSpeed = 300.0f;
    public float min = -50.0f;
    public float max = 50.0f;
    Vector3 euler;
    public int startPosition = -180;


    // Use this for initialization
    void Start ()
    {
        euler.x = startPosition;
    }
	
	// Update is called once per frame
	void Update ()
	{
	    transform.localEulerAngles = euler;

        if (bro.camera2.activeSelf == true)
	    {
	        float v = verticalSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;

	        euler.x += v;

	        if (euler.x >= max)
	            euler.x = max;
	        if (euler.x <= min)
	            euler.x = min;
        }
 
    }
}
