using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private float initialTime;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.clip = clip;

        audioSource.Play();
        audioSource.time = initialTime;
    }

    public float GetMusicTime()
    {
        return audioSource.time;
    }
}
