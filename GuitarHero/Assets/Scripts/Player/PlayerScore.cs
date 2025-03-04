using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private int score, hittedNotes, perfectNotes, missedNotes;
    [SerializeField] private IntSO baseScore;

    [SerializeField] private TMPro.TextMeshPro scoreText;

    public void Scored(int amount)
    {
        score += amount;

        UpdateText();
    }

    public void Hit()
    {
        hittedNotes++;
    }

    public void Perfect()
    {
        perfectNotes++;
    }

    public void Miss()
    {
        score -= baseScore.GetValue();

        missedNotes++;

        UpdateText();
    }

    private void UpdateText()
    {
        scoreText.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHittedNotes()
    {
        return hittedNotes;
    }

    public int PerfectNotes()
    {
        return perfectNotes;
    }

    public int MissedNotes()
    {
        return missedNotes;
    }
}
