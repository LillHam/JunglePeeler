using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaClick : MonoBehaviour
{
    [SerializeField] int costAmount1;
    [SerializeField] int costAmount2;

    int clickMultiplier;
    int amountOfMonkeys;

    public TMPro.TextMeshProUGUI ClicksTotalText;

    float TotalClicks;

    private void Start()
    {
        clickMultiplier = 0;
        amountOfMonkeys = 0;
    }
    private void Update()
    {
        ClicksTotalText.text = TotalClicks.ToString("0");
    }
    public void AddClicks()
    {
        TotalClicks += 1 + clickMultiplier;
    }
    public void ApUpgradering()
    {
        if (TotalClicks >= costAmount1)
        {
            float currentClicks = TotalClicks;
            amountOfMonkeys++;
            TotalClicks = currentClicks - costAmount1;
            costAmount1 *= 2;
        }
    }

    public void FördubblingsUppgradering()
    {
        if (TotalClicks >= costAmount2)
        {
            float currentClicks = TotalClicks;
            clickMultiplier++;
            TotalClicks = currentClicks - costAmount2;
            costAmount2 *= 2;
        }
    }

}
