using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ability : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject ball;
    public int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            rb.AddForce(0, speed,0, ForceMode.Impulse);
            ball.SetActive(true);
        }
    }
}
