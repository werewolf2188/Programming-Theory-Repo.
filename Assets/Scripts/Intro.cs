using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameEngine.Restart();
        }
        SceneManager.LoadScene(1);
    }
}
