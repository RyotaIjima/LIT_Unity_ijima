using UnityEngine;
using System.Collections;

public class mouse_pos_script : MonoBehaviour {



	private GameObject cast_point_;
	public Camera cam;

	float depth;
	Vector3 worldPosition;

	static public bool cast_flag = false;


	void Start(){
		cast_point_ = GameObject.Find ("cast_point");
	}

	static public Vector3 cast_pos;
	Vector3 targetPos;

	void Update () {
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

//		print (cast_flag);

		if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
			targetPos = new Vector3(hit.point.x, hit.point.y, hit.point.z);
			cast_point_.transform.position = targetPos;
//			print (targetPos);
		}

		if(Input.GetMouseButtonDown(0)){
			if (!cast_flag && !rod_animation_script.hitting) {
				cast_flag = true;
				cast_pos = targetPos;
			} else {
				cast_flag = false;
			}
		}




//		Debug.DrawRay(ray.origin, ray.direction*15.0f, Color.red);




	}

}
