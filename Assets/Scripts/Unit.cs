using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;

    public int unitAtk;
    public int unitSpd;
    public bool isSupport;

    public int maxHp;
    public int currentHp;

    public int chosenMove;
    public int movePrio;

    public bool isDead = false;
    public bool justDied = false;
    public bool isBurned = false;
    public bool isBlocking = false;
    public bool isStunned = false;
    public bool passiveBuff = false;
    
    public string move1Name;
    [TextArea] public string move1desc;
    public string move2Name;
    [TextArea] public string move2desc;
    public string move3Name;
    [TextArea] public string move3desc;
    public string move4Name;
    [TextArea] public string move4desc;

    public void TakeDamage(int dmg)
    {
        currentHp -= dmg;
        
    }

    public void HealDamage(int heal)
    {
        currentHp += heal;
    }





}
