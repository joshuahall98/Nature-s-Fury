using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindMovesAI : MonoBehaviour
{
    public GameObject battleSystem;

    Unit playerUnit1;
    Unit playerUnit2;
    Unit playerUnit3;

    Unit enemyUnit1;
    Unit enemyUnit2;
    Unit enemyUnit3;

    Unit chosenEnemy;

    Unit chosenPlayer;

    public BattleHUD playerHUD1;
    public BattleHUD playerHUD2;
    public BattleHUD playerHUD3;

    public BattleHUD enemyHUD1;
    public BattleHUD enemyHUD2;
    public BattleHUD enemyHUD3;

    public BattleHUD chosenEnemyHUD1;
    public BattleHUD chosenEnemyHUD2;
    public BattleHUD chosenEnemyHUD3;

    public BattleHUD chosenPlayerHUD;

    public int enemyMove1CD = 0;
    public int enemyMove2CD = 0;
    public int enemyMove3CD = 0;
    public int enemyMove4CD = 0;

    public int whirlingTornadoBuff = 5;

    public bool move1Useable = true;
    public bool move2Useable = true;
    public bool move3Useable = true;
    public bool move4Useable = true;

    public Text dialogueText;

    //GET CLONE DATA
    public void GetObjects()
    {

        playerUnit1 = GetComponent<BattleSystem>().playerUnit1;
        playerUnit2 = GetComponent<BattleSystem>().playerUnit2;
        playerUnit3 = GetComponent<BattleSystem>().playerUnit3;

        enemyUnit1 = GetComponent<BattleSystem>().enemyUnit1;
        enemyUnit2 = GetComponent<BattleSystem>().enemyUnit2;
        enemyUnit3 = GetComponent<BattleSystem>().enemyUnit3;

    }

    //MOVE CDS
    public void WindMoveAICD()
    {
        if (enemyMove1CD >= 1)
        {
            move1Useable = false;
            enemyMove1CD = enemyMove1CD - 1;
            if (enemyMove1CD <= 0)
            {
                move1Useable = true;
            }
        }
        else if (enemyMove1CD <= 0)
        {
            move1Useable = true;
        }
        //move 2 cd
        if (enemyMove2CD >= 1)
        {
            move2Useable = false;
            enemyMove2CD = enemyMove2CD - 1;
            if (enemyMove2CD <= 0)
            {
                move2Useable = true;
            }
        }
        else if (enemyMove2CD <= 0)
        {
            move2Useable = true;
        }
        //move 3 cd
        if (enemyMove3CD >= 1)
        {
            move3Useable = false;
            enemyMove3CD = enemyMove3CD - 1;
            if (enemyMove3CD <= 0)
            {
                move3Useable = true;
            }
        }
        else if (enemyMove3CD <= 0)
        {
            move3Useable = true;
        }
        //move 4 cd
        if (enemyMove4CD >= 1)
        {
            move4Useable = false;
            enemyMove4CD = enemyMove4CD - 1;
            if (enemyMove4CD <= 0)
            {
                move4Useable = true;
            }
        }
        else if (enemyMove4CD <= 0)
        {
            move4Useable = true;
        }

        //ability buff cd

    }

    //AI MOVE CHOICES
    public void ChosenWindMoves()
    {
        if (enemyUnit1.tag == "Wind")
        {
            for (int i = 0; i < 100; i++)
            {
                int move = Random.Range(0, 4);

                if (move == 0 && move1Useable == true)
                {
                    enemyUnit1.chosenMove = 1;
                    i = 101;
                }
                else if (move == 1 && move2Useable == true)
                {
                    enemyUnit1.chosenMove = 2;
                    i = 101;
                }
                else if (move == 2 && move3Useable == true)
                {
                    enemyUnit1.chosenMove = 3;
                    i = 101;
                }
                else if (move == 3 && move4Useable == true && enemyUnit1.passiveBuff == false && enemyUnit2.passiveBuff == false && enemyUnit3.passiveBuff == false)
                {
                    enemyUnit1.chosenMove = 4;
                    i = 101;
                }
            }
        }

        if (enemyUnit2.tag == "Wind")
        {
            for (int i = 0; i < 100; i++)
            {
                int move = Random.Range(0, 4);

                if (move == 0 && move1Useable == true)
                {
                    enemyUnit2.chosenMove = 1;
                    i = 101;
                }
                else if (move == 1 && move2Useable == true)
                {
                    enemyUnit2.chosenMove = 2;
                    i = 101;
                }
                else if (move == 2 && move3Useable == true)
                {
                    enemyUnit2.chosenMove = 3;
                    i = 101;
                }
                else if (move == 3 && move4Useable == true && enemyUnit1.passiveBuff == false && enemyUnit2.passiveBuff == false && enemyUnit3.passiveBuff == false)
                {
                    enemyUnit2.chosenMove = 4;
                    i = 101;
                }
            }
        }

        if (enemyUnit3.tag == "Wind")
        {
            for (int i = 0; i < 100; i++)
            {
                int move = Random.Range(0, 4);

                if (move == 0 && move1Useable == true)
                {
                    enemyUnit3.chosenMove = 1;
                    i = 101;
                }
                else if (move == 1 && move2Useable == true)
                {
                    enemyUnit3.chosenMove = 2;
                    i = 101;
                }
                else if (move == 2 && move3Useable == true)
                {
                    enemyUnit3.chosenMove = 3;
                    i = 101;
                }
                else if (move == 3 && move4Useable == true && enemyUnit1.passiveBuff == false && enemyUnit2.passiveBuff == false && enemyUnit3.passiveBuff == false)
                {
                    enemyUnit3.chosenMove = 4;
                    i = 101;
                }
            }
        }
    }

    //MOVES
    //e1 move 1
    public void EU1WindMove1()
    {

        if(enemyUnit1.isStunned == false)
        {
            enemyMove1CD = 1;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.TakeDamage(enemyUnit1.unitAtk);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Attack on the player's " + chosenPlayer.unitName + " dealing " + enemyUnit1.unitAtk + " damage";

            }
            else if (chosenPlayer.isBlocking == true)
            {
                dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 1
    public void EU2WindMove1()
    {

        if (enemyUnit2.isStunned == false)
        {
            enemyMove1CD = 1;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.TakeDamage(enemyUnit2.unitAtk);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Attack on the player's " + chosenPlayer.unitName + " dealing " + enemyUnit2.unitAtk + " damage";


            }
            else if (chosenPlayer.isBlocking == true)
            {
                dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 1
    public void EU3WindMove1()
    {

        if (enemyUnit3.isStunned == false)
        {
            enemyMove1CD = 1;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.TakeDamage(enemyUnit3.unitAtk);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Attack on the player's " + chosenPlayer.unitName + " dealing " + enemyUnit3.unitAtk + " damage";

            }
            else if (chosenPlayer.isBlocking == true)
            {
                dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
    //e1 move 2
    public void EU1WindMove2()
    {

        if (enemyUnit1.isStunned == false)
        {
            enemyMove2CD = 2;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    else if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    else if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.TakeDamage(whirlingTornadoBuff);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Whirling Tornado on the player's " + chosenPlayer.unitName + " dealing " + whirlingTornadoBuff + " damage";

                if (whirlingTornadoBuff <= 29)
                {
                    whirlingTornadoBuff = whirlingTornadoBuff + 5;
                }

            }
            else if (chosenPlayer.isBlocking == true)
            {
                dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 2
    public void EU2WindMove2()
    {

        if (enemyUnit2.isStunned == false)
        {
            enemyMove2CD = 2;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    else if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    else if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.TakeDamage(whirlingTornadoBuff);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Whirling Tornado on the player's " + chosenPlayer.unitName + " dealing " + whirlingTornadoBuff + " damage";

                if (whirlingTornadoBuff <= 29)
                {
                    whirlingTornadoBuff = whirlingTornadoBuff + 5;
                }

            }
            else if (chosenPlayer.isBlocking == true)
            {
                dialogueText.text = "Players " + chosenPlayer.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 2
    public void EU3WindMove2()
    {

        if (enemyUnit3.isStunned == false)
        {
            enemyMove2CD = 2;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    else if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    else if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.TakeDamage(whirlingTornadoBuff);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Whirling Tornado on the player's " + chosenPlayer.unitName + " dealing " + whirlingTornadoBuff + " damage";

                if (whirlingTornadoBuff <= 29)
                {
                    whirlingTornadoBuff = whirlingTornadoBuff + 5;
                }

            }
            else if (chosenPlayer.isBlocking == true)
            {
                dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
    //e1 move 3
    public void EU1WindMove3()
    {

        if (enemyUnit1.isStunned == false)
        {
            enemyMove3CD = 3;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            bool selfDamage = false;

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {
                chosenPlayer.TakeDamage(20);

                int recoil = Random.Range(0, 2);

                if (recoil == 0)
                {
                    selfDamage = true;
                }

                if (enemyUnit1.isBlocking == false && selfDamage == true)
                {
                    enemyUnit1.TakeDamage(20);
                }

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }
                else if (enemyUnit1.currentHp <= 0)
                {
                    enemyUnit1.currentHp = 0;
                    enemyUnit1.isDead = true;
                    enemyUnit1.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);
                enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

                if (enemyUnit1.isBlocking == false && selfDamage == false)
                {
                    dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage";
                }
                else if (enemyUnit1.isBlocking == false && selfDamage == true)
                {
                    dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage and receiving 20 recoil damage";
                }
                else if (enemyUnit1.isBlocking == true && selfDamage == true)
                {
                    dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage and blocked the recoil damage";
                }

            }
            else if (chosenPlayer.isBlocking == true)
            {
                int recoil = Random.Range(0, 2);

                if (recoil == 0)
                {
                    selfDamage = true;
                }

                if (selfDamage == true)
                {
                    dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack but enemies " + enemyUnit1.unitName + " received 20 recoil damage";
                }
                else if (selfDamage == false)
                {
                    dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
                }

            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        
    }
    //e2 move 3
    public void EU2WindMove3()
    {

        if (enemyUnit2.isStunned == false)
        {
            enemyMove3CD = 3;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            bool selfDamage = false;

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {
                chosenPlayer.TakeDamage(20);

                int recoil = Random.Range(0, 2);

                if (recoil == 0)
                {
                    selfDamage = true;
                }

                if (enemyUnit2.isBlocking == false && selfDamage == true)
                {
                    enemyUnit2.TakeDamage(20);
                }

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }
                else if (enemyUnit2.currentHp <= 0)
                {
                    enemyUnit2.currentHp = 0;
                    enemyUnit2.isDead = true;
                    enemyUnit2.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);
                enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

                if (enemyUnit2.isBlocking == false && selfDamage == false)
                {
                    dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage";
                }
                else if (enemyUnit2.isBlocking == false && selfDamage == true)
                {
                    dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage and receiving 20 recoil damage";
                }
                else if (enemyUnit2.isBlocking == true && selfDamage == true)
                {
                    dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage and blocked the recoil damage";
                }

            }
            else if (chosenPlayer.isBlocking == true)
            {
                int recoil = Random.Range(0, 2);

                if (recoil == 0)
                {
                    selfDamage = true;
                }

                if (selfDamage == true)
                {
                    dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack but enemies " + enemyUnit2.unitName + " received 20 recoil damage";
                }
                else if (selfDamage == false)
                {
                    dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
                }

            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        
    }
    //e3 move 3
    public void EU3WindMove3()
    {

        if (enemyUnit3.isStunned == false)
        {
            enemyMove3CD = 3;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenPlayer = playerUnit1;
                chosenPlayerHUD = playerHUD1;
            }
            else if (numP == 1)
            {
                chosenPlayer = playerUnit2;
                chosenPlayerHUD = playerHUD2;
            }
            else if (numP == 2)
            {
                chosenPlayer = playerUnit3;
                chosenPlayerHUD = playerHUD3;
            }

            bool selfDamage = false;

            if (chosenPlayer.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && playerUnit1.isDead == false)
                    {
                        chosenPlayer = playerUnit1;
                        chosenPlayerHUD = playerHUD1;
                        i = 101;
                    }
                    if (num == 1 && playerUnit2.isDead == false)
                    {
                        chosenPlayer = playerUnit2;
                        chosenPlayerHUD = playerHUD2;
                        i = 101;
                    }
                    if (num == 2 && playerUnit3.isDead == false)
                    {
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {
                chosenPlayer.TakeDamage(20);

                int recoil = Random.Range(0, 2);

                if (recoil == 0)
                {
                    selfDamage = true;
                }

                if (enemyUnit3.isBlocking == false && selfDamage == true)
                {
                    enemyUnit3.TakeDamage(20);
                }

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }
                else if (enemyUnit3.currentHp <= 0)
                {
                    enemyUnit3.currentHp = 0;
                    enemyUnit3.isDead = true;
                    enemyUnit3.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);
                enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

                if (enemyUnit3.isBlocking == false && selfDamage == false)
                {
                    dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage";
                }
                else if (enemyUnit3.isBlocking == false && selfDamage == true)
                {
                    dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage and receiving 20 recoil damage";
                }
                else if (enemyUnit3.isBlocking == true && selfDamage == true)
                {
                    dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Unstable Squall on the player's " + chosenPlayer.unitName + " dealing 20 damage and blocked the recoil damage";
                }

            }
            else if (chosenPlayer.isBlocking == true)
            {
                int recoil = Random.Range(0, 2);

                if (recoil == 0)
                {
                    selfDamage = true;
                }

                if (selfDamage == true)
                {
                    dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack but enemies " + enemyUnit3.unitName + " received 20 recoil damage";
                }
                else if (selfDamage == false)
                {
                    dialogueText.text = "Player's " + chosenPlayer.unitName + " blocked the attack";
                }

            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        
    }
    //e1 move 4
    public void EU1WindMove4()
    {
        if (enemyUnit1.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            enemyUnit1.unitSpd = enemyUnit1.unitSpd + 1;
            enemyUnit2.unitSpd = enemyUnit2.unitSpd + 1;
            enemyUnit3.unitSpd = enemyUnit3.unitSpd + 1;

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used their buff increasing Hurricane Tailwind speed by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 4
    public void EU2WindMove4()
    {
        if (enemyUnit2.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit2.passiveBuff = true;

            enemyUnit1.unitSpd = enemyUnit1.unitSpd + 1;
            enemyUnit2.unitSpd = enemyUnit2.unitSpd + 1;
            enemyUnit3.unitSpd = enemyUnit3.unitSpd + 1;

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used their buff increasing Hurricane Tailwind speed by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 4
    public void EU3WindMove4()
    {
        if (enemyUnit3.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit3.passiveBuff = true;

            enemyUnit1.unitSpd = enemyUnit1.unitSpd + 1;
            enemyUnit2.unitSpd = enemyUnit2.unitSpd + 1;
            enemyUnit3.unitSpd = enemyUnit3.unitSpd + 1;

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used their buff increasing Hurricane Tailwind speed by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }

}
