using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraTown : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float smooth;
  
    Vector3 initialOffset,currentVelocity = Vector3.zero;

    private void Start()
    {
        initialOffset = transform.position - target.transform.position;
        
    }

    private void Update()
    {
        Vector3 targetPosition = target.transform.position + initialOffset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smooth);
    }
}
