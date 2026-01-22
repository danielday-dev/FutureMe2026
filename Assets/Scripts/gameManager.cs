using System;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private static gameManager instance;

    public static gameManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("Game manager instance is null");
            }
            return instance;
        }
    }

    public int experience = 0;
    public int level = 0;
    public int gamesToComplete = 0;
    public int daysleft = 5;
    public string[] gamesToday = { "game 1", "game 2", "game 3" };

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

}
