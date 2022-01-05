using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : LivingEntity {
    protected override string GetName() {
        return "Dragon";
    }

    public override float GetMaxHealth() {
        return 100f;
    }

    protected override IAttack GetAttack() {
        return new MeleeAttack(this, 10f);
    }
}
