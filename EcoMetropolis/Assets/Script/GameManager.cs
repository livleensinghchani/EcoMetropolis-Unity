using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
// Global ------------------------

    [SerializeField]
    private TextMeshProUGUI srcViewMode;

// Local --------------------------

    [SerializeField]
    private int GameState = 0; //0 = Default, 1 = Road Build, 2 = Block Build

// Function ------------------------

    public void UpdateState(int setState) {
        switch (setState) {
            case (0): {
                GameState = setState;
                srcViewMode.text = "View";
                break;
            }
            case (1): {
                GameState = setState;
                srcViewMode.text = "Build";
                break;
            }
            default : {
                Debug.LogError($"Invalid Game State Request {setState}");
                break;
            }
        }
    } 
}
