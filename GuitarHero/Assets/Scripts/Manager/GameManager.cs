using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private MusicToPlaySO musicToPlay;
    [SerializeField] private FloatSO speedNote;

    [SerializeField] private SpawnManager[] spawnManagers;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject[] press, ready;

    [SerializeField] private MusicPlayer musicPlayer;

    private MusicSO music;
    private MusicNote[] musicNotes;

    private bool playingSong;
    private float endMusic;
    [SerializeField] private int numberOfPlayers;

    private void Start()
    {
        music = musicToPlay.GetMusic();
        musicNotes = music.GetMusicNotes().GetNotes();
        endMusic = music.GetEndMusic();

        foreach (MusicNote note in musicNotes)
        {
            note.StartMusic();
        }
    }

    public void StartGame()
    {
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
                    SpawnNote(note);

                    note.Spawn();
                }
            }

            if (currentTime >= endMusic)
            {
                PlayerManager.instance.Result();
            }
        }
    }

    public void SpawnNote(MusicNote note)
    {
        for (int i = 0; i < numberOfPlayers; i++) 
        {
            spawnManagers[i].SpawnNote(note);
        }
    }

    public void NewPlayer()
    {
        if (press != null)
        {
            press[numberOfPlayers].SetActive(false);
            ready[numberOfPlayers].SetActive(true);
        }

        numberOfPlayers++;

        if (numberOfPlayers == 2)
        {
            StartGame();
        }
    }

    private IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(2);

        if (panel != null)    
            panel.SetActive(false);

        musicPlayer.PlayMusic(music.GetAudioClip());

        playingSong = true;
    }
}
