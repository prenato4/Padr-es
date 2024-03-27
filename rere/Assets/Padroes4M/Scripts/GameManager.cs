using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
             Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Start()
    { 
        SceneManager.LoadScene("splash");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void LoadGame()
    {
        SceneManager.LoadScene("GUI");
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Additive);
    }
}
