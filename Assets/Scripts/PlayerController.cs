using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 10.0f;
    [SerializeField] GameObject bulletPositioner;
    [SerializeField] GameObject bullet;
    private float limit = 8;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEngine.GameOver)
        {
            return;
        }

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);
        if (transform.position.x > limit || transform.position.x < -limit)
        {
            float sign = Mathf.Sign(transform.position.x);
            transform.position = new Vector3(limit * sign, transform.position.y, -1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, bulletPositioner.transform.position, bullet.transform.rotation);
        }
    }
}
