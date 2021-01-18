using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDetection : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)
    {
        GameController gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        if (!gameController.Win && !gameController.Lost)
        {
            StartCoroutine(gameController.Losing());
        }
    }
}
