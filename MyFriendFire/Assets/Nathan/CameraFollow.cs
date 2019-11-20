using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; // sets camera follow speed relative to object it is following
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = target.position + offset; // camera position is offset with player to widen visual field
    }
}
