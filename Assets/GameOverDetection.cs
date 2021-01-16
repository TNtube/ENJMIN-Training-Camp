using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDetection : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entered Trigger event");
        GameController gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        if (!gameController.Win)
        {
            StartCoroutine(gameController.Losing());
        }

    }


}
