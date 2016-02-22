using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sleep_click_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(){
		FadeManager.Instance.LoadLevel ("house", 2.0f);
	}
}
