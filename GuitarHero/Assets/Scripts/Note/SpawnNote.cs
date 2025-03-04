using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    [SerializeField] private GameObject notePrefab;

    [SerializeField] private Transform noteTarget;

    [SerializeField] private float y;

    public void Spawn(MusicNote note)
    {
        GameObject noteObj = Instantiate(notePrefab, transform.position, Quaternion.identity);
        noteObj.GetComponent<Note>().SetRotation(25, y, 0);
        noteObj.GetComponent<NoteMove>().Move(noteTarget);
        noteObj.GetComponent<Note>().SetDuration(note.GetDuration());
    }
}
