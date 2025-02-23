using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MusicToPlay", menuName = "SO/New MusicToPlay")]
public class MusicToPlaySO : ScriptableObject
{
    [SerializeField] private MusicSO music;

    public MusicSO GetMusic()
    {
        return music;
    }
}
