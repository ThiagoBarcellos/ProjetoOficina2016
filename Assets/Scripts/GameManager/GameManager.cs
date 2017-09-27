using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Player player1 = new Player ();
	public Player player2 = new Player ();
	
	void Awake() {
		DontDestroyOnLoad (this);
		player1.name = "Player 1";
		player2.name = "Player 2";

		player1.imageId = 1;
		player2.imageId = 3;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("P1 = " + player1.imageId + " || P2 = " + player2.imageId);
	}
}
