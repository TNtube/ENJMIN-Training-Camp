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
    public AudioSource source;

    public void ReloadCurrentLevel()
    {
        source.PlayScheduled(0f);
        StartCoroutine(PlaySecondWoosh());
        transitionDefeat.SetTrigger("Start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }

    public IEnumerator PlaySecondWoosh()
    {
        yield return new WaitForSeconds(0.4f);
        source.Play();
    }

    public void LoadNextLevel()
    {
        source.PlayScheduled(0f);
        transition.SetTrigger("Start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadCredits()
    {
        source.PlayScheduled(0f);
        transition.SetTrigger("Start");
        StartCoroutine(LoadLevel(10));
    }

    public void LoadMenu()
    {
        source.PlayScheduled(0f);
        transition.SetTrigger("Start");
        StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);
    }
}