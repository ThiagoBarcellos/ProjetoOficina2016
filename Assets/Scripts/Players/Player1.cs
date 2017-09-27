using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1 : MonoBehaviour 
{
	public float volume;

	private GameManager gm;
	public Sprite[] playerOptions;

	public AudioClip Pulo;
	public AudioClip TiroSom;


	public Animator anime;
	public bool atirando;
	public float speed = 0;
	public bool acertado;

	public GameObject EscudoPlayer;
	public static bool escudo;
	public int TempoEscudo;

	public GameObject BonusPlayer;
	public static bool bonus;
	public int TempoBonus;

	public GameObject Carga1, Carga2, Carga3, Carga4, Carga5;

	public Transform tiro;
	public GameObject spawntiroum;
	public bool lastDirection = true; // true se esquerda
	public static int score;
	public static int Tirosdisponiveis = 3;
	public int tirosmaximos = 5;
	public Rigidbody2D rb;
	public bool grounded = true;
	public int time = 0;
	public int tempo;

		void Start() {
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();

		rb = GetComponent<Rigidbody2D> ();

		GetComponent<SpriteRenderer> ().sprite = playerOptions [gm.player1.imageId - 1];

		TempoEscudo = 0;

	}

	void Update()
	{
		SpriteRenderer E = EscudoPlayer.GetComponent<SpriteRenderer>();
		SpriteRenderer B = BonusPlayer.GetComponent<SpriteRenderer>();
		SpriteRenderer C1 = Carga1.GetComponent<SpriteRenderer> ();
		SpriteRenderer C2 = Carga2.GetComponent<SpriteRenderer> ();
		SpriteRenderer C3 = Carga3.GetComponent<SpriteRenderer> ();
		SpriteRenderer C4 = Carga4.GetComponent<SpriteRenderer> ();
		SpriteRenderer C5 = Carga5.GetComponent<SpriteRenderer> ();

		if (PauseeExit.movepause) {
			if (Input.GetKeyDown (KeyCode.W) /*|| Input.GetJoystickNames(KeyCode.Joystick1Button0)*/ && grounded == true) {
				rb.AddForce (Vector2.up * 360f);
				grounded = false;
				AudioSource.PlayClipAtPoint(Pulo, transform.position);

				//transform.Translate(new Vector2(0, 0.2f));
			}
		
			if (Input.GetKey (KeyCode.A) && lastDirection == true) {
				transform.Rotate (new Vector3 (0, -180, 0));
				//transform.Translate(new Vector2(0.2f, 0));
				lastDirection = false;
			}

		
			if (Input.GetKey (KeyCode.D) && lastDirection == false) {
				transform.Rotate (new Vector3 (0, 180, 0));
				//transform.Translate(new Vector2(-0.2f, 0));
				lastDirection = true;
			}

			
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
				transform.Translate (new Vector2 (0.08f, 0));
				speed = 1.02f;
			} else {
				speed = 0f;
			}


			if (Input.GetKeyDown (KeyCode.Space) && Tirosdisponiveis >= 1) {
				Transform newTiro;
				newTiro = Instantiate (tiro, spawntiroum.transform.position, tiro.transform.localRotation) as Transform;
				newTiro.GetComponent<direcaotiro> ().shotTo = lastDirection;
				Tirosdisponiveis--;
				atirando = true;
				AudioSource.PlayClipAtPoint(TiroSom, transform.position);


			} else {
				atirando = false;
			}

			if (Tirosdisponiveis > tirosmaximos) {
				Tirosdisponiveis = 5;
			}
			if (Tirosdisponiveis == 5) {
				C1.enabled = true;
				C2.enabled = true;
				C3.enabled = true; 
				C4.enabled = true;
				C5.enabled = true;
				time = 0;
			}

			if (Tirosdisponiveis == 4) {
				C1.enabled = true;
				C2.enabled = true;
				C3.enabled = true; 
				C4.enabled = true;
				C5.enabled = false;
			}

			if (Tirosdisponiveis == 3) {
				C1.enabled = true;
				C2.enabled = true;
				C3.enabled = true; 
				C4.enabled = false;
				C5.enabled = false;
			}

			if (Tirosdisponiveis == 2) {
				C1.enabled = true;
				C2.enabled = true;
				C3.enabled = false; 
				C4.enabled = false;
				C5.enabled = false;
			}

			
			if (Tirosdisponiveis == 1) {
				C1.enabled = true;
				C2.enabled = false;
				C3.enabled = false; 
				C4.enabled = false;
				C5.enabled = false;
			}

			if (Tirosdisponiveis == 0) {
				C1.enabled = false;
				C2.enabled = false;
				C3.enabled = false; 
				C4.enabled = false;
				C5.enabled = false;
			}



			if (acertado == true)
				tempo++;

			if (tempo >= 25) {
				acertado = false;
				tempo = 0;
			}

			if(escudo == true && TempoEscudo <= 1000){
				TempoEscudo--;
				E.enabled = true;
			}

			if(TempoEscudo == 0){
				E.enabled = false;
				escudo = false;
			}

			if(bonus == true && TempoBonus <= 800){
				TempoBonus--;
				B.enabled = true;

			}
			
			if(TempoBonus == 0){
				B.enabled = false;
				bonus = false;
			}


			anime.SetBool ("Jump", !grounded);
			anime.SetBool ("Atirando", atirando);
			anime.SetFloat ("Speed", speed);
			anime.SetBool ("Acertado", acertado);

		}
	}


	
	void OnCollisionEnter2D(Collision2D coll)
	{
		
		if (coll.gameObject.tag == "branca" && acertado == false && escudo == false && Player2.bonus == false ) {
			Player2.score ++;
			acertado = true;
		}

		if (coll.gameObject.tag == "branca" && acertado == false && escudo == false && Player2.bonus == true) {
			Player2.score +=2;
			acertado = true;
		} 

		if (coll.gameObject.tag == "chao") {
			grounded = true;
		}
		if (coll.gameObject.tag == "Escudo") {
			escudo = true;
			TempoEscudo = 800;
		}

		if (coll.gameObject.tag == "Bonus") {
			bonus = true;
			TempoBonus = 800;
		}
	
		if (coll.gameObject.tag == "teleport1") {
			transform.position = new Vector3(11f, 2.5f, -0.04f);
		}
		if (coll.gameObject.tag == "teleport2") {
			transform.position = new Vector3(-11f, 2.5f, -0.04f);
		}
		if (coll.gameObject.tag == "teleport3") {
			transform.position = new Vector3(11f, -4.25f, -0.04f);
		}
		if (coll.gameObject.tag == "teleport4") {
			transform.position = new Vector3(-11f, -4.25f, -0.04f);
		}
	

	} 




	void OnTriggerStay2D(Collider2D coll){
		time++;
		if (time == 140) {
			Tirosdisponiveis++;
			time = 0;
		}
	}
	void OnTriggerExit2D(Collider2D coll){
		time = 0;
	}
}