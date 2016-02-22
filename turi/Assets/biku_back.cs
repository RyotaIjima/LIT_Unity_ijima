using UnityEngine;
using System.Collections;

public class biku_back : MonoBehaviour {

	GameObject can;
	GameObject can2;

	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas2");
		can2 = GameObject.Find ("Canvas3");
	}

	public void psh(){
		can.GetComponent<Canvas> ().enabled = true;
		can2.GetComponent<Canvas> ().enabled = false;
	}
}
