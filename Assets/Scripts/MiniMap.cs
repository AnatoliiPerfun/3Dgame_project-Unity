using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MiniMap : MonoBehaviour
{

    public Transform p1;

    void LateUpdate()
    {
        Vector3 newPosition = p1.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        transform.rotation = Quaternion.Euler(90f, p1.eulerAngles.y, 0f);
    }
}
