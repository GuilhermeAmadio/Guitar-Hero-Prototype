using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int", menuName = "SO/New Int")]
public class IntSO : ScriptableObject
{
    [SerializeField] private int value;

    public void ChangeValue(int newValue)
    {
        value = newValue;
    }

    public int GetValue()
    {
        return value;
    }
}
