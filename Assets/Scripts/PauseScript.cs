using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool GameIsPause = false;
    public void Pause()
    {
        if (GameIsPause == false)
        {
            Time.timeScale = 0f;
            GameIsPause= true;
        }
        else
        {
            Time.timeScale = 1f;
            GameIsPause= false;
        }
    }
}
