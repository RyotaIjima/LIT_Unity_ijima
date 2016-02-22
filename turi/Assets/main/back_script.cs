using UnityEngine;
using System.Collections;


public class back_script : MonoBehaviour {

	public void click(){
		click_fish_script.click_fish = false;
		mouse_pos_script.cast_flag = false;
	}
}
