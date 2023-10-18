using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;

    private Vector3 lastValidPosition;

    [SerializeField]
    private LayerMask validSurface;

    [SerializeField]
    private Transform trackingSphere;

    // -------------------------------

    private void Update() {
        PlaneCoordinate();
    }

    private void PlaneCoordinate() {
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit rayData;

        if(Physics.Raycast(ray, out rayData, 100, validSurface)) {
            lastValidPosition = rayData.point;
            
            trackingSphere.position = lastValidPosition;
        }
    }
}
