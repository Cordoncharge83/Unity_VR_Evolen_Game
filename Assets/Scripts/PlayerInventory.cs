using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NbrOfCoins { get; private set; }

    public UnityEvent<PlayerInventory> OnCoinCollected;

    public void CoinCollected ()
    {
        NbrOfCoins++;
        OnCoinCollected.Invoke(this);
    }

}
