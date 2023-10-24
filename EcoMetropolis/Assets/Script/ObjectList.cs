using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectList : MonoBehaviour
{

// Local -------------------------------

    private Dictionary<Vector3Int, GameObject> DBuildIndex = new Dictionary<Vector3Int, GameObject>();

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

    public void SetLocationIndex(Vector3Int locationData, GameObject gameObject, int input) {
        if(input == 1) {
            DBuildIndex.Add(locationData, gameObject);
        }
        else if(input == 0) {
            Destroy(DBuildIndex[locationData]);
            DBuildIndex.Remove(locationData);
        }
    }

}
