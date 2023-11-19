using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class trap : MonoBehaviour
{
    public Slider bauls;
    private void Start()
    {
        bauls = GameObject.Find("Slider").GetComponent<Slider>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            bauls.value = 0;
            SceneManager.LoadScene(0);
        }
    }
}
