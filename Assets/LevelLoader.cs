using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public Animator transitionDefeat;
    public Image image;

    public void ReloadCurrentLevel()
    {
        transitionDefeat.SetTrigger("Start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }

    public void LoadNextLevel()
    {
        transition.SetTrigger("Start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadCredits()
    {
        transition.SetTrigger("Start");
        StartCoroutine(LoadLevel(10));
    }

    public void LoadMenu()
    {
        transition.SetTrigger("Start");
        StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);
    }
}