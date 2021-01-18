﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int SceneValue;
    public List<GameObject> prefabs;

    public bool Lost = false;
    public bool Win = false;

    public GameObject countdownText;
    private Text cdText;


    void Start()
    {
        cdText = countdownText.GetComponent<Text>();
        Instantiate(prefabs[0]);
        prefabs.RemoveAt(0);

    }


    public void OnPlaced()
    {
        if (prefabs.Count > 0)
        {
            Instantiate(prefabs[0]);
            prefabs.RemoveAt(0);
        }
        else
        {
            StartCoroutine(Winning());  
        }
    }


    public IEnumerator Winning()
    {
        countdownText.SetActive(true);
        cdText.text = "5";
        yield return new WaitForSeconds(1f);
        cdText.text = "4";
        yield return new WaitForSeconds(1f);
        cdText.text = "3";
        yield return new WaitForSeconds(1f);
        cdText.text = "2";
        yield return new WaitForSeconds(1f);
        cdText.text = "1";
        yield return new WaitForSeconds(1f);

        countdownText.SetActive(false);
        if (Lost == false)
        {
            Win = true;
            Debug.Log("you are winner !");
            GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<LevelLoader>().LoadNextLevel();
        }
        else
        {


        }

    }

    public IEnumerator Losing()
    {
        Lost = true;
        yield return new WaitForSeconds(2f);
        if(!Win)
        {
            Debug.Log("you lost :/");
            GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<LevelLoader>().ReloadCurrentLevel();
        }
        

        
    }
}