using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ccoin : MonoBehaviour
{
    public int amount = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            coin.crystal += amount;
            Destroy(gameObject);

        }
    }
}
