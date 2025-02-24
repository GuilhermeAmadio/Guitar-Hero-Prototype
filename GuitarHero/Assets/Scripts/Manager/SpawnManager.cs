using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private SpawnNote[] spawnNotes;

    public void SpawnNote(MusicNote note)
    {
        spawnNotes[note.GetLane()].Spawn(note);
    }
}
