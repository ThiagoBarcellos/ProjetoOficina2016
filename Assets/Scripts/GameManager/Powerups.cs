using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Powerups : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (sumir ());

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			Destroy (this.gameObject);
         }
    }
		
	IEnumerator sumir()
	{
		yield return new WaitForSeconds (10f);
		Destroy (gameObject);
	}

}