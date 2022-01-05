using System;
using UnityEngine;

public abstract class LivingEntity : DamageableEntity {
    protected IAttack attack;

    void Start() {
        base.Start();
        this.attack = GetAttack();
    }

    protected virtual IAttack GetAttack() {
        return null;
    }

    public bool IsPassive() {
        return this.attack == null;
    }

    protected override void Update() {
        base.Update();
        if(!IsPassive()) {
            if(this.attack.CanExecute()) {
                this.attack.Execute();
            }
        }
    }
}