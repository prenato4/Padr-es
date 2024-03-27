using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class coinscontroller : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private static bool playerSubscribed = false; // Verifica se já nos inscrevemos no Player

    void Start()
    {
        if (!playerSubscribed)
        {
            Player.CoinsChanged += UpdateCoinDisplay;
            playerSubscribed = true;
        }

        // Certifica-se de que o componente de texto está atribuído antes de tentar atualizá-lo
        if (coinText == null)
        {
            Debug.LogError("O componente de texto não está atribuído em CoinController!");
            return;
        }

        // Atualiza o texto com as moedas atuais
        UpdateCoinDisplay(Player.coins);
    }

    void UpdateCoinDisplay(int coins)
    {
        coinText.text = "X: " + coins.ToString();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.coins++;
            Debug.Log("Número de moedas: " + Player.coins);
            Player.CoinsChanged?.Invoke(Player.coins); // Notifica os observadores sobre a mudança nas moedas
        }
    }
}
