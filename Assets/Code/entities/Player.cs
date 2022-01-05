using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : DamageableEntity {
    public override void Move() {
        float xMovement = Mathf.Clamp(MovementHandler.GetXMovement() / Time.deltaTime, -5, 5);
        this.rigidbody.AddForce(new Vector2(xMovement, MovementHandler.IsTryingToJump() && IsOnGround() ? 500f : 0f));
    }

    public override float GetMaxHealth() {
        return 20f;
    }
}
