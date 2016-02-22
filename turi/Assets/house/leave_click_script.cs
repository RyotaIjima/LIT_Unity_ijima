using UnityEngine;
using System.Collections;

public class leave_click_script : MonoBehaviour {

	public void click(){
		FadeManager.Instance.LoadLevel ("main", 2.0f);
		print ("OK");
	}
}
