using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaClick : MonoBehaviour
{
    [SerializeField] int apeCosts;
    [SerializeField] int multplierCosts;

    int AmountofClickMultiplier;
    float amountOfMonkeys;
    bool isCountingdownAC;

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
        isCountingdownAC = false;
    }
    private void Update()
    {
        ClicksTotalText.text = TotalClicks.ToString("0");
        MultiplierCostText.text = multplierCosts.ToString("0");
        ApeCostText.text = apeCosts.ToString("0");

        if (isCountingdownAC == false)
        {
            StartCoroutine(AutoclickCountdown());
        }    
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
            amountOfMonkeys = +0.2f;
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

    IEnumerator AutoclickCountdown()
    {
        isCountingdownAC = true;
        yield return new WaitForSeconds(5 - amountOfMonkeys);
        AddClicks();
        isCountingdownAC = false;
        yield return null;
    }

}
