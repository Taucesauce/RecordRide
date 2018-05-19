using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour {
    public float Speed;
    Transform movementAxis;

	// Use this for initialization
	void Start () {
        movementAxis = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += movementAxis.up * (Time.deltaTime * Speed * Input.GetAxis("Horizontal"));
	}
}
