using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : DamageableEntity {
    protected override string GetName() {
        return "Orc";
    }

    public override float GetMaxHealth() {
        return 40f;
    }
}
