using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    [SerializeField] private GameObject notePrefab;

    [SerializeField] private Transform noteTarget;

    public void Spawn(MusicNote note)
    {
        GameObject noteObj = Instantiate(notePrefab, transform.position, Quaternion.identity);
        noteObj.GetComponent<NoteMove>().Move(noteTarget);
        noteObj.GetComponent<Note>().SetDuration(note.GetDuration());
    }
}
