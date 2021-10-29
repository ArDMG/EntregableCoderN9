using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalReduce : MonoBehaviour
{
    private bool Size = false;
    private bool on = true;

    private void Update()
    {
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player" && Size == false)
        {
            collision.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.SetActive(on);
            Size = true;
            on = true;
            Debug.Log(Size);
            Debug.Log(on);
            //Debug.Log("Size changed: " + Size);
        }
        else if (collision.gameObject.name == "Player" && Size == true)
        {
            on = false;
            collision.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.SetActive(on);
            Size = false;
            Debug.Log("Size changed: " + Size);
        }
    }
}

    



  

