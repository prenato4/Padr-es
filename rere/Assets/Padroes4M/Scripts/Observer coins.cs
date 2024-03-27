using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Observercoins : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    void Start()
    {
        Player player = FindObjectOfType<Player>();
        Player.CoinsChanged += UpdateCoinDisplay;
        UpdateCoinDisplay(Player.coins);
    }

    void UpdateCoinDisplay(int coins)
    {
        coinText.text = "X: " + coins.ToString();
    }
}
