using UnityEngine;
using System.Collections;

public class BG_scroller: MonoBehaviour {
	GameObject outro; 
	// Use this for initialization
	void Start () {
		/*if (this.gameObject.name == "bg0") {
			outro = GameObject.Find("bg1");
		}
		if (this.gameObject.name == "bg1") {
			outro = GameObject.Find("bg0");
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * 0.1f * Time.deltaTime);
		
		if (transform.position.x <= -25.05f) {
			transform.position= new Vector3(transform.position.x + 43f,transform.position.y);
			//transform.position= new Vector3(outro.transform.position.x+outro.GetComponent<BoxCollider2D>().size.x*outro.transform.localScale.x,transform.position.y);
		}
	}
}
