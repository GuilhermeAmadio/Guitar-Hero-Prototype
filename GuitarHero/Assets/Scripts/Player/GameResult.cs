using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResult : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI winner, playerName, score, notes, perfect, miss;
    [SerializeField] private GameObject panel, menuButton;

    public void Result(int playerIndex, int playerScore, int hittedNotes, int playerPerfect, int playerMiss)
    {
        playerName.text = "Player " + playerIndex;

        score.text = "Score: " + playerScore;

        notes.text = "Hitted Notes: " + hittedNotes;

        perfect.text = "Perfected Notes: " + playerPerfect;

        miss.text = "Missed Notes: " + playerMiss;

        panel.SetActive(true);
    }

    public void Winner(int playerIndex)
    {
        playerIndex += 1;
        winner.text = "Player " + playerIndex + " won!";

        menuButton.SetActive(true);
    }
}
