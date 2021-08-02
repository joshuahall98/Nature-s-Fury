using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MoveOrder : MonoBehaviour
{
    public GameObject battleSystem;

    public List<int> list;

    public int max;

    Unit playerUnit1;
    Unit playerUnit2;
    Unit playerUnit3;

    Unit enemyUnit1;
    Unit enemyUnit2;
    Unit enemyUnit3;

    public int playerUnit1CD;
    public int playerUnit2CD;
    public int playerUnit3CD;

    public int enemyUnit1CD;
    public int enemyUnit2CD;
    public int enemyUnit3CD;

    public int reset1;
    public int reset2;
    public int reset3;
    public int reset4;
    public int reset5;
    public int reset6;

    //GET THE CLONE DATA
    public void GetObjects()
    {
        playerUnit1 = GetComponent<BattleSystem>().playerUnit1;
        playerUnit2 = GetComponent<BattleSystem>().playerUnit2;
        playerUnit3 = GetComponent<BattleSystem>().playerUnit3;

        enemyUnit1 = GetComponent<BattleSystem>().enemyUnit1;
        enemyUnit2 = GetComponent<BattleSystem>().enemyUnit2;
        enemyUnit3 = GetComponent<BattleSystem>().enemyUnit3;

        GetCDs();

    }


    //OBTAINING VARIABLES
    public void GetCDs()
    {
        playerUnit1CD = playerUnit1.unitSpd;
        playerUnit2CD = playerUnit2.unitSpd;
        playerUnit3CD = playerUnit3.unitSpd;

        enemyUnit1CD = enemyUnit1.unitSpd;
        enemyUnit2CD = enemyUnit2.unitSpd;
        enemyUnit3CD = enemyUnit3.unitSpd;

        //store for reset later
        reset1 = playerUnit1CD;
        reset2 = playerUnit2CD;
        reset3 = playerUnit3CD;
        reset4 = enemyUnit1CD;
        reset5 = enemyUnit2CD;
        reset6 = enemyUnit3CD;
    }


    //MOVE FIRST FUNCTION
    public void MovePrio()
    {
        max = list.Max();

        //first move check
        for (int i = 0; i < 1000; i++)
        {
            int num = Random.Range(0, 6);

            if (num == 0 && max == playerUnit1CD )
            {
                playerUnit1.movePrio = 1;
                list.Sort();
                list.RemoveAt(5);
                playerUnit1CD = 0;
                i = 1001;
            }
            if (num == 1 && max == playerUnit2CD )
            {
                playerUnit2.movePrio = 1;
                list.Sort();
                list.RemoveAt(5);
                playerUnit2CD = 0;
                i = 1001;
            }
            if (num == 2 && max == playerUnit3CD )
            {
                playerUnit3.movePrio = 1;
                list.Sort();
                list.RemoveAt(5);
                playerUnit3CD = 0;
                i = 1001;
            }
            if (num == 3 && max == enemyUnit1CD )
            {
                enemyUnit1.movePrio = 1;
                list.Sort();
                list.RemoveAt(5);
                enemyUnit1CD = 0;
                i = 1001;
            }
            if (num == 4 && max == enemyUnit2CD )
            {
                enemyUnit2.movePrio = 1;
                list.Sort();
                list.RemoveAt(5);
                enemyUnit2CD = 0;
                i = 1001;
            }
            if (num == 5 && max == enemyUnit3CD )
            {
                enemyUnit3.movePrio = 1;
                list.Sort();
                list.RemoveAt(5);
                enemyUnit3CD = 0;
                i = 1001;
            }
        }

        //second move check
        max = list.Max();

        for (int i = 0; i < 1000; i++)
        {
            int num = Random.Range(0, 6);

            if (num == 0 && max == playerUnit1CD )
            {
                playerUnit1.movePrio = 2;
                list.Sort();
                list.RemoveAt(4);
                playerUnit1CD = 0;
                i = 1001;
            }
            if (num == 1 && max == playerUnit2CD )
            {
                playerUnit2.movePrio = 2;
                list.Sort();
                list.RemoveAt(4);
                playerUnit2CD = 0;
                i = 1001;
            }
            if (num == 2 && max == playerUnit3CD)
            {
                playerUnit3.movePrio = 2;
                list.Sort();
                list.RemoveAt(4);
                playerUnit3CD = 0;
                i = 1001;
            }
            if (num == 3 && max == enemyUnit1CD )
            {
                enemyUnit1.movePrio = 2;
                list.Sort();
                list.RemoveAt(4);
                enemyUnit1CD = 0;
                i = 1001;
            }
            if (num == 4 && max == enemyUnit2CD)
            {
                enemyUnit2.movePrio = 2;
                list.Sort();
                list.RemoveAt(4);
                enemyUnit2CD = 0;
                i = 1001;
            }
            if (num == 5 && max == enemyUnit3CD)
            {
                enemyUnit3.movePrio = 2;
                list.Sort();
                list.RemoveAt(4);
                enemyUnit3CD = 0;
                i = 1001;
            }
        }

        //third move check
        max = list.Max();

        for (int i = 0; i < 1000; i++)
        {
            int num = Random.Range(0, 6);

            if (num == 0 && max == playerUnit1CD)
            {
                playerUnit1.movePrio = 3;
                list.Sort();
                list.RemoveAt(3);
                playerUnit1CD = 0;
                i = 1001;
            }
            if (num == 1 && max == playerUnit2CD)
            {
                playerUnit2.movePrio = 3;
                list.Sort();
                list.RemoveAt(3);
                playerUnit2CD = 0;
                i = 1001;
            }
            if (num == 2 && max == playerUnit3CD )
            {
                playerUnit3.movePrio = 3;
                list.Sort();
                list.RemoveAt(3);
                playerUnit3CD = 0;
                i = 1001;
            }
            if (num == 3 && max == enemyUnit1CD)
            {
                enemyUnit1.movePrio = 3;
                list.Sort();
                list.RemoveAt(3);
                enemyUnit1CD = 0;
                i = 1001;
            }
            if (num == 4 && max == enemyUnit2CD)
            {
                enemyUnit2.movePrio = 3;
                list.Sort();
                list.RemoveAt(3);
                enemyUnit2CD = 0;
                i = 1001;
            }
            if (num == 5 && max == enemyUnit3CD)
            {
                enemyUnit3.movePrio = 3;
                list.Sort();
                list.RemoveAt(3);
                enemyUnit3CD = 0;
                i = 1001;
            }
        }

        //fourth move check
        max = list.Max();

        for (int i = 0; i < 1000; i++)
        {
            int num = Random.Range(0, 6);

            if (num == 0 && max == playerUnit1CD)
            {
                playerUnit1.movePrio = 4;
                list.Sort();
                list.RemoveAt(2);
                playerUnit1CD = 0;
                i = 1001;
            }
            if (num == 1 && max == playerUnit2CD)
            {
                playerUnit2.movePrio = 4;
                list.Sort();
                list.RemoveAt(2);
                playerUnit2CD = 0;
                i = 1001;
            }
            if (num == 2 && max == playerUnit3CD)
            {
                playerUnit3.movePrio = 4;
                list.Sort();
                list.RemoveAt(2);
                playerUnit3CD = 0;
                i = 1001;
            }
            if (num == 3 && max == enemyUnit1CD)
            {
                enemyUnit1.movePrio = 4;
                list.Sort();
                list.RemoveAt(2);
                enemyUnit1CD = 0;
                i = 1001;
            }
            if (num == 4 && max == enemyUnit2CD)
            {
                enemyUnit2.movePrio = 4;
                list.Sort();
                list.RemoveAt(2);
                enemyUnit2CD = 0;
                i = 1001;
            }
            if (num == 5 && max == enemyUnit3CD)
            {
                enemyUnit3.movePrio = 4;
                list.Sort();
                list.RemoveAt(2);
                enemyUnit3CD = 0;
                i = 1001;
            }
        }

        //fifth move check
        max = list.Max();

        for (int i = 0; i < 1000; i++)
        {
            int num = Random.Range(0, 6);

            if (num == 0 && max == playerUnit1CD)
            {
                playerUnit1.movePrio = 5;
                list.Sort();
                list.RemoveAt(1);
                playerUnit1CD = 0;
                i = 1001;
            }
            if (num == 1 && max == playerUnit2CD)
            {
                playerUnit2.movePrio = 5;
                list.Sort();
                list.RemoveAt(1);
                playerUnit2CD = 0;
                i = 1001;
            }
            if (num == 2 && max == playerUnit3CD)
            {
                playerUnit3.movePrio = 5;
                list.Sort();
                list.RemoveAt(1);
                playerUnit3CD = 0;
                i = 1001;
            }
            if (num == 3 && max == enemyUnit1CD)
            {
                enemyUnit1.movePrio = 5;
                list.Sort();
                list.RemoveAt(1);
                enemyUnit1CD = 0;
                i = 1001;
            }
            if (num == 4 && max == enemyUnit2CD)
            {
                enemyUnit2.movePrio = 5;
                list.Sort();
                list.RemoveAt(1);
                enemyUnit2CD = 0;
                i = 1001;
            }
            if (num == 5 && max == enemyUnit3CD)
            {
                enemyUnit3.movePrio = 5;
                list.Sort();
                list.RemoveAt(1);
                enemyUnit3CD = 0;
                i = 1001;
            }
        }

        //sixth move check
        max = list.Max();

        for (int i = 0; i < 1000; i++)
        {
            int num = Random.Range(0, 6);

            if (num == 0 && max == playerUnit1CD)
            {
                playerUnit1.movePrio = 6;
                list.Sort();
                list.RemoveAt(0);
                playerUnit1CD = 0;
                i = 1001;
            }
            if (num == 1 && max == playerUnit2CD)
            {
                playerUnit2.movePrio = 6;
                list.Sort();
                list.RemoveAt(0);
                playerUnit2CD = 0;
                i = 1001;
            }
            if (num == 2 && max == playerUnit3CD)
            {
                playerUnit3.movePrio = 6;
                list.Sort();
                list.RemoveAt(0);
                playerUnit3CD = 0;
                i = 1001;
            }
            if (num == 3 && max == enemyUnit1CD)
            {
                enemyUnit1.movePrio = 6;
                list.Sort();
                list.RemoveAt(0);
                enemyUnit1CD = 0;
                i = 1001;
            }
            if (num == 4 && max == enemyUnit2CD)
            {
                enemyUnit2.movePrio = 6;
                list.Sort();
                list.RemoveAt(0);
                enemyUnit2CD = 0;
                i = 1001;
            }
            if (num == 5 && max == enemyUnit3CD)
            {
                enemyUnit3.movePrio = 6;
                list.Sort();
                list.RemoveAt(0);
                enemyUnit3CD = 0;
                i = 1001;
            }
        }

        playerUnit1CD = reset1;
        playerUnit2CD = reset2;
        playerUnit3CD = reset3;
        enemyUnit1CD = reset4;
        enemyUnit2CD = reset5;
        enemyUnit3CD = reset6;
    }


    //RESET PRIO
    public void PrioReset()
    {
        playerUnit1.movePrio = 0;
        playerUnit2.movePrio = 0;
        playerUnit3.movePrio = 0;

        enemyUnit1.movePrio = 0;
        enemyUnit2.movePrio = 0;
        enemyUnit3.movePrio = 0;

        list.Add(playerUnit1CD);
        list.Add(playerUnit2CD);
        list.Add(playerUnit3CD);
        list.Add(enemyUnit1CD);
        list.Add(enemyUnit2CD);
        list.Add(enemyUnit3CD);

    }

}
