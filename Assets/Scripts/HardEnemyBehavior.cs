using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemyBehavior : EnemyBehavior
{
    // INHERITANCE
    // Start is called before the first frame update
    [SerializeField] GameObject child;
    protected override void StartEnemy()
    {
        base.StartEnemy();
        SetColor(Color.red);
        points = 30;
    }

    // POLYMORPHISM
    // Update is called once per frame
    protected override void Move()
    {
        base.Move();
        child.transform.Rotate(0, 0, 15, Space.Self);
    }
}
