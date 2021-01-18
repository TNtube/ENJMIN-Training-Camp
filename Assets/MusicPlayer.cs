using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    public int currentScene;
    public AudioSource source;
    public List<AudioClip> musicList;
    private static GameObject instance = null;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this.gameObject;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        AudioClip toPlay;
        switch (currentScene)
        {
            case 0:
                toPlay = musicList[0];
                if (!source.isPlaying)
                {
                    source.clip = toPlay;
                    source.PlayScheduled(0f);
                }
                break;
            case 1:
                toPlay = musicList[1];
                if (!source.isPlaying)
                {
                    source.clip = toPlay;
                    source.PlayScheduled(0f);
                }
                source.clip = musicList[1];
                break;
            case 4:
                toPlay = musicList[2];
                if (!source.isPlaying)
                {
                    source.clip = toPlay;
                    source.PlayScheduled(0f);
                }
                source.clip = musicList[2];
                break;

            case 7:
                toPlay = musicList[3];
                if (!source.isPlaying)
                {
                    source.clip = toPlay;
                    source.PlayScheduled(0f);
                }
                source.clip = musicList[3];
                break;
            case 10:
                toPlay = musicList[4];
                if (!source.isPlaying)
                {
                    source.clip = toPlay;
                    source.PlayScheduled(0f);
                }
                source.clip = musicList[4];
                break;
            default:
                break;

        }
    }
}
