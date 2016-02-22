using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rod_animation_script : MonoBehaviour {

	Animator anim;

	public Image hit;
	bool hit_bool;

	int i;
	int hit_range;
	// Use this for initialization

	Vector3 iwasi_pos;

	mouse_pos_script cas_pos;

	GameObject cam;

	void Start () {
		anim = GetComponent<Animator> ();
		hit.enabled = false;
		i = 0;

		hit_range = Random.Range(0,1000);



//		print ("hit range = " + hit_range);
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		if(i >= 1000){
			i = 0;
		}
			
		if (i <= hit_range + 100 && i >= hit_range - 100 && mouse_pos_script.cast_flag) {
			hit.enabled = true;
			hit_bool = true;
		} else {
			hit.enabled = false;
			hit_bool = false;
		}

//		print("cast_"+mouse_pos_script.cast_flag);
//		print ("hit_"+hit_bool);

		if (mouse_pos_script.cast_flag) {
			anim.SetBool ("throw",true);

		} else if(!hit_bool && !mouse_pos_script.cast_flag && Input.GetMouseButtonDown(0)){
			anim.SetBool ("throw",false);
		}

		if(hit_bool && Input.GetMouseButtonDown(0)){
			anim.SetBool ("get",true);
			hit_ ();

		}
	}

	public GameObject iwasi;

	static public bool hitting = false;

	public void purupuru_end(){
		anim.SetBool ("get",false);
		anim.SetBool ("throw",false);
	}

	void hit_(){
		hitting = true;
		iwasi_pos = mouse_pos_script.cast_pos;
		Instantiate (iwasi, iwasi_pos, Quaternion.identity);
	}


}
