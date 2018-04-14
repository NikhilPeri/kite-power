using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kite : MonoBehaviour {
	public Atmosphere atmosphere;

	public float coefficientLift;
	public float coefficientDrag;
	public float area;
	private float controlDeflection;

	Rigidbody body;

	void Start () {
		body = GetComponent<Rigidbody>();
	}
		
	void FixedUpdate () {
		if (atmosphere == null) {
			return;
		}
	}

	void setControlDeflection(float delta) {
		this.controlDeflection = delta;
	}

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.tag == "Atmosphere") {
			atmosphere = collider.gameObject.GetComponent<Atmosphere>();
		}
	}

	void OnTriggerExit(Collider collider) {
		atmosphere = null;
		Destroy (this.gameObject);
	}
}
