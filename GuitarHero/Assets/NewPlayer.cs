using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayer : MonoBehaviour
{
    private GuitarInput guitar;
    private PlayerInput playerInput;

    private int playerIndex;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerIndex = playerInput.playerIndex;

        GuitarInput[] guitars = FindObjectsOfType<GuitarInput>();
        guitar = guitars.FirstOrDefault(g => g.GetPlayerIndex() == playerIndex);
    }

    public void PlayGuitar0(InputAction.CallbackContext context)
    {
        guitar.Key0(context);
    }

    public void PlayGuitar1(InputAction.CallbackContext context)
    {
        guitar.Key1(context);
    }

    public void PlayGuitar2(InputAction.CallbackContext context)
    {
        guitar.Key2(context);
    }

    public void PlayGuitar3(InputAction.CallbackContext context)
    {
        guitar.Key3(context);
    }
}
