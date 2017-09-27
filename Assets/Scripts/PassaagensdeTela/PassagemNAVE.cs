using UnityEngine;
using System.Collections;

public class PassagemNAVE : MonoBehaviour {

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
		Application.LoadLevel ("Prefeitura");
	}
}

