using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coordinates : MonoBehaviour
{
    public GameObject player;
    public Text coordinates;
    void Update()
    {
        coordinates.text = "x -> " + player.transform.position.x.ToString("F1") +
                                         "\ny -> " + player.transform.position.y.ToString("F1") +
                                         "\nz -> " + player.transform.position.z.ToString("F1");                                       
    }
}
