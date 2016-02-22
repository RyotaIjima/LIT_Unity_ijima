using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class get_fish_script : MonoBehaviour {

	public Text get_fish_text1;
	public Text get_fish_text2;
	public Image get_fish_panel;
	public Image get_fish_img;
	public Image ok_button;

	// Use this for initialization
	void Start () {
		get_fish_text1.enabled = false;
		get_fish_text2.enabled = false;
		get_fish_panel.enabled = false;
		get_fish_img.enabled = false;
		ok_button.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Get_fish_(){
		get_fish_text1.enabled = true;
		get_fish_text2.enabled = true;
		get_fish_panel.enabled = true;
		get_fish_img.enabled = true;
		ok_button.enabled = true;
	}
}
