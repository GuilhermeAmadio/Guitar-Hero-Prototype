using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNewMode : MonoBehaviour
{
    [SerializeField] private StringSO mode;

    public void NewMode(string newMode)
    {
        mode.SetString(newMode);
    }
}
