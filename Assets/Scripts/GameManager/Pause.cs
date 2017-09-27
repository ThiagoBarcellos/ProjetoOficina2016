using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Pause : MonoBehaviour {

    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    Text mutetext;

	void Start () {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 0;
        }

        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "Unmute";
        }

		else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
        }
	
	}

    public void BT_Resume()
    {
        paused = false;
    }

    public void BT_MainMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void BT_Load()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
    }

    public void BT_Mute()
    {
        muted = !muted;
    }

    public void BT_Quit()
    {
        Application.Quit();
    }
}
