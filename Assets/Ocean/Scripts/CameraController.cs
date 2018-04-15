using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public float moveSpeed = 1.0f;
	public float rotateSpeed = 3.5f;

	public void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.LeftShift)) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + rotateSpeed, 0.0f);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - rotateSpeed, 0.0f);
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x - rotateSpeed, transform.eulerAngles.y, 0.0f);
			}
			if (Input.GetKey (KeyCode.UpArrow)) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x + rotateSpeed, transform.eulerAngles.y, 0.0f);
			}
		} else {
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveSpeed);
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveSpeed);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed, transform.position.z);
			}
			if(Input.GetKey(KeyCode.UpArrow))
			{
				transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
			}
		}
	}
}
