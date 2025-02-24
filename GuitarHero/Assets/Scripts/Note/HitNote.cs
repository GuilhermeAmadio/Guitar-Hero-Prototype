using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{
    [SerializeField] private GameObject pressed, flame;

    private GameObject note;

    private bool hitting, perfecting, pressing;

    private void Update()
    {
        if (pressing && !pressed.activeSelf)
        {
            pressed.SetActive(true);
        }
        else if (!pressing && pressed.activeSelf)
        {
            pressed.SetActive(false);
        }
    }

    public void PlayerHit()
    {
        if (hitting)
        {
            note.GetComponentInParent<Note>().HitNote();

            hitting = false;

            if (perfecting)
            {
                Debug.Log("Perfect!");

                StartCoroutine(Flame());

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

    public void Pressing(bool press)
    {
        pressing = press;

        if (!press && note != null) 
        {
            note.GetComponentInParent<Note>().ReleaseNote();
        }
    }

    private IEnumerator Flame()
    {
        flame.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        flame.SetActive(false);
    }
}
