using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
// Global ------------------------------
    [SerializeField]
    private GameManager srcGameManager;

// Local -------------------------------



// Function ----------------------------

    private void Start() {
        srcGameManager = FindObjectOfType<GameManager>();
    }

    public void View() {
        // View Code is 0
        srcGameManager.UpdateState(0);
    }

    public void RoadBuild() {
        // Road Build Code is 1
        srcGameManager.UpdateState(1);
    }

    public void BlockBuild() {
        // Block Build Code is 2
        srcGameManager.UpdateState(2);
    }
}
