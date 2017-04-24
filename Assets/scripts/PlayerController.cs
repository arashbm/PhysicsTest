using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
	}

	void FixedUpdate() {
		float inputForceMultiplier = 5.0f;
		float horizontalForce = Input.GetAxis ("Horizontal");
		float verticalForce = Input.GetAxis ("Vertical");

		Vector3 inputForce = (new Vector3(horizontalForce, 0.0f, verticalForce))  * inputForceMultiplier;
		rb.AddForce(inputForce);
	}
}
