using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraTown : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float offSet;

    Vector3 initialOffset;

    private void Start()
    {
        initialOffset = new Vector3(target.transform.position.x - offSet, target.transform.position.y, -10);
        transform.position = initialOffset;
    }

    private void Update()
    {
        transform.position = new Vector3 (target.transform.position.x * Time.deltaTime, target.transform.position.y, -10);
    }
}
