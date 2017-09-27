using UnityEngine;
using System.Collections;

public class PlayerSelect : MonoBehaviour {

	public GameManager gm;
	public int myId;
    public GameObject selection1;
    public GameObject selection2;
     
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gm.player1.imageId == myId) {
			//Debug.Log("Player 1 selecinou " + myId);

		}
		if (gm.player2.imageId == myId) {
			//Debug.Log("Player 2 selecinou " + myId);
		}
	}
}
