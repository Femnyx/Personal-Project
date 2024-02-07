using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew() //starts the game
    {
        SceneManager.LoadScene(1);
    }

    public void Settings() //goes to Settings scene
    {
        SceneManager.LoadScene(2);
    }

    public void Main() //goes to Main Menu scene
    {
        SceneManager.LoadScene(0);
    }

    public void Credits() //goes to Credits scene
    {
        SceneManager.LoadScene(3);
    }

    public void Death()
    {
        SceneManager.LoadScene(4);
    }

    public void Exit() //Quit Game
    {
        Application.Quit();
    }
}
