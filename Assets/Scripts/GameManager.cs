using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int SceneValue;
    public int objectValue;
    public int counter;
    public List<GameObject> prefabs;
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
                Instantiate(prefabs[objectValue]);
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
                }

                break;
        }
    }
}