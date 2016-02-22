using UnityEngine;
using System.Collections;

public class menu_kitaku : MonoBehaviour {

	public void psh(){
		FadeManager.Instance.LoadLevel ("house", 2.0f);
	}
}
