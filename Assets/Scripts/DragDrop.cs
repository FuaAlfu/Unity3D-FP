using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.8.3
/// </summary>

public class DragDrop : MonoBehaviour
{
    private Vector3 mouseOffset;

    private float mouseZcoordinate;

    private void OnMouseDown()
    {
        mouseZcoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mouseZcoordinate;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mouseOffset;
    }
}
