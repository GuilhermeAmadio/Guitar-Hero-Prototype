using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float duration;

    public float pressingTimer;
    public bool pressing;

    [SerializeField] private NoteMove noteMove;

    [SerializeField] private Transform durationTransform;

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

    public void HitNote()
    {
        pressing = true;
        //Destroy(gameObject);
    }

    public void ReleaseNote()
    {
        pressing = false;

        Destroy(gameObject, 5f);
    }

    public void SetDuration(float newDuration)
    {
        duration = newDuration;

        SetDurationSize();
    }

    public void SetDurationSize()
    {
        durationTransform.localScale = new Vector3(durationTransform.localScale.x, durationTransform.localScale.y, duration * noteMove.GetSpeed());
        //durationTransform.position -= new Vector3((durationTransform.localScale.z / 4) * -1, durationTransform.localScale.z / 4, durationTransform.localScale.z / 2);
    }

    private void FinishNote()
    {
        Destroy(gameObject);
    }
}
