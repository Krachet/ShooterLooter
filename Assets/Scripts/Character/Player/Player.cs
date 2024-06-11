using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : Character
{
    public int totalCoins;  
    public ItemMove coinPf;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Building")
        {
            for (int i = 0; i < totalCoins; i++)
            {
                ItemMove coin = Instantiate(coinPf, transform.position + Vector3.up, Quaternion.identity);
                coin.MoveTo(coin.transform.position, other.transform.position);
                totalCoins--;
            }
        }
    }
}
