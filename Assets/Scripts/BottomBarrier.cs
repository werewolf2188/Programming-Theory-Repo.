using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBarrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameEngine.IsLose = true;
        }
    }
}
