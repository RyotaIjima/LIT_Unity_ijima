using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class img_script : MonoBehaviour {

	public Image Img;

	void Start(){
		Img.enabled = false;
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			Img.enabled = true;
		}
	}
		
	void OnTriggerExit (Collider col) {
		if (col.gameObject.tag == "Player") {
			Img.enabled = false;
		}
	}
}
