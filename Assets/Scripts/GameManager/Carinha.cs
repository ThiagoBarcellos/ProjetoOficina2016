using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Carinha : MonoBehaviour {

	public Sprite player1, player2, empate;
	
	
	void Start () {
		//cv = cv.gameObject.GetComponent<Image>();
	}
	
	void Update () {
		
		if (Player1.score > Player2.score)
		{
			this.transform.GetComponent<Image>().sprite = player1;
		}
		else if (Player2.score > Player1.score)
		{
			this.transform.GetComponent<Image>().sprite = player2;
		}
		else
		{
			this.transform.GetComponent<Image>().sprite = empate;
		}
	}
}
