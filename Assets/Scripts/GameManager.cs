﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    private bool gameHasEnded = false;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!!!");

            Invoke("Restart", restartDelay);
        }

    }


    public void CompleteLevel()
    {
        Debug.Log("Level won!");
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
