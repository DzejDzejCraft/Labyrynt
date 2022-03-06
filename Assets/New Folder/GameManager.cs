using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] int Timeleft = 100;
    private int points;
 

    private bool gamePaused;
    #region UnityCallbacks
    void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Multiply Game menagers in scene");
        }
        
    }
    private void Start()
    {
        InvokeRepeating(nameof(TimerTick), 3, 1);
    }
    private void Update()
    {
        PauseCheck();
    }

    
    #endregion

    #region Methods
    private void PauseCheck()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused)
            {
                gamePaused = false;
                Time.timeScale = 1;
            }
            else
            {
                gamePaused = true;
                Time.timeScale = 0;
            }
        }
    }
    void TimerTick()
    {
        Timeleft--;
        
        if(Timeleft <= 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        CancelInvoke(nameof(TimerTick));
        Time.timeScale = 0;
    }
    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
    }

    #endregion
}
