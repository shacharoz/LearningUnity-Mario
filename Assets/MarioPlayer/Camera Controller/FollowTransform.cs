using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    public Transform TargetTransform;

    public bool ChangeXAxis = true;
    public bool ChangeYAxis = true;
    public bool ChangeZAxis = true;

    public float offsetX;
    public float offsetY;
    public float offsetZ;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        Vector3 newPosition = transform.position;

        if (ChangeXAxis)
            newPosition.x = TargetTransform.position.x + offsetX;
        if (ChangeYAxis)
            newPosition.y = TargetTransform.position.y + offsetY;
        if (ChangeZAxis)
            newPosition.z = TargetTransform.position.z + offsetZ;

        transform.position = newPosition;
    }
}