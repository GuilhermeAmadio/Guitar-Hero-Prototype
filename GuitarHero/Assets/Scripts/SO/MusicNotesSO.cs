using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MusicNotes", menuName = "SO/New Music Note")]
public class MusicNotesSO : ScriptableObject
{
    [SerializeField] private MusicNote[] musicNotes;

    public MusicNote[] GetNotes()
    {
        return musicNotes;
    }
}

[System.Serializable]
public class MusicNote
{
    public float time;
    public int lane;

    private bool spawned;

    public bool GetSpawned()
    {
        return spawned;
    }

    public float GetTime()
    {
        return time;
    }

    public int GetLane()
    {
        return lane;
    }

    public void Spawn()
    {
        spawned = true;
    }

    public void StartMusic()
    {
        spawned = false;
    }
}
