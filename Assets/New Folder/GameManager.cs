using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] int Timeleft = 100;
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

    void TimerTick()
    {
        Timeleft--;
        
        if(Timeleft <= 0)
        {
            //game end
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
