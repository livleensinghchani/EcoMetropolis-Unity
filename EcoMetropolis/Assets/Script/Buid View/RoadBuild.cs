using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBuild : MonoBehaviour
{
// Global ----------------------------

    

// Local -----------------------------

    [SerializeField]
    private Vector3 lastValidLocation;

    [SerializeField]
    private Camera srcCamera;

    [SerializeField]
    private LayerMask targetMask;

[Space(10)]

    [SerializeField]
    private Grid floorGrid; 

[Space(10)]

    [SerializeField]
    private Transform defaultRoad;

// Function --------------------------

    private void Update() {
        MouseTrack();
    }

    private void MouseTrack() {
        Ray ray = srcCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit rayData;

        if(Physics.Raycast(ray, out rayData, 100, targetMask)) {
            lastValidLocation = rayData.point;

            defaultRoad.position = floorGrid.WorldToCell(lastValidLocation);
        }
    }
}
