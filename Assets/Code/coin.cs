using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coin : MonoBehaviour
{
    public static int crystal = 0;
    public TextMeshProUGUI coinText;
    // Start is called before the first frame update
    void Start()
    {
        coinText = GameObject.Find("cristal text").GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = crystal.ToString();
    }
}
