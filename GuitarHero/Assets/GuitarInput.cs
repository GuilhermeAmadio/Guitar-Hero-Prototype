using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GuitarInput : MonoBehaviour
{
    [SerializeField] private InputHandler[] inputHandlers;
    [SerializeField] private int playerIndex;

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    public void Key0(InputAction.CallbackContext context)
    {
       inputHandlers[0].Key(context);
    }

    public void Key1(InputAction.CallbackContext context)
    {
        inputHandlers[1].Key(context);
    }

    public void Key2(InputAction.CallbackContext context)
    {
        inputHandlers[2].Key(context);
    }

    public void Key3(InputAction.CallbackContext context)
    {
        inputHandlers[3].Key(context);
    }
}
