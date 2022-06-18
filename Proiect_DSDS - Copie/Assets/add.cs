using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class add : MonoBehaviour
{

    public Text buttonText;
    public GameObject player;
    private GameObject instance;

    private void Start()
    {
        instance = player;

    }

    public void Add()
    {
        Vector3 vector = new Vector3(0, 5.08f, 0);

        if (buttonText.text == "Instantiate")
        {
            buttonText.text = "Destroy";
            Instantiate(instance);
        }
        if(buttonText.text == "Destroy")
        {
            buttonText.text = "Instantiate";
            Destroy(player);
        }
    }
}
