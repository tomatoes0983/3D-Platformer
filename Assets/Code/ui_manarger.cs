using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_manarger : MonoBehaviour
{
    public GameObject ShopUI;

    public void Start()
    {
        hideUI();
    }
    public void hideUI()
    {
        ShopUI.SetActive(false);
    }
    public void showUI (){
        ShopUI.SetActive(true);
    }
    public void buyJump()
    {
        if(coin.crystal >= 50)
        {
            coin.crystal -= 50;
            ability.canUSE = true;
            hideUI();
        }
    }
}
