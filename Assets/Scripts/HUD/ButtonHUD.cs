using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHUD : MonoBehaviour
{
    

    public Text name1Text;
    public Text name2Text;
    public Text name3Text;
    public Text name4Text;
    public Text name5Text;
    public Text name6Text;
    public Text name7Text;
    public Text name8Text;
    public Text name9Text;
    public Text name10Text;
    public Text name11Text;
    public Text name12Text;

    public Text move1Desc;
    public Text move2Desc;
    public Text move3Desc;
    public Text move4Desc;
    public Text move5Desc;
    public Text move6Desc;
    public Text move7Desc;
    public Text move8Desc;
    public Text move9Desc;
    public Text move10Desc;
    public Text move11Desc;
    public Text move12Desc;

    public Text unit1Text;
    public Text unit2Text;
    public Text unit3Text;

    public Text unit1Text2;
    public Text unit2Text2;
    public Text unit3Text2;

    public Text enemyUnit1Text;
    public Text enemyUnit2Text;
    public Text enemyUnit3Text;

    



    public void SetBtnHUD(Unit unit)
    {

        name1Text.text = unit.move1Name;
        move1Desc.text = unit.move1desc;
        name2Text.text = unit.move2Name;
        move2Desc.text = unit.move2desc;
        name3Text.text = unit.move3Name;
        move3Desc.text = unit.move3desc;
        name4Text.text = unit.move4Name;
        move4Desc.text = unit.move4desc;
    }

    public void SetBtnHUD2(Unit unit)
    {
        name5Text.text = unit.move1Name;
        move5Desc.text = unit.move1desc;
        name6Text.text = unit.move2Name;
        move6Desc.text = unit.move2desc;
        name7Text.text = unit.move3Name;
        move7Desc.text = unit.move3desc;
        name8Text.text = unit.move4Name;
        move8Desc.text = unit.move4desc;
    }

    public void SetBtnHUD3(Unit unit)
    {
        name9Text.text = unit.move1Name;
        move9Desc.text = unit.move1desc;
        name10Text.text = unit.move2Name;
        move10Desc.text = unit.move2desc;
        name11Text.text = unit.move3Name;
        move11Desc.text = unit.move3desc;
        name12Text.text = unit.move4Name;
        move12Desc.text = unit.move4desc;
    }

    public void SetUnitName(Unit unit)
    {
        unit1Text.text = unit.unitName;       
    }

    public void SetUnitName2(Unit unit)
    {
        unit2Text.text = unit.unitName;
    }

    public void SetUnitName3(Unit unit)
    {
        unit3Text.text = unit.unitName;
    }

    public void SetEnemyUnitName1(Unit unit)
    {
        enemyUnit1Text.text = unit.unitName;
    }

    public void SetEnemyUnitName2(Unit unit)
    {
        enemyUnit2Text.text = unit.unitName;
    }

    public void SetEnemyUnitName3(Unit unit)
    {
        enemyUnit3Text.text = unit.unitName;
    }

    public void SetUnitName4(Unit unit)
    {
        unit1Text2.text = unit.unitName;
    }

    public void SetUnitName5(Unit unit)
    {
        unit2Text2.text = unit.unitName;
    }

    public void SetUnitName6(Unit unit)
    {
        unit3Text2.text = unit.unitName;
    }

   


}
