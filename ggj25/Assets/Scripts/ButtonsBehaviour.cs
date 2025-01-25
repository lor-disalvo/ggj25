using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehaviour : MonoBehaviour
{
    
    void FixedUpdate ()
    {
        
    }
    
    
    void Update ()
    {
    }
    void Awake ()
    {
        Debug.Log("Awake called.");
    }
    
    
    void Start ()
    {
        Debug.Log("Start called.");
    }
    
    public void LoadGame() {
        SceneManager.LoadScene("Game");
    }

    public void LoadLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void PrintHw()
    {
        print("Hello World!");
    }
}
