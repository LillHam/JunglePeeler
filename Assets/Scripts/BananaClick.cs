using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaClick : MonoBehaviour
{
    [SerializeField] int apeCosts;
    [SerializeField] int multplierCosts;

    int AmountofClickMultiplier;
    int amountOfMonkeys;

    public TMPro.TextMeshProUGUI ClicksTotalText;
    public TMPro.TextMeshProUGUI MultiplierCostText;
    public TMPro.TextMeshProUGUI ApeCostText;

    float TotalClicks;

    private void Start()
    {
        AmountofClickMultiplier = 0;
        amountOfMonkeys = 0;
        apeCosts = 5; 
        multplierCosts = 5;
    }
    private void Update()
    {
        ClicksTotalText.text = TotalClicks.ToString("0");
        MultiplierCostText.text = multplierCosts.ToString("0");
        ApeCostText.text = apeCosts.ToString("0");
    }
    public void AddClicks()
    {
        TotalClicks += 1 + AmountofClickMultiplier;
    }
    public void ApUpgradering()
    {
        if (TotalClicks >= apeCosts)
        {
            float currentClicks = TotalClicks;
            amountOfMonkeys++;
            TotalClicks = currentClicks - apeCosts;
            apeCosts *= 2;
        }
    }

    public void FördubblingsUppgradering()
    {
        if (TotalClicks >= multplierCosts)
        {
            float currentClicks = TotalClicks;
            AmountofClickMultiplier++;
            TotalClicks = currentClicks - multplierCosts;
            multplierCosts *= 2;
        }
    }

}
