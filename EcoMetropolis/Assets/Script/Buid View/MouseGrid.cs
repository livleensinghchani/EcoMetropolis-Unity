using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGrid : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    private Vector3 lastValidPoint;

    [SerializeField]
    private LayerMask targetMask;

    [SerializeField]
    private Transform mousePointer;

    // -----------------------------

    private void Update() {
        GridSelect();
    }

    private void GridSelect() {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit rayHit;
        if(Physics.Raycast(ray, out rayHit, 100, targetMask))
        {
            lastValidPoint = rayHit.point;
        }
        
        mousePointer.position = lastValidPoint;
    }
}
