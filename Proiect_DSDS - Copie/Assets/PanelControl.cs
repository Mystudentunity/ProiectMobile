using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    private bool active = false;
    public GameObject panel;
    public GameObject button;
    public GameObject move;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && active == false)
        {
            panel.SetActive(true);
            button.SetActive(false);
            move.GetComponent<move>().enabled = false;
            active = true;
        }
    }

    public void Menu()
    {
        if (!active)
        {
            panel.SetActive(true);
            button.SetActive(false);
            move.GetComponent<move>().enabled = false;
            active = true;
        }
    }

    public void Resume()
    {
        panel.SetActive(false);
        button.SetActive(true);
        move.GetComponent<move>().enabled = true;
        active = false;
    }
}
