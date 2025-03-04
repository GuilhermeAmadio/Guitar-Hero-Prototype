using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private float duration;

    [SerializeField] private float pressingTimer;
    [SerializeField] private bool pressing;

    [SerializeField] private IntSO baseScore, baseBonusScore;

    [SerializeField] private float noteScale;
    [SerializeField] private NoteMove noteMove;

    [SerializeField] private Transform sprite, durationTransform;

    private bool perfect;
    private int bonusScore;
    private HitNote hitNote;

    private void Update()
    {
        if (pressing)
        {
            pressingTimer += Time.deltaTime;

            if (pressingTimer >= duration)
            {
                FinishNote();
            }
        }
    }

    public void HitNote(HitNote hitNote, bool perfect)
    {
        pressing = true;

        this.hitNote = hitNote;
        this.perfect = perfect;
    }

    public void ReleaseNote()
    {
        pressing = false;

        if (pressingTimer < duration)
        {
            hitNote.Miss();
        }

        Destroy(gameObject, 5f);
    }

    public void SetRotation(float x, float y, float z)
    {
        sprite.rotation = Quaternion.Euler(x, y, z);
        durationTransform.rotation = Quaternion.Euler(-x, y, z);
    }

    public void SetDuration(float newDuration)
    {
        duration = newDuration;
        bonusScore = baseBonusScore.GetValue() * (int)duration;

        SetDurationSize();
    }

    public void SetDurationSize()
    {
        float length = duration * noteMove.GetSpeed() * noteScale;

        durationTransform.localScale = new Vector3(durationTransform.localScale.x, durationTransform.localScale.y, length);

        Vector3 moveDirection = durationTransform.TransformDirection(Vector3.forward * length / 2.8f);
        durationTransform.position += moveDirection;
    }

    public float GetDuration()
    {
        return duration;
    }

    private void FinishNote()
    {
        hitNote.Scored(baseScore.GetValue() + bonusScore);

        if (perfect)
        {
            hitNote.Scored(baseScore.GetValue());
        }

        Destroy(gameObject);
    }
}
