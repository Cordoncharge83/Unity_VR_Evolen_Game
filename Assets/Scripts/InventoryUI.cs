using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI CoinText;
    // V�rifier le nombre de jetons acquis
    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }
    // Mettre � jour le nombre de jetons
    public void UpdateText(PlayerInventory playerInventory)
    {
        CoinText.text = playerInventory.NbrOfCoins.ToString();
    }
}
