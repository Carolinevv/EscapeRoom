using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenSesame {
	public class DisplayText : MonoBehaviour {
		public UnityEngine.UI.Text win;
		// Use this for initialization
		void Start () {
			win = this.GetComponent<UnityEngine.UI.Text> ();
			win.enabled = false;
		}

		// Update is called once per frame
		void Update () {
			if (Keypad.doorOpened) {
				win.enabled = true;
			}
		}
	}
}