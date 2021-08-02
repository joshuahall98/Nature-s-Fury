using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectricMovesAI : MonoBehaviour
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

    public int hyperBurnBuff = 0;

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
    public void ElectricMoveAICD()
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
    public void ChosenElectricMoves()
    {
        if (enemyUnit1.tag == "Electric")
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
                else if (move == 3 && move4Useable == true && enemyUnit1.passiveBuff == false && enemyUnit2.passiveBuff == false && enemyUnit3.passiveBuff == false )
                {
                    enemyUnit1.chosenMove = 4;
                    i = 101;
                }
            }
        }

        if (enemyUnit2.tag == "Electric")
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

        if (enemyUnit3.tag == "Electric")
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
    public void EU1ElectricMove1()
    {
        if (enemyUnit1.isStunned == false)
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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {
                int num = Random.Range(0, 2);

                int enemyAtk = enemyUnit1.unitAtk;

                if (num == 0)
                {
                    enemyAtk = enemyUnit1.unitAtk + enemyUnit2.unitAtk;
                }
                else if (num == 1)
                {
                    enemyAtk = enemyUnit1.unitAtk + enemyUnit3.unitAtk;
                }

                if (enemyUnit1.passiveBuff == true)
                {
                    enemyAtk = enemyUnit1.unitAtk + enemyUnit2.unitAtk + enemyUnit3.unitAtk;
                }

                chosenPlayer.TakeDamage(enemyAtk);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Attack on the player's " + chosenPlayer.unitName + " dealing " + enemyAtk + " damage";

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
    public void EU2ElectricMove1()
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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {
                int num = Random.Range(0, 2);

                int enemyAtk = enemyUnit2.unitAtk;

                if (num == 0)
                {
                    enemyAtk = enemyUnit2.unitAtk + enemyUnit1.unitAtk;
                }
                else if (num == 1)
                {
                    enemyAtk = enemyUnit2.unitAtk + enemyUnit3.unitAtk;
                }

                if (enemyUnit2.passiveBuff == true)
                {
                    enemyAtk = enemyUnit1.unitAtk + enemyUnit2.unitAtk + enemyUnit3.unitAtk;
                }

                chosenPlayer.TakeDamage(enemyAtk);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Attack on the player's " + chosenPlayer.unitName + " dealing " + enemyAtk + " damage";

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
    public void EU3ElectricMove1()
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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {
                int num = Random.Range(0, 2);

                int enemyAtk = enemyUnit3.unitAtk;

                if (num == 0)
                {
                    enemyAtk = enemyUnit3.unitAtk + enemyUnit2.unitAtk;
                }
                else if (num == 1)
                {
                    enemyAtk = enemyUnit3.unitAtk + enemyUnit1.unitAtk;
                }

                if (enemyUnit3.passiveBuff == true)
                {
                    enemyAtk = enemyUnit1.unitAtk + enemyUnit2.unitAtk + enemyUnit3.unitAtk;
                }

                chosenPlayer.TakeDamage(enemyAtk);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Attack on the player's " + chosenPlayer.unitName + " dealing " + enemyAtk + " damage";

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
    public void EU1ElectricMove2()
    {

        if (enemyUnit1.isStunned == false)
        {
            enemyMove2CD = 4;

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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.isStunned = true;

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Lightning Chamber on the player's " + chosenPlayer.unitName + " stunning them";
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
    public void EU2ElectricMove2()
    {

        if (enemyUnit2.isStunned == false)
        {
            enemyMove2CD = 4;

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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.isStunned = true;

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Lightning Chamber on the player's " + chosenPlayer.unitName + " stunning them";
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
    //e3 move 2
    public void EU3ElectricMove2()
    { 

        if (enemyUnit3.isStunned == false)
        {
            enemyMove2CD = 4;

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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenPlayer.isBlocking == false)
            {

                chosenPlayer.isStunned = true;

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Lightning Chamber on the player's " + chosenPlayer.unitName + " stunning them";
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
    public void EU1ElectricMove3()
    {

        if (enemyUnit1.isStunned == false)
        {
            enemyMove3CD = 5;

            if (playerUnit2.isBlocking == false)
            {
                playerUnit2.TakeDamage(10);
            }
            if (playerUnit3.isBlocking == false)
            {
                playerUnit3.TakeDamage(10);
            }
            if (playerUnit1.isBlocking == false)
            {
                playerUnit1.TakeDamage(10);
            }
            if (enemyUnit2.isBlocking == false)
            {
                enemyUnit2.TakeDamage(10);
            }
            if (enemyUnit3.isBlocking == false)
            {
                enemyUnit3.TakeDamage(10);
            }

            if (playerUnit2.currentHp <= 0 && playerUnit2.isDead == false)
            {
                playerUnit2.currentHp = 0;
                playerUnit2.isDead = true;
                playerUnit2.justDied = true;
            }
            if (playerUnit3.currentHp <= 0 && playerUnit3.isDead == false) 
            {
                playerUnit3.currentHp = 0;
                playerUnit3.isDead = true;
                playerUnit3.justDied = true;
            }
            if (playerUnit1.currentHp <= 0 && playerUnit1.isDead == false)
            {
                playerUnit1.currentHp = 0;
                playerUnit1.isDead = true;
                playerUnit1.justDied = true;
            }
            if (enemyUnit2.currentHp <= 0 && enemyUnit2.isDead == false)
            {
                enemyUnit2.currentHp = 0;
                enemyUnit2.isDead = true;
                enemyUnit2.justDied = true;
            }
            if (enemyUnit3.currentHp <= 0 && enemyUnit3.isDead == false)
            {
                enemyUnit3.currentHp = 0;
                enemyUnit3.isDead = true;
                enemyUnit3.justDied = true;
            }

            playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
            playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);
            playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
            enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);
            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

            if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Explosive Discharge on all other units dealing 10 damage each except the player's " + playerUnit2 + " who blocked the attack";
            }
            else if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Explosive Discharge on all other units dealing 10 damage each except the player's " + playerUnit3 + " who blocked the attack";
            }
            else if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Explosive Discharge on all other units dealing 10 damage each except player's " + playerUnit1 + " who blocked the attack";
            }
            else if (enemyUnit2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Explosive Discharge on all other units dealing10 damage each except enemy " + enemyUnit2 + " who blocked the attack";
            }
            else if (enemyUnit3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Explosive Discharge on all other units dealing 10 damage each except enemy " + enemyUnit3 + " who blocked the attack";
            }
            else
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Explosive Discharge on all other units dealing 10 damage each";
            }

        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }

    }
    //e2 move 3
    public void EU2ElectricMove3()
    {

        if (enemyUnit2.isStunned == false)
        {
            enemyMove3CD = 5;

            if (playerUnit2.isBlocking == false)
            {
                playerUnit2.TakeDamage(10);
            }
            if (playerUnit3.isBlocking == false)
            {
                playerUnit3.TakeDamage(10);
            }
            if (playerUnit1.isBlocking == false)
            {
                playerUnit1.TakeDamage(10);
            }
            if (enemyUnit1.isBlocking == false)
            {
                enemyUnit1.TakeDamage(10);
            }
            if (enemyUnit3.isBlocking == false)
            {
                enemyUnit3.TakeDamage(10);
            }

            if (playerUnit2.currentHp <= 0 && playerUnit2.isDead == false)
            {
                playerUnit2.currentHp = 0;
                playerUnit2.isDead = true;
                playerUnit2.justDied = true;
            }
            if (playerUnit3.currentHp <= 0 && playerUnit3.isDead == false)
            {
                playerUnit3.currentHp = 0;
                playerUnit3.isDead = true;
                playerUnit3.justDied = true;
            }
            if (playerUnit1.currentHp <= 0 && playerUnit1.isDead == false)
            {
                playerUnit1.currentHp = 0;
                playerUnit1.isDead = true;
                playerUnit1.justDied = true;
            }
            if (enemyUnit1.currentHp <= 0 && enemyUnit1.isDead == false)
            {
                enemyUnit1.currentHp = 0;
                enemyUnit1.isDead = true;
                enemyUnit1.justDied = true;
            }
            if (enemyUnit3.currentHp <= 0 && enemyUnit3.isDead == false)
            {
                enemyUnit3.currentHp = 0;
                enemyUnit3.isDead = true;
                enemyUnit3.justDied = true;
            }

            playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
            playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);
            playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);
            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

            if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except the player's " + playerUnit2 + " who blocked the attack";
            }
            else if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except the player's " + playerUnit3 + " who blocked the attack";
            }
            else if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except player's " + playerUnit1 + " who blocked the attack";
            }
            else if (enemyUnit1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except enemy " + enemyUnit1 + " who blocked the attack";
            }
            else if (enemyUnit3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except enemy " + enemyUnit3 + " who blocked the attack";
            }
            else
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each";
            }

        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }

    }
    //e3 move 3
    public void EU3ElectricMove3()
    {

        if (enemyUnit3.isStunned == false)
        {
            enemyMove3CD = 5;

            if (playerUnit2.isBlocking == false)
            {
                playerUnit2.TakeDamage(10);
            }
            if (playerUnit3.isBlocking == false)
            {
                playerUnit3.TakeDamage(10);
            }
            if (playerUnit1.isBlocking == false)
            {
                playerUnit1.TakeDamage(10);
            }
            if (enemyUnit2.isBlocking == false)
            {
                enemyUnit2.TakeDamage(10);
            }
            if (enemyUnit1.isBlocking == false)
            {
                enemyUnit1.TakeDamage(10);
            }

            if (playerUnit2.currentHp <= 0 && playerUnit2.isDead == false)
            {
                playerUnit2.currentHp = 0;
                playerUnit2.isDead = true;
                playerUnit2.justDied = true;
            }
            if (playerUnit3.currentHp <= 0 && playerUnit3.isDead == false)
            {
                playerUnit3.currentHp = 0;
                playerUnit3.isDead = true;
                playerUnit3.justDied = true;
            }
            if (playerUnit1.currentHp <= 0 && playerUnit1.isDead == false)
            {
                playerUnit1.currentHp = 0;
                playerUnit1.isDead = true;
                playerUnit1.justDied = true;
            }
            if (enemyUnit2.currentHp <= 0 && enemyUnit2.isDead == false)
            {
                enemyUnit2.currentHp = 0;
                enemyUnit2.isDead = true;
                enemyUnit2.justDied = true;
            }
            if (enemyUnit1.currentHp <= 0 && enemyUnit1.isDead == false)
            {
                enemyUnit1.currentHp = 0;
                enemyUnit1.isDead = true;
                enemyUnit1.justDied = true;
            }

            playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
            playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);
            playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
            enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);
            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

            if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except the player's " + playerUnit2 + " who blocked the attack";
            }
            else if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except the player's " + playerUnit3 + " who blocked the attack";
            }
            else if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except player's " + playerUnit1 + " who blocked the attack";
            }
            else if (enemyUnit2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except enemy " + enemyUnit2 + " who blocked the attack";
            }
            else if (enemyUnit1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each except enemy " + enemyUnit1 + " who blocked the attack";
            }
            else
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Explosive Discharge on all other units dealing damage 10 damage each";
            }

        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }

    }
    //e1 move 4
    public void EU1ElectricMove4()
    {

        if (enemyUnit1.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used their buff increasing electrical surges combined allys used to 2";

        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }

    }
    //e2 move 4
    public void EU2ElectricMove4()
    {

        if (enemyUnit2.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit2.passiveBuff = true;

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used their buff increasing electrical surges combined allys used to 2";

        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }

    }
    //e3 move 4
    public void EU3ElectricMove4()
    {

        if (enemyUnit3.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit3.passiveBuff = true;

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used their buff increasing electrical surges combined allys used to 2";

        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }

    }
}
