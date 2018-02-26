using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rigidbody Rigidbody;

	protected float speed = 6f;
	protected Vector3 movementDirection;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
		float z = Input.GetAxisRaw ("Vertical") * Time.deltaTime;

		if (x != 0f || z != 0f){
			Move (x, z);
		}
	}

	public void Move(float x, float z){
		movementDirection.Set (x * speed, 0f, z * speed);
		if (Rigidbody != null) {
			Rigidbody.MoveRotation (Quaternion.LookRotation (movementDirection));
			Rigidbody.MovePosition (gameObject.transform.position + movementDirection);
		}
	}
}
