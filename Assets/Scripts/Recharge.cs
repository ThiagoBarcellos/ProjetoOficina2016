using UnityEngine;
using System.Collections;

public class Recharge : MonoBehaviour {

	public static int time = 0;	
	public static int tempo = 0;
	public static bool tiro = false;
	public static bool tiro2 = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnTriggerEnter2D(Collider2D coll){
		//time ++;
	}

	void OnTriggerStay2D(Collider2D coll){
		time++;
		if (time == 250 /*&& gameObject.tag == "urubuzinho"*/)
		{
			tiro = true;
			time = 0;
			tempo++;
			Debug.Log(tiro);

				if(tempo == 1)
				{
					tiro = false;
				}
			Debug.Log(tiro);

		}
		if (time >= 500 && gameObject.tag == "picapa") {
			tiro2 = true;
			time = 0;
		}
		Debug.Log (time);
	}
	/*void OnTriggerExit2D(Collider2D coll){

	}
*/
}
