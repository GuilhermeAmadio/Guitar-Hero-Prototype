using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    [SerializeField] private FloatSO time;

    private float speed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Transform target)
    {
        CalculateSpeed(transform, target);

        Vector3 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * speed;
    }

    private void CalculateSpeed(Transform initialPos, Transform target)
    {
        float distance = Vector2.Distance(initialPos.position, target.position);
        speed = distance / time.GetValue();
    }

    public float GetSpeed()
    {
        return speed;
    }
}
