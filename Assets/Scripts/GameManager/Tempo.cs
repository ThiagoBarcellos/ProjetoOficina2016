using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tempo : MonoBehaviour {

	public float contagem = 60;
	public int escudo;
	public GameObject[] Powerups;
	public GameObject[] SpawnPower;
	public Text displaycontagem;
	public Text ScoreP1;
	public Text ScoreP2;

	// Use this for initialization
	void Start ()
	{
		escudo = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (contagem > 0f) {
			contagem -= Time.deltaTime;
			displaycontagem.text = contagem.ToString("000");
		}
		else {
			Application.LoadLevel("Vencedor");
		}


		ScoreP1.text = Player1.score.ToString ();
		ScoreP2.text = Player2.score.ToString ();

		DontDestroyOnLoad (this.ScoreP1);
		DontDestroyOnLoad (this.ScoreP1);

		if (contagem <= 90 && escudo == 0) {
			Instantiate (Powerups[Random.Range(0,Powerups.Length)], SpawnPower[Random.Range(0,SpawnPower.Length)].transform.position,transform.localRotation);
			escudo++;

		}

		if (contagem <= 60 && escudo == 1) {
			Instantiate (Powerups[Random.Range(0,Powerups.Length)], SpawnPower[Random.Range(0,SpawnPower.Length)].transform.position,transform.localRotation);
			escudo++;
			
		}

		if (contagem <= 30 && escudo == 2) {
			Instantiate (Powerups[Random.Range(0,Powerups.Length)], SpawnPower[Random.Range(0,SpawnPower.Length)].transform.position,transform.localRotation);
			escudo++;
			
		}


	}
}
