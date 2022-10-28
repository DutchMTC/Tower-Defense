using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinText;
    private int coins;
    void Update()
    {
        coins = GameObject.Find("CurrencyManager").GetComponent<CurrencySystem>().TotalCoins;
        _coinText.text = coins.ToString();
    }
}
