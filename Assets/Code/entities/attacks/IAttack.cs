using UnityEngine;

public interface IAttack {
    bool CanExecute();

    void Execute();

    DamageableEntity FindTarget();
}