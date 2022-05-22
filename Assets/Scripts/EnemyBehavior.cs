using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // INHERITANCE
    private float delta = 0;
    private Vector3 previousMove;

    protected int points = 0;
    protected Color color;

    public int Points
    {
        get
        {
            return points;
        }
    }

    protected void SetColor(Color c)
    {
        Renderer renderer = GetComponentInChildren<Renderer>();
        renderer.material.SetColor("_Color", c);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEngine.GameOver)
        {
            return;
        }

        delta += Time.deltaTime;
        if (delta > GameEngine.UpdateTime)
        {
            delta = 0;
            Move();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameEngine.RemoveEnemy(this);
        }
    }

    virtual protected void StartEnemy()
    {
        previousMove = GameEngine.MoveTo;
    }

    virtual protected void Move()
    {
        if (previousMove != GameEngine.MoveTo)
        {
            transform.Translate(Vector3.down);
        }
        else transform.Translate(GameEngine.MoveTo);
        
        previousMove = GameEngine.MoveTo;
    }
}
