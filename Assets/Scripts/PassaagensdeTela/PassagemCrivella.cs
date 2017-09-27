using UnityEngine;
using System.Collections;

public class PassagemCrivella : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		StartCoroutine (passagemDeTela ());
		
	}
	
	IEnumerator passagemDeTela()
	{
		yield return new WaitForSeconds (2f);
		Application.LoadLevel ("Agradecimentos");
	}
}
