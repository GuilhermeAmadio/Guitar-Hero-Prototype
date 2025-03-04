using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    [SerializeField] private GameResult[] gameResults;

    [SerializeField] private PlayerScore[] playersScore;

    private void Awake()
    {
        instance = this;
    }

    public void Result()
    {
        int bestScore = 0;
        int bestPlayerIndex = 0;

        for (int i = 0; i < playersScore.Length; i++)
        {
            int score = playersScore[i].GetScore();
            int notes = playersScore[i].GetHittedNotes();
            int perfect = playersScore[i].PerfectNotes();
            int missed = playersScore[i].MissedNotes();
            gameResults[i].Result(i + 1, score, notes, perfect, missed);

            if (score > bestScore)
            {
                bestScore = score;
                bestPlayerIndex = i;
            }
            else if (score == bestScore)
            {
                //draw
            }
        }

        gameResults[0].Winner(bestPlayerIndex);
    }
}
