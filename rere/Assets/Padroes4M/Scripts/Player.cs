using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Serialize] public static int coins = 0;
    public static Action<int> CoinsChanged; // Evento para notificar sobre mudanças nas moedas

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            coins++;
            Debug.Log("Número de moedas: " + coins);
            CoinsChanged?.Invoke(coins); // Notifica os observadores sobre a mudança nas moedas
        }
    }

    public void RegsiterJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("apertou o pulo");
        }
    }
    
    public void RegsiterMove(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        Debug.Log("moveu: " +direction);
    }
    
}
