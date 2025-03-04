using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Rendering;

public class BotPlayer : MonoBehaviour
{
    [SerializeField] private BotDiffSO botDiff;
    private float hitChance, perfectChance;

    [SerializeField] private HitNote[] hitNotes;
    [SerializeField] private bool activated;

    private bool perfectHit;

    private void Start()
    {
        if (botDiff != null)
        {
            BotSO bot = botDiff.GetBot();

            hitChance = bot.GetHitChance();
            perfectChance = bot.GetPerfectChance();
        }
    }

    public void NormalHit(int lane)
    {
        if (!activated)
        {
            return;
        }

        if (Chance(perfectChance))
        {
            perfectHit = true;
            return;
        }

        if (Chance(hitChance))
        {
            Hit(lane);
        }
    }

    public void PerfectHit(int lane)
    {
        if (!activated)
        {
            return;
        }

        if (perfectHit)
        {
            Hit(lane);
        }
    }

    private void Hit(int lane)
    {
        hitNotes[lane].PlayerHit();

        Note note = hitNotes[lane].GetNote();
        float duration = note.GetDuration();
        StartCoroutine(LongHit(lane, duration));
    }

    private bool Chance(float chance)
    {
        float randomNumber = Random.Range(0, 100);
        if (randomNumber <= chance)
        {
            return true;
        }
        return false;
    }

    private IEnumerator LongHit(int lane, float duration)
    {
        hitNotes[lane].Pressing(true);

        yield return new WaitForSeconds(duration);

        hitNotes[lane].Pressing(false);
    }
}
