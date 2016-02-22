using UnityEngine;
using System.Collections;

public class push_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			FadeManager.Instance.LoadLevel ("house", 2.0f);
		}
	}
}
