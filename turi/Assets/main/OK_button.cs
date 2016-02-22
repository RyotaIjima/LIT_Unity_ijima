using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OK_button : MonoBehaviour {

	public Text get_fish_text1;
	public Text get_fish_text2;
	public Image get_fish_panel;
	public Image get_fish_img;
	public Image ok_button;


	public void push(){
		get_fish_text1.enabled = false;
		get_fish_text2.enabled = false;
		get_fish_panel.enabled = false;
		get_fish_img.enabled = false;
		ok_button.enabled = false;

		rod_animation_script.hitting = false;

		biku_script.biku_number++;
		biku_script.biku_fish.Add ("いわし");




		GameObject iwashi = GameObject.FindGameObjectWithTag("fish");
		Destroy (iwashi);


	}
}
