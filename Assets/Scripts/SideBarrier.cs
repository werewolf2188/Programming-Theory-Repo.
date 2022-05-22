using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBarrier : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) {
            GameEngine.TurnMovement();
        }
    }
}
