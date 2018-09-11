using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatewithMouse : MonoBehaviour
{

        // Use this for initialization

        void Start()
        {
            Camera main;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float x = 5 * Input.GetAxis("Mouse X");
            float y = 5 * -Input.GetAxis("Mouse Y");
            Camera.main.transform.Rotate(x, y, 0);
            // declare the RaycastHit variable

        }
    }