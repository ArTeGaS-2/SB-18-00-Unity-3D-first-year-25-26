using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusButton : MonoBehaviour
{
    public void ClickBonusButton()
    {
        if (Economy.Instance.clickCounter >=
            Economy.Instance.TakeCurrentPrice())
        {
            Economy.Instance.coinsPerClick++;
            Economy.Instance.clickCounter -= 
                Economy.Instance.TakeCurrentPrice();
        }
    }
}
