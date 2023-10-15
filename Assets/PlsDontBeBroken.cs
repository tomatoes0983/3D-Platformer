using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlsDontBeBroken : MonoBehaviour
{
    public int speed = 10;
    public Transform Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.position);
        transform.position = Vector3.MoveTowards(transform.position, Player.position, speed*Time.deltaTime);
    }
}
