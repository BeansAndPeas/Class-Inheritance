using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {
    protected new Rigidbody2D rigidbody;
    private bool onGround;

    public bool IsOnGround() {
        return this.onGround;
    }

    void Start() {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        Move();
    }

    protected virtual string GetName() {
        return "Entity";
    }

    public virtual void Move() {

    }

    protected virtual void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) this.onGround = true;
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) this.onGround = false;
    }
}
