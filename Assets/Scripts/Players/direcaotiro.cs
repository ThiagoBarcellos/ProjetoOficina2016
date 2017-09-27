using UnityEngine;
using System.Collections;

public class direcaotiro : MonoBehaviour 
{
	public bool shotTo = true; // true se esquerda
	
	void Update () 
	{
		Vector2 to = (shotTo) ? new Vector2 (0.3f, 0) : new Vector2 (-0.3f, 0);
		transform.Translate(to);
	}

	void OnBecameInvisible() {
		Destroy(this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll){
		Destroy (this.gameObject);
	}
}
