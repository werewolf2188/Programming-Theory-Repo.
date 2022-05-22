using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumEnemyBehavior : EnemyBehavior
{
    // INHERITANCE
    // Start is called before the first frame update
    [SerializeField] GameObject child;
    protected override void StartEnemy()
    {
        base.StartEnemy();
        SetColor(Color.blue);
        points = 20;
    }

    // POLYMORPHISM
    // Update is called once per frame
    protected override void Move()
    {
        base.Move();
        child.transform.Rotate(0, 0, 30, Space.Self);
    }
}
