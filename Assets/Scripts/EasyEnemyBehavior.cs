using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyEnemyBehavior : EnemyBehavior
{
    // INHERITANCE
    // Start is called before the first frame update
    [SerializeField] GameObject child;
    protected override void StartEnemy()
    {
        base.StartEnemy();
        SetColor(Color.yellow);
        points = 10;
    }

    // POLYMORPHISM
    // Update is called once per frame
    protected override void Move()
    {
        base.Move();
        child.transform.Rotate(0, 0, 45, Space.Self);
    }
}
