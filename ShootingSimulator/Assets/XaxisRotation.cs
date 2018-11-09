using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XaxisRotation : MonoBehaviour {

    public browning bro;
    public float horizontalSpeed = 10.0f;
    public float minY = -50.0f;
    public float maxY = 50.0f;
    Vector3 euler;
    public int startPosition;

    // Use this for initialization
    void Start () {
        euler.y = startPosition;
    }
	
	// Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = euler;

        if (bro.camera2.activeSelf == true)
            {
                float h = horizontalSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;

                euler.y += h;

            if (euler.y >= maxY)
                    euler.y = maxY;
                if (euler.y <= minY)
                    euler.y = minY;

        }
    }
}
