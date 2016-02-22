using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class biku_script : MonoBehaviour {

	static public List<string> biku_fish = new List<string> ();

	static public int biku_number = 0;

	GameObject biku;

	// Use this for initialization
	void Start () {

		print (biku_number);
		biku = GameObject.Find ("biku_obj");

		DontDestroyOnLoad(biku);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
