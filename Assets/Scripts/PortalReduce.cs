using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalReduce : MonoBehaviour
{
    private bool Size = false;

    private void Update()
    {
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player" && Size == false)
        {
            collision.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.SetActive(true);
            Size = true;
            Debug.Log("Size changed: " + Size);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player" && Size == true)
        {
            collision.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.SetActive(true);
            Size = false;
            Debug.Log("Size changed: " + Size);
        }
    /}
}
        // else
        // { 

        // Debug.Log("ahora si!");
        //
        //     collision.transform.localScale += new Vector3(1f, 1f, 1f);
        //
        // Destroy(gameObject);

        //     gameObject.SetActive(true);
        //     Switch = false;

        //    Debug.Log(Switch);

    



  

