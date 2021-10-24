using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    Rigidbody rb;
    float newRotY = 0;
    public float rotSpeed = 20f;
    public GameObject prefabBullet;
    public Transform gunPosition;
    public float gunPower = 15f;

    public int medCount = 0;
    public Text  uiTextmed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //บน ล่าง
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed, ForceMode.VelocityChange);
            newRotY = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -speed, ForceMode.VelocityChange);
            newRotY = 180;
        }
        //ซ้าย ขวา
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed, 0, 0, ForceMode.VelocityChange);
            newRotY = 90;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0, 0, ForceMode.VelocityChange);
            newRotY = -90;
        }



        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, newRotY, 0),
                          transform.rotation,
                          rotSpeed);
    }

    private void Update()
    {
        //ยิงปืน
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject bullet = Instantiate(prefabBullet, gunPosition.position, gunPosition.rotation);
            //bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 15f, ForceMode.Impulse);
            Rigidbody bRb = bullet.GetComponent<Rigidbody>();
            bRb.AddForce(transform.forward * gunPower, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            medCount++;
            uiTextmed.text = medCount.ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gun")
        {
            Destroy(other.gameObject);
            print("I have a gun");
        }
    }
}

