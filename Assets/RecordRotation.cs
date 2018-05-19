using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordRotation : MonoBehaviour {
    Transform parentWrapper;
    bool isBSide = false;

	// Use this for initialization
	void Start () {
        parentWrapper = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * 50);
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            parentWrapper.Rotate(180, 0, 180);

            Renderer rend = gameObject.GetComponent<Renderer>();
            isBSide = !isBSide;
            if (isBSide) {
                rend.material.color = Color.blue;
            } else {
                rend.material.color = Color.red;
            }
        }
	}
}
