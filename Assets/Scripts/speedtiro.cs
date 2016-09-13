using UnityEngine;
using System.Collections;

public class speedtiro : MonoBehaviour {
	public float speed;


void Update()
    {
		transform.Translate(Vector2.right * speed * -5);
		if (transform.position.x <= -12) 
		{
			Destroy (this.gameObject);
		}
    }

	void OnCollisioEnter2D(Collision2D coll)
	{
		Destroy (this.gameObject);

	}


}
