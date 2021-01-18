using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource source;
    private void WooshPlay()
    {
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
