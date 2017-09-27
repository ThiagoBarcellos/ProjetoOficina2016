using UnityEngine;
using System;
using System.Collections;

public class Menu : MonoBehaviour {

    private GameManager gm;
	public static bool restart;
	public static bool again;
    /*public GameObject selection1;
    public GameObject selection2;
    public Vector3 p1position;
    public Vector3 p2position;
	public Vector3[] position;*/

	// Use this for initialization
	void Start () {
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
		restart = false;
		again = false;
	}

    // Update is called once per frame
    void Update() {
		//ChangePlayerSelection ();
	}

	/*public void ChangePlayerSelection()
    {
        if (selection1.transform.localPosition != selection2.transform.localPosition)
        {
            //Player 1
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (gm.player1.imageId == 1)
                {
                    gm.player1.imageId = 4;

                    //p1position = selection1.transform.localPosition;

					selection1.transform.localPosition = position[0];/*new Vector3(133,
                                                                selection1.transform.localPosition.y,
                                                                selection1.transform.localPosition.z);
                }
                else
                {
                    gm.player1.imageId--;
                    p1position = selection1.transform.localPosition;

					selection1.transform.localPosition = /*position[i];new Vector3(selection1.transform.localPosition.x - 91,
                                                                selection1.transform.localPosition.y,
                                                                selection1.transform.localPosition.z);
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (gm.player1.imageId == 4)
                {
                    gm.player1.imageId = 1;
                    p1position = selection1.transform.localPosition;

                    selection1.transform.localPosition = new Vector3(-140,
                                                               selection1.transform.localPosition.y,
                                                               selection1.transform.localPosition.z);
                }
                else
                {
                    gm.player1.imageId++;
                    p1position = selection1.transform.localPosition;

                    selection1.transform.localPosition = new Vector3(selection1.transform.localPosition.x + 91,
                                                                selection1.transform.localPosition.y,
                                                                selection1.transform.localPosition.z);
                }
            }

            //Player 2
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (gm.player2.imageId == 1)
                {
                    gm.player2.imageId = 4;
                    p2position = selection2.transform.localPosition;

                    selection2.transform.localPosition = new Vector3(133,
                                                               selection2.transform.localPosition.y,
                                                               selection2.transform.localPosition.z);
                }
                else
                {
                    gm.player2.imageId--;
                    p2position = selection2.transform.localPosition;

                    selection2.transform.localPosition = new Vector3(selection2.transform.localPosition.x - 91,
                                                                selection2.transform.localPosition.y,
                                                                selection2.transform.localPosition.z);
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (gm.player2.imageId == 4)
                {
                    gm.player2.imageId = 1;
                    p2position = selection2.transform.localPosition;

                    selection2.transform.localPosition = new Vector3(-140,
                                                               selection2.transform.localPosition.y,
                                                               selection2.transform.localPosition.z);
                }
                else
                {
                    gm.player2.imageId++;
                    p2position = selection2.transform.localPosition;

                    selection2.transform.localPosition = new Vector3(selection2.transform.localPosition.x + 91,
                                                                selection2.transform.localPosition.y,
                                                                selection2.transform.localPosition.z);
                }
            }
        }
        else 
        {
            selection1.transform.localPosition = p1position;
            selection2.transform.localPosition = p2position;
        }

	}*/

    public void Play()
    {
      Application.LoadLevel("Respingos");
      Player1.Tirosdisponiveis = 3;
      Player2.Tirosdisponiveis = 3;
		Player1.score = 0;
		Player2.score = 0;
		PauseeExit.movepause = true;
	  restart = true;
	}

	public void Credit()
    {
        Application.LoadLevel("Creditos");
    }
    
	public void Exit()
    {
        Application.Quit();
		Player1.score = 0;
		Player1.Tirosdisponiveis = 3;
		Player2.score = 0;
		Player2.Tirosdisponiveis = 3;
		PauseeExit.movepause = true;
		restart = true;
    }

	public void SelecaoPerso()
	{
		Application.LoadLevel("S.Personagem");
	}

	public void Intrucoes()
	{
		Application.LoadLevel("Tutorial");
	}
    
	public void Voltar()
	{
		Application.LoadLevel("Menu");
		Player1.score = 0;
        Player1.Tirosdisponiveis = 3;
		Player2.score = 0;
        Player2.Tirosdisponiveis = 3;
		restart = true;
		PauseeExit.movepause = true;
	}

    public void CreditoProg()
    {
        Application.LoadLevel("CreditProg");
    }

	public void CreditoMult	()
	{
		Application.LoadLevel("CreditMult");
	}

	public void CreditoRot()
	{
		Application.LoadLevel("CreditRot");
	}
	public void continuar(){
		again = true;
	}

}
