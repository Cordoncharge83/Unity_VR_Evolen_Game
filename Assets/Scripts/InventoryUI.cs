using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI CoinText;
    // Vérifier le nombre de jetons acquis
    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }
    // Mettre à jour le nombre de jetons
    public void UpdateText(PlayerInventory playerInventory)
    {
        CoinText.text = playerInventory.NbrOfCoins.ToString();
    }
}
