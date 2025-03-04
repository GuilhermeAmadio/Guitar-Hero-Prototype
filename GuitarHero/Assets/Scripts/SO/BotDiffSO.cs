using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bot", menuName = "Player/New BotDiff")]
public class BotDiffSO : ScriptableObject
{
    [SerializeField] private BotSO bot;

    public BotSO GetBot()
    {
        return bot;
    }

    public void SetBotDiff(BotSO bot)
    {
        this.bot = bot;
    }
}
