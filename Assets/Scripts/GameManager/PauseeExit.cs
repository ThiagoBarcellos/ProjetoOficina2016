using UnityEngine;
using System.Collections;

public class PauseeExit : MonoBehaviour {

	private bool pause = false;
	public CanvasGroup cg;
	public static bool movepause = true;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			pause = !pause;
			movepause = !movepause;
		}
		if (pause && !movepause) {
			Time.timeScale = 0f;
			cg.gameObject.SetActive(true);
		}
		if(!pause && movepause)
		{
			Time.timeScale = 1f;		
			cg.gameObject.SetActive(false);
		}
		if (Menu.restart) {
			Time.timeScale = 1f;
			cg.gameObject.SetActive(false);
		}
		if (Menu.again) {
			pause = !pause;
			movepause = !movepause;
			Time.timeScale = 1f;		
			cg.gameObject.SetActive(false);
			Menu.again = false;
		}
	}
}
