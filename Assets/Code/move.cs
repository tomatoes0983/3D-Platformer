using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    public int speed = 10;
    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        Destroy(gameObject,10);
    }
}
