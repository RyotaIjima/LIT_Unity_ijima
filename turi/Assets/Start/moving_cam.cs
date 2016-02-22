using UnityEngine;
using System.Collections;

public class moving_cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate ( 0, Time.deltaTime * 10, 0 );
	}
}
