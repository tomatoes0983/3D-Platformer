using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopShow : MonoBehaviour
{
    public ui_manarger name;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            name.showUI();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            name.hideUI();
        }
    }
}
