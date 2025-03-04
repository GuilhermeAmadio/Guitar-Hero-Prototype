using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Music", menuName = "SO/New Music")]
public class MusicSO : ScriptableObject
{
    [SerializeField] private AudioClip musicClip;
    [SerializeField] private MusicNotesSO musicNotes;
    [SerializeField] private float endMusic;

    public AudioClip GetAudioClip() 
    { 
        return musicClip; 
    }

    public MusicNotesSO GetMusicNotes()
    {
        return musicNotes;
    }

    public float GetEndMusic()
    {
        return endMusic;
    }
}
