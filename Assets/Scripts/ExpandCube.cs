using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandCube : MonoBehaviour {

    public float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale = transform.localScale + new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);

	}
}
