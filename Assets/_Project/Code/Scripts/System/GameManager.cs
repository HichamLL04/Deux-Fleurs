using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    AudioManager audioManager;
    MenuManager menuManager;


    void Start()
    {
        audioManager = FindFirstObjectByType<AudioManager>();
        menuManager = FindAnyObjectByType<MenuManager>();
    }


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
