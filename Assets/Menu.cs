using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject toEnable;
    public GameObject toDisable;

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
