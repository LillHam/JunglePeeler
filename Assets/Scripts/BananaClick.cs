using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaClick : MonoBehaviour
{
    // Start is called before the first frame update

        public TMPro.TextMeshProUGUI ClicksTotalText;

    float TotalClicks;

    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }
    
}
