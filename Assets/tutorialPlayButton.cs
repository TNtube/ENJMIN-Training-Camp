using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialPlayButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Scene1");
    }
}
