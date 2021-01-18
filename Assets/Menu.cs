using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject toEnable;
    public GameObject toDisable;

    private static Menu instance = null;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void OnClick()
    {
        GameObject temp = toDisable;
        toEnable.SetActive(true);
        toDisable.SetActive(false);
        gameObject.transform.Rotate(0, 0, 180);
        toDisable = toEnable;
        toEnable = temp;

    }
}
