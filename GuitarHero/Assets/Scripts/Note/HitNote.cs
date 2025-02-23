using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{
    private GameObject note;

    private bool hitting, perfecting;

    public void PlayerHit()
    {
        if (hitting)
        {
            note.GetComponentInParent<Note>().HitNote();

            hitting = false;

            if (perfecting)
            {
                Debug.Log("Perfect!");

                perfecting = false;

                return;
            }

            Debug.Log("Hit!");
        }
        else
        {
            Debug.Log("Errou");
        }
    }

    public void Hit(GameObject note)
    {
        this.note = note;

        hitting = true;
    }

    public void NotHit()
    {
        hitting = false;
    }

    public void Perfect(bool perfect)
    {
        perfecting = perfect;
    }
}
