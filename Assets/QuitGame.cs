using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitGameTime()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
