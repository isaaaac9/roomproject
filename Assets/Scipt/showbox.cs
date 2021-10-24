using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showbox : MonoBehaviour
{
    public GameObject BoxObjective;
    // Start is called before the first frame update
    void Start()
    {
        BoxObjective.SetActive(false);
    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            BoxObjective.SetActive(true);
            StartCoroutine("WaitForSec");

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1200);
        Destroy(BoxObjective);
        Destroy(gameObject);
    }
}
