using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject toEnable;
    public GameObject toDisable;

    public GameObject musicPlayer;

    public float volume;
    public Slider volumeSlider;

    private static Menu instance = null;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            musicPlayer = GameObject.Find("AudioListener");

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

    public void OnValueChange()
    {
        volume = volumeSlider.value;
        musicPlayer.GetComponent<AudioSource>().volume = volume;
    }
}
