using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenSesame {
	public class Keypad : MonoBehaviour {
		public static string correctPassword = "456";
		public static string playerInput = "";

		public static int totalDigit = 0;
		public static bool doorOpened = false;
		public Transform doorHinge;
		public Transform door;

		void Update(){
			Debug.Log (playerInput);
			if (totalDigit == 3) {
				if (playerInput == correctPassword) {
					Debug.Log ("Correct");
				} else {
					playerInput = "";
					totalDigit = 0;
					Debug.Log ("Incorrect");
				}
			}
			if (playerInput == correctPassword) {
				doorOpened = true;
			}

			if (doorOpened) {
	//			var newRot = Quaternion.RotateTowards (doorHinge.rotation, Quaternion.Euler (0f, -90f, 0f), Time.deltaTime * 250);
	//			doorHinge.rotation = newRot;
				door.GetComponent<Renderer>().material.color = new Color(0, 102, 0);
			}

			if(Input.GetMouseButtonDown(0)){
				RaycastHit hit;
				Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.rotation * Vector3.forward);
				if (Physics.Raycast(ray, out hit, 10000)) {
					if (hit.transform == this.transform) {
						if (!doorOpened) {
							playerInput += gameObject.name;
							totalDigit += 1;
						}
					}
				}
			}
		}
		
	}
}
