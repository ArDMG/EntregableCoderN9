using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChanger : MonoBehaviour
{
    private bool Size = false;
    private Vector3 positionWall = new Vector3(-3f, 2f, 3f);
    public float degrees = 90;

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "WallChange" && Size == false)
        {
            collision.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.SetActive(true);
            Size = true;
            Debug.Log("Size changed: " + Size);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 to = new Vector3(0, degrees, 0);
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {

            transform.position = positionWall;
            transform.Rotate(to);
            //Destroy(collision.gameObject);
        }

    }
}
