using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float WaitCount = 0f;
    public float WTime = 0.92f;
    public GameObject sp;
    private void Update()
    {
        WaitCount -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E) && WaitCount <=0){
            WaitCount = WTime;
        Instantiate(sp, gameObject.transform.position,gameObject.transform.rotation);
        }
    }
}
