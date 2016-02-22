using UnityEngine;
using System.Collections;

public class menu_script : MonoBehaviour {

	GameObject can;

	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas2");
		can.GetComponent<Canvas> ().enabled = false;
	}
	
	public void psh(){
		can.GetComponent<Canvas> ().enabled = true;
	}
}
