using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Movement : MonoBehaviour {

    public float mSpeed;

	void Start () {

        mSpeed = 7f;

	}
	
	void Update () {

        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

	}
}
