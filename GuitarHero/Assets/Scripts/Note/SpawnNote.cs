using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    [SerializeField] private GameObject notePrefab;

    [SerializeField] private Transform noteTarget;

    public void Spawn()
    {
        GameObject note = Instantiate(notePrefab, transform.position, Quaternion.identity);
        note.GetComponent<NoteMove>().Move(noteTarget);
    }
}
