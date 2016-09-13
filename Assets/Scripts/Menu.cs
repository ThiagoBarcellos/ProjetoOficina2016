using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() { }
	public void Play()
    {
      Application.LoadLevel("nosso novo jogo potrotipo");
    }
       public void Credit()
    {
        Application.LoadLevel("Creditos");
    }
    public void Exit()
    {
        Application.Quit();
    }
	public void Voltar()
	{
		Application.LoadLevel("Menu");
	}
	public void Intrucoes()
	{
		Application.LoadLevel("Tutorial");
	}

}
