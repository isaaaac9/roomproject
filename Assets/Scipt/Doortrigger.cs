using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    public Doorcontrol door;
    public bool playerStay;
    public GameObject txtToDisplay;

    private void Start()
    {
        playerStay = false;
        txtToDisplay.SetActive(false);
    }
    private void Update()
    {
        if (playerStay && Input.GetKeyDown(KeyCode.E))
        {
            door.doorOpen = !door.doorOpen;
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        txtToDisplay.SetActive(true);
        playerStay = true;


    }
    private void OnTriggerExit(Collider other)
    {
        txtToDisplay.SetActive(false);
        playerStay = false;

    }
}
