using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button btnPlay;
    public Button btnExit;

    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(playGame);
        btnExit.onClick.AddListener(exitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playGame()
    {
        SceneManager.LoadScene(1);
    }

    void exitGame()
    {
        Application.Quit();
    }
}
