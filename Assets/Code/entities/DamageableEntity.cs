using UnityEngine;

public abstract class DamageableEntity : Entity {
    private float health, maxHealth;

    private bool alive = true;

    void Start() {
        this.maxHealth = GetMaxHealth();
        SetHealth(this.maxHealth);
    }

    public float GetHealth() {
        return this.health;
    }
    
    protected override void Update() {
        base.Update();
    }

    public abstract float GetMaxHealth();

    public virtual void Damage(float amount) {
        if(this.health - amount < 0) {
            this.health = 0;
            this.alive = false;
        }
    }

    public bool IsAlive() {
        return this.alive;
    }

    public virtual void Kill() {
        this.health = 0;
        this.alive = false;
    }

    public virtual void SetHealth(float health) {
        if(health > 0) {
            if(health > this.maxHealth) 
                health = this.maxHealth;
            this.health = health;
        } else {
            Kill();
        }
    }
}