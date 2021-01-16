using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int SceneValue;
    public List<GameObject> prefabs;

    public bool Lost = false;
    public bool Win = false;


    void Start()
    {

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
        yield return new WaitForSeconds(5f);
        if (Lost == false)
        {
            Win = true;
            Debug.Log("you are winner !");
            SceneValue++;
            SceneManager.LoadScene(SceneValue);
        }
        else
        {


        }

    }

    public IEnumerator Losing()
    {
        yield return new WaitForSeconds(2f);

        if (!Win)
        {
            Lost = true;
            Debug.Log("you lost :/");
            SceneManager.LoadScene(SceneValue);
        }
    }
}