using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button Question1_1;
    public Button Question1_2;
    public Button Question1_3;
    public Button Question1_4;
    public Button Question2_1;
    public Button Question2_2;
    public Button Question2_3;
    public Button Question2_4;
    public Button Question3_1;
    public Button Question3_2;
    public Button Question3_3;
    public Button Question3_4;
    public PlayerInventory playerInventory;
    // Start is called before the first frame update
    void Start()
    {
        Question1_1.enabled = false;
        Question1_2.enabled = false;
        Question1_3.enabled = false;
        Question1_4.enabled = false;
        Question2_1.enabled = false;
        Question2_2.enabled = false;
        Question2_3.enabled = false;
        Question2_4.enabled = false;
        Question3_1.enabled = false;
        Question3_2.enabled = false;
        Question3_3.enabled = false;
        Question3_4.enabled = false;


    }

    void Update()
    {
        if (playerInventory.NbrOfCoins > 0)
        {
            Question1_1.enabled = true;
            Question1_2.enabled = true;
            Question1_3.enabled = true;
            Question1_4.enabled = true;
        }
        if (playerInventory.NbrOfCoins > 1)
        {
            Question2_1.enabled = true;
            Question2_2.enabled = true;
            Question2_3.enabled = true;
            Question2_4.enabled = true;
        }

        if (playerInventory.NbrOfCoins > 3)
        {
            Question3_1.enabled = true;
            Question3_2.enabled = true;
            Question3_3.enabled = true;
            Question3_4.enabled = true;
        }
    }
}
