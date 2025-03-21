using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{
    [SerializeField] private GameObject pressed, flame;

    [SerializeField] private PlayerScore playerScore;

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
            note.GetComponentInParent<Note>().HitNote(this, perfecting);

            playerScore.Hit();

            hitting = false;

            if (perfecting)
            {
                playerScore.Perfect();

                StartCoroutine(Flame());

                perfecting = false;

                return;
            }
        }
        else
        {
            playerScore.Miss();
        }
    }

    public void Scored(int amount)
    {
        playerScore.Scored(amount);
    }

    public void Miss()
    {
        playerScore.Miss();
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

    public Note GetNote()
    {
        return note.GetComponentInParent<Note>();
    }

    private IEnumerator Flame()
    {
        flame.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        flame.SetActive(false);
    }
}
