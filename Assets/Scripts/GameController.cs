using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int SceneValue;
    public int objectValue;
    public int counter;
    public List<GameObject> prefabs;

    public bool Lost;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabs[0]);
        prefabs.RemoveAt(0);


    }

    // Update is called once per frame
    void Update()
    {

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
            Debug.Log("you are winner !");
            SceneManager.LoadScene("Scene2");
        }
        else
        {


        }

    }
}