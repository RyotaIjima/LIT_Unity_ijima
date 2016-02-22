using UnityEngine;
using System.Collections;

public class grav_change : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.isKinematic = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (click_fish_script.click_fish) {
			rb.isKinematic = true;
		} else {
			rb.isKinematic = false;
		}
	}
}
