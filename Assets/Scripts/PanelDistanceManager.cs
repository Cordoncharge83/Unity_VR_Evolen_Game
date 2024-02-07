using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelDistanceManager : MonoBehaviour
{

    public GameObject player;
    public GameObject PanelUI;

    // Start is called before the first frame update
    void Start()
    {
        PanelUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, this.transform.position);
        if (distance <= 4f)
        {
            PanelUI.SetActive(true);
        }
        else
        {
            PanelUI.SetActive(false);
        }
    }
}
