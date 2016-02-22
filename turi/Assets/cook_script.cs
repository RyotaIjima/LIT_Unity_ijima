using UnityEngine;
using System.Collections;

public class cook_script : MonoBehaviour {

	GameObject can;

	GameObject scrl;

	void Start () {
		can = GameObject.Find ("Canvas4");
		can.GetComponent<Canvas> ().enabled = false;

		scrl = GameObject.Find ("Content2");
	}

	public void psh(){
		can.GetComponent<Canvas> ().enabled = true;

		scrl.SendMessage ("iwashi_scroll");
	}
}
