using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private MusicToPlaySO musicToPlay;
    [SerializeField] private FloatSO speedNote;

    [SerializeField] private SpawnManager[] spawnManagers;

    [SerializeField] private MusicPlayer musicPlayer;

    private MusicSO music;
    private MusicNote[] musicNotes, copyMusicNotes;

    private bool playingSong;

    private void Start()
    {
        music = musicToPlay.GetMusic();
        musicNotes = music.GetMusicNotes().GetNotes();

        foreach (MusicNote note in musicNotes)
        {
            note.StartMusic();
        }

        StartCoroutine(WaitForStart());
    }

    private void Update()
    {
        if (playingSong)
        {
            float currentTime = musicPlayer.GetMusicTime();

            foreach (MusicNote note in musicNotes)
            {
                if (currentTime >= note.GetTime() - speedNote.GetValue() && !note.GetSpawned())
                {
                    SpawnNote(note.GetLane());

                    note.Spawn();
                }
            }
        }
    }

    public void SpawnNote(int index)
    {
        foreach (var spawnManager in spawnManagers)
        {
            spawnManager.SpawnNote(index);
        }
    }

    private IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(3);

        musicPlayer.PlayMusic(music.GetAudioClip());

        playingSong = true;
    }
}
