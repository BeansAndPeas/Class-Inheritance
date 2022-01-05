using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler {
    public static float GetXMovement() {
        return Input.GetAxis("Horizontal");
    }

    public static float GetYMovement() {
        return Input.GetAxis("Vertical");
    }

    public static bool IsTryingToJump() {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
