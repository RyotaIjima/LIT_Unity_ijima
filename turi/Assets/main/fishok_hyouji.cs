using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fishok_hyouji : MonoBehaviour {

	public Image fishOK;

	// Use this for initialization
	void Start () {
//		fishOK.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (click_fish_script.click_fish) {
			fishOK.enabled = false;
		} else {
			fishOK.enabled = true;
		}

		if(!fishing_okScript.fishOK_bool){
			fishOK.enabled = false;
		}
	}
}
