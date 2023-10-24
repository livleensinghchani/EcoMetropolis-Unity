using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectList : MonoBehaviour
{

// Local -------------------------------

    private Dictionary<Vector3Int, string> DBuildIndex = new Dictionary<Vector3Int, string>();

// Function -----------------------------

    private void Start() {
        
    }

    public bool GetLocationIndex(Vector3Int locationData) {
        
        if(DBuildIndex.ContainsKey(locationData)) {
            return false;
        }
        else {
            return true;
        }
    }

    public void SetLocationIndex(Vector3Int locationData, string objectName) {
        DBuildIndex.Add(locationData, objectName);
    }

}
