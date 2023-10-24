using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMode : MonoBehaviour
{
// Global ----------------------------

    ObjectList srcObjectList;

// Local -----------------------------

    [SerializeField]
    private Vector3 lastValidLocation;

    [SerializeField]
    private Vector3Int lastValidCell;

    [SerializeField]
    private Camera srcCamera;

    [SerializeField]
    private LayerMask targetMask;

[Space(10)]

    [SerializeField]
    private Grid floorGrid; 

[Space(10)]

    [SerializeField]
    private GameObject defaultRoad;

// Function --------------------------

    private void Start() {
        srcObjectList = FindObjectOfType<ObjectList>();
    }

    private void Update() {
        MouseTrack();
    }

    private void MouseTrack() {
        Ray ray = srcCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit rayData;

        if(Physics.Raycast(ray, out rayData, 100, targetMask)) {
            lastValidLocation = rayData.point;

            defaultRoad.transform.position = floorGrid.WorldToCell(lastValidLocation);
            lastValidCell = floorGrid.WorldToCell(lastValidLocation);

            MouseInput();
        }
    }

    private void MouseInput() {
        if(Input.GetMouseButton(0)) {
            if(srcObjectList.GetLocationIndex(lastValidCell)) {
                GameObject gameObject = Instantiate(defaultRoad, lastValidCell, Quaternion.identity);
                srcObjectList.SetLocationIndex(lastValidCell, gameObject, 1);
            }
        }
        else if(Input.GetMouseButton(1)) {
            if(!srcObjectList.GetLocationIndex(lastValidCell)) {
                srcObjectList.SetLocationIndex(lastValidCell, gameObject, 0);
            }
        }
    }
}
