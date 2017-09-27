using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreFinal : MonoBehaviour {

	public Text ScoreFinal2;
	public Canvas cv;
	public Sprite player1, player2;


	void Start () {
		//cv = cv.gameObject.GetComponent<Image>();
	}
	
	void Update () {

        if (Player1.score > Player2.score)
        {
            ScoreFinal2.text = Player1.score.ToString();
			this.transform.GetComponent<Image>().sprite = player1;
        }
        else if (Player2.score > Player1.score)
        {
            ScoreFinal2.text = Player2.score.ToString();
			this.transform.GetComponent<Image>().sprite = player2;
        }
        else
        {
            ScoreFinal2.text = Player1.score.ToString();
        }
	}
}
