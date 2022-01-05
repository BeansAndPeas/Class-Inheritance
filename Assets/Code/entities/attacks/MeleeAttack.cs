using UnityEngine;

public class MeleeAttack : IAttack {
    private LivingEntity entity;
    private DamageableEntity target;
    private float followRange;

    public MeleeAttack(LivingEntity entity, float followRange) {
        this.entity = entity;
        this.followRange = followRange;
    }

    public bool CanExecute() {
        return this.entity.IsAlive();
    }

    public void Execute() {
        if(!this.target) {
            FindTarget();
        }
    }

    public float GetMaxRange() {
        return this.followRange;
    }

    public DamageableEntity FindTarget() {
        if(this.target) {
            float distance = (this.target.transform.position - this.entity.transform.position).sqrMagnitude;
            if(distance > this.followRange) 
                return this.target;
            this.target = null;
        }

        return this.target = Physics2D.OverlapCircle(this.entity.transform.position, this.followRange, LayerMask.NameToLayer("Entity")).gameObject.GetComponent<DamageableEntity>();
    }
}