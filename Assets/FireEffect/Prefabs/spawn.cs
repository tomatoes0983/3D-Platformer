using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject sp;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){ 
        Instantiate(sp, gameObject.transform.position,gameObject.transform.rotation);
        }
    }
}
