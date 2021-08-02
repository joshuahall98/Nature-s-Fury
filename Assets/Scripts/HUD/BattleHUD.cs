using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text nameText;
    public Text hpText;
    public Slider hpSlider;


    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        hpText.text = unit.currentHp + "/" + unit.maxHp;
        hpSlider.maxValue = unit.maxHp;
        hpSlider.value = unit.currentHp;
    }

    public void SetHP(int hp, Unit unit)
    {
        hpSlider.maxValue = unit.maxHp;
        hpSlider.value = hp;
        hpText.text = hp + "/" + unit.maxHp;
    }

}
