using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class MainScreen : MonoBehaviour
{

    public BirdScript alive;
    public LogicScript logic;
    public bool isPaused = true;
    public GameObject homescreen;
    

    // Start is called before the first frame update
    void Start()
    {
        if (homescreen.activeSelf)
        {
            if (isPaused)
            {
               resumeGame();
            }
            else
            {
                pause();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            alive.birdIsAlive = false;
            logic.gameOver();
        }

    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
   public void pause()
    {
        Time.timeScale = 0;
        isPaused = true;
    }
    

}
