using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class browning : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public bool GuiOn;
    public string Text = "Press F to use";
    public Rect BoxSize = new Rect(0, 0, 200, 100);


    public GUISkin customSkin;

    void Awake()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    void Update()
    {
        thereIsNoEscape();
    }

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        GuiOn = true;

    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        GuiOn = false;
    }

    void OnGUI()
    {
        if (customSkin != null)
        {
            GUI.skin = customSkin;
        }

        if (GuiOn == true)
        {
            // Make a group on the center of the screen
            GUI.BeginGroup(new Rect((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2,
                BoxSize.width, BoxSize.height));
            // All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.

            GUI.Label(BoxSize, Text);

            GUI.EndGroup();
        }
    }

    void thereIsNoEscape()
    {
        if (camera2.activeSelf == true)
        {

            if (Input.GetKey(KeyCode.X))
            {
                camera1.SetActive(true);
                camera2.SetActive(false);
            }
        }
    }
}