using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enermy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

    }
}
