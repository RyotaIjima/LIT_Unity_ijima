using UnityEngine;
using System.Collections;

public class cook_back : MonoBehaviour {

	GameObject can2;

	// Use this for initialization
	void Start () {
		can2 = GameObject.Find ("Canvas4");
	}

	public void psh(){
		can2.GetComponent<Canvas> ().enabled = false;
	}
}
