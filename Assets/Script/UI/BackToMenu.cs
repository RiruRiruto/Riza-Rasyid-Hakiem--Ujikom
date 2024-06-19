using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public Button btnMainMenu;
    // Start is called before the first frame update
    void Start()
    {
        btnMainMenu.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
