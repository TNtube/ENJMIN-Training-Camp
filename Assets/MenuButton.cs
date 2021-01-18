using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public void OnClick() { GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<LevelLoader>().LoadMenu(); }
}
