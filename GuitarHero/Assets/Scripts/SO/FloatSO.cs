using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Float", menuName = "SO/New Float")]
public class FloatSO : ScriptableObject
{
    [SerializeField] private float value;

    public void ChangeValue(float newValue)
    {
        value = newValue;
    }

    public float GetValue()
    {
        return value;
    }
}
