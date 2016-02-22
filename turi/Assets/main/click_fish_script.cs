using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class click_fish_script : MonoBehaviour {

	static public bool click_fish = false;

	private GameObject cam;
	private GameObject rod;
	private GameObject place;

	private GameObject cast_point;
	public Image fishBack;

	GameObject get_cam1;


	// Use this for initialization
	void Start () {
		cam = GameObject.Find ("Camera");
		cam.SetActive(false);

		rod = GameObject.Find ("rod");
		rod.GetComponent<MeshRenderer> ().enabled = false;

		place = GameObject.Find ("FishPlaces");
		place.SetActive (true);

		cast_point = GameObject.Find ("cast_point");
		cast_point.SetActive (false);

		fishBack.enabled = true;


		get_cam1 = GameObject.Find("ThirdPersonController");






	}

	void Update(){
		if (click_fish) {
			cam.SetActive (true);
			rod.GetComponent<MeshRenderer> ().enabled = true;
			fishBack.enabled = true;
			if (!mouse_pos_script.cast_flag && !rod_animation_script.hitting) {
				cast_point.SetActive (true);
			} else {
				cast_point.SetActive (false);
			}

			get_cam1.SendMessage ("stop");


			place.SetActive (false);
		} else {
			cam.SetActive (false);
			rod.GetComponent<MeshRenderer> ().enabled = false;
			fishBack.enabled = false;

			get_cam1.SendMessage ("move");

			cast_point.SetActive (false);
			place.SetActive (true);
		}
	}

	// Update is called once per frame
	public void click(){
		click_fish = true;
	}
}
