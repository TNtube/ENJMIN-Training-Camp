using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : MonoBehaviour
{
    public void OnClick() { GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<LevelLoader>().LoadCredits(); }
}
