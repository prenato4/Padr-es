using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void PLayGame()
    {
        GameManager.Instance.LoadGame();
    }
}
