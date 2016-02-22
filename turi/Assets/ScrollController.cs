using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour {

	[SerializeField]
	RectTransform prefab = null;

	void Start () 
	{

	}

	void Update(){
//		var item = GameObject.Instantiate(prefab) as RectTransform;
//		item.SetParent(transform, false);
//
//		var text = item.GetComponentInChildren<Text>();
//		text.text = biku_script.biku_fish[biku_script.biku_number].ToString();
	}

	public GameObject iwashi_scrl;

	public void iwashi_scroll(){

		if(biku_script.biku_number != 0){
			foreach ( Transform n in iwashi_scrl.transform )
			{
				Destroy(n.gameObject);
			}

			for(int i = 0;i<=biku_script.biku_fish.Count-1;i++){
				var item = GameObject.Instantiate(prefab) as RectTransform;
				item.SetParent(transform, false);

				var text = item.GetComponentInChildren<Text>();
				text.text = biku_script.biku_fish[i].ToString();

			}
		}
	}
}