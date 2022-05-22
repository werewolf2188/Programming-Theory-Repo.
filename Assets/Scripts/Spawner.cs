using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] int numOfObjectsPerSide;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnObject, transform);
        GameEngine.AddToEnemyCount();
        for (int i = 0; i < numOfObjectsPerSide; i++)
        {
            GameObject go = Instantiate(spawnObject, transform);
            go.transform.position = new Vector3(go.transform.position.x + (2 * (i + 1)), go.transform.position.y, go.transform.position.z);
            GameEngine.AddToEnemyCount();
        }
        for (int i = 0; i < numOfObjectsPerSide; i++)
        {
            GameObject go = Instantiate(spawnObject, transform);
            go.transform.position = new Vector3(go.transform.position.x + (-2 * (i + 1)), go.transform.position.y, go.transform.position.z);
            GameEngine.AddToEnemyCount();
        }
    }
}
