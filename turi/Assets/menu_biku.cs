using UnityEngine;
using System.Collections;

public class menu_biku : MonoBehaviour {

	GameObject can;
	GameObject can2;

	GameObject scrl;

	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas2");
		can2 = GameObject.Find ("Canvas3");
	
		scrl = GameObject.Find ("Content");
	}


	public void psh(){
		can.GetComponent<Canvas> ().enabled = false;
		can2.GetComponent<Canvas> ().enabled = true;

		scrl.SendMessage ("iwashi_scroll");
	}
}
