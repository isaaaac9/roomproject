using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript : MonoBehaviour
{
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        print(count + "Hello update");
        count++;
    }
}
