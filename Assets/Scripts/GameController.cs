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


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPlaced()
    {
        switch (SceneValue)
        {
            case 0:
                if (objectValue != 3)
                {
                    Instantiate(prefabs[objectValue]);
                }
                switch (objectValue)
                {
                    case 0:
                        counter += 1;
                        if (counter == 2)
                        {
                            objectValue += 1;
                            counter = 0;
                        }
                        break;
                    case 1:
                        counter += 1;
                        if (counter == 2)
                        {
                            objectValue += 1;
                            counter = 0;
                        }
                        break;

                    case 2:
                        counter += 1;
                        if (counter == 2)
                        {
                            objectValue += 1;
                            StartCoroutine(Winning());
                        }
                        break;
                    case 3:
                        break;
                }

                break;
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