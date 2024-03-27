using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMainMenu", 3f);
    }

    // Update is called once per frame
    private void LoadMainMenu()
    {
        GameManager.Instance.LoadMainMenu();
    }
}
