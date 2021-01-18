using System.Collections;
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
        int cd = 5;
        while(cd > 0)
        {
            if (!Lost)
            {
                cdText.text = "" + cd;

            }
            else
            {
                cdText.text = "";
            }
            yield return new WaitForSeconds(1f);
            cd--;
        }
        countdownText.SetActive(false);
        if (Lost == false)
        {
            Win = true;
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
            GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<LevelLoader>().ReloadCurrentLevel();
        }
        

        
    }
}