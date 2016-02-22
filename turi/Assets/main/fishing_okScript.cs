using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fishing_okScript : MonoBehaviour {

	public Image fishOK;

	static public bool fishOK_bool;


	// Use this for initialization
	void Start () {
//		fishOK.enabled = false;
		fishOK_bool = false;
	}

	void Update(){
//		if(click_fish_script.click_fish){
//			fishOK.enabled = false;
//		}
//		print (click_fish_script.click_fish);
	}

	// Update is called once per frame
//	void OnTriggerEnter (Collider col) {
//		if (col.gameObject.tag == "Player") {
//			fishOK.enabled = true;
//			fishOK_bool = true;
//		}
//	}

	void OnTriggerStay(Collider col){
		if (col.gameObject.tag == "Player" && !click_fish_script.click_fish) {
//			fishOK.enabled = true;
			fishOK_bool = true;
		} 
	}

	void OnTriggerExit (Collider col) {
		if (col.gameObject.tag == "Player") {
//			fishOK.enabled = false;
			fishOK_bool = false;
		}
	}
}
