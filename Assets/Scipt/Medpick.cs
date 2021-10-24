using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medpick : MonoBehaviour
{
    public GameObject medObject;
    private float med = 0;

    public void addmed()
    {
        med++;
    }

    public void SpawnCoin()
    {
        Instantiate(medObject, new Vector3(Random.Range(-3.0f, 3.0f),0.2f, Random.Range(-3.0f, 3.0f)),Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
