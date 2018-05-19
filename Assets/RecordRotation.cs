using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordRotation : MonoBehaviour {
    Transform parentWrapper;
    Animator anim;
    int flipHash = Animator.StringToHash("Flip");

    bool isBSide = false;
    float recordSpeed = 50f;

	// Use this for initialization
	void Start () {
        parentWrapper = transform.parent;
        anim = GetComponentInParent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * recordSpeed);
        //Flip record on key press.
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            isBSide = !isBSide;
            anim.SetTrigger(flipHash);
        }
    }
}
