using UnityEngine;
using System.Collections;

public class iwasi_move_script: MonoBehaviour {

//	GameObject find_player;

	Transform find_player;

	GameObject getting_;
	GameObject getting_2;

	// Use this for initialization
	void Start () {
		find_player = GameObject.FindGameObjectWithTag ("Player").transform;

		getting_ = GameObject.Find ("Canvas");
		getting_2 = GameObject.Find ("rod");
	}
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = find_player.position;
		Vector3 direction = playerPos - transform.position;
		direction = direction.normalized;
		transform.position = transform.position + (direction * 1 * Time.deltaTime);
		transform.LookAt(find_player);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			getting_.SendMessage ("Get_fish_");
			getting_2.SendMessage ("purupuru_end");
		}
	}
}
