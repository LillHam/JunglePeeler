using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Uppgrades : MonoBehaviour
{
    [SerializeField] int costAmount1;
    [SerializeField] int costAmount2;
    [SerializeField] int currentCash;

    int clickMultiplier;
    int amountOfMonkeys;

    void ApUpgradering()
    {
        if(currentCash == costAmount1 )
        {
            amountOfMonkeys++;
        }
    }

    void FördubblingsUppgradering()
    {
        if (currentCash == costAmount2)
        {
            clickMultiplier++;
        }
    }
}
