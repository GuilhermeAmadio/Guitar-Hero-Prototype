using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "String", menuName = "SO/New String")]
public class StringSO : ScriptableObject
{
    [SerializeField] private string s;

    public string GetString()
    {
        return s;
    }

    public void SetString(string newString)
    {
        s = newString;
    }
}
