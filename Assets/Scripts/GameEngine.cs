using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    private static Vector3 moveTo = Vector3.left;
    private static int numberOfEnemies = 1;
    private static float numberOfEnemiesInScreen = 0;
    private static float points = 0;

    [SerializeField] TMPro.TextMeshProUGUI pointsLabel;
    [SerializeField] TMPro.TextMeshProUGUI gameOverLabel;

    private static GameEngine Instance;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public static Vector3 MoveTo
    {
        get { return moveTo; }
    }

    public static float UpdateTime
    {
        get
        {
            return numberOfEnemiesInScreen / numberOfEnemies;
        }
    }

    // ENCAPSULATION
    public static bool GameOver
    {
        get { return IsLose || IsWin; }
    }

    // ENCAPSULATION
    public static bool IsWin
    { 
        get
        {
            return ((int)numberOfEnemiesInScreen) == 0;
        }
    }

    // ENCAPSULATION
    private static bool isLose = false;
    public static bool IsLose
    {
        get
        {
            return isLose;
        }
        set
        {
            isLose = value;
            if (GameOver)
            {
                SetGameState();
            }
        }
    }

    public static void TurnMovement()
    {
        if (moveTo == Vector3.left)
        {
            moveTo = Vector3.right;
        }
        else if (moveTo == Vector3.right)
        {
            moveTo = Vector3.left;
        }
    }

    // ABSTRACTION
    public static void AddToEnemyCount() {
        numberOfEnemies++;
        numberOfEnemiesInScreen++;

    }

    // ABSTRACTION
    // POLYMORPHISM
    public static void RemoveEnemy(EnemyBehavior enemy)
    {
        numberOfEnemiesInScreen--;
        points += enemy.Points;
        Instance.pointsLabel.text = "Points: " + points;
        if (GameOver)
        {
            SetGameState();
        }
    }

    private static void SetGameState()
    {
        Instance.gameOverLabel.text = "Game Over. ";
        if (IsWin)
            Instance.gameOverLabel.text += "You win.";
        else if (IsLose)
            Instance.gameOverLabel.text += "You lose.";
        Instance.gameOverLabel.gameObject.SetActive(true);
    }
}
