using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBotDiff : MonoBehaviour
{
    [SerializeField] private BotDiffSO botDiff;

    public void SetBot(BotSO bot)
    {
        botDiff.SetBotDiff(bot);
    }
}
