using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CallFunctionOnTrigger : MonoBehaviour
{
    [SerializeField] private string tagToCollide;

    [SerializeField] private UnityEvent<GameObject> onEnter, onExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagToCollide))
        {
            onEnter?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(tagToCollide))
        {
            onExit?.Invoke(other.gameObject);
        }
    }
}
