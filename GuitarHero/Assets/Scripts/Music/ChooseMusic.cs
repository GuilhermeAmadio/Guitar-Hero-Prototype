using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseMusic : MonoBehaviour
{
    [SerializeField] private MusicSO music;

    [SerializeField] private MusicToPlaySO musicToPlay;

    public void Choose()
    {
        musicToPlay.SetMusic(music);
    }
}
