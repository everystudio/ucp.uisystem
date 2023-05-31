using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using anogame;

public class UISystemDemo : MonoBehaviour
{
    private int index = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UIController.Instance.ClearPanels();
            UIController.Instance.AddPanel("PanelTest" + index.ToString("00"));
            index += 1;
            index %= 3;
        }
    }
}
