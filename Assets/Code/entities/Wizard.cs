using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : DamageableEntity {
    protected override string GetName() {
        return "Wizard";
    }

    public override float GetMaxHealth() {
        return 20f;
    }
}
