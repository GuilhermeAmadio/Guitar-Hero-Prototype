using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bot", menuName = "Player/New Bot")]
public class BotSO : ScriptableObject
{
    [SerializeField] private float hitChance, perfectChance;

    public float GetHitChance()
    {
        return hitChance;
    }

    public float GetPerfectChance()
    {
        return perfectChance;
    }
}
