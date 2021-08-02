using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterMovesAI : MonoBehaviour
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
    public BattleHUD chosenEnemyHUD;

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
    public void WaterMoveAICD()
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
    public void ChosenWaterMoves()
    {
        if (enemyUnit1.tag == "Water")
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

        if (enemyUnit2.tag == "Water")
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

        if (enemyUnit3.tag == "Water")
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
    public void EU1WaterMove1()
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
    public void EU2WaterMove1()
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
    public void EU3WaterMove1()
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
    public void EU1WaterMove2()
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

            if (playerUnit1.isBlocking == false || playerUnit2.isBlocking == false || playerUnit3.isBlocking == false)
            {
                if (chosenPlayer.isBlocking == false)
                {
                    chosenPlayer.TakeDamage(10);
                }
                if (playerUnit1.isBlocking == false)
                {
                    playerUnit1.TakeDamage(5);
                }
                if (playerUnit2.isBlocking == false)
                {
                    playerUnit2.TakeDamage(5);
                }
                if (playerUnit3.isBlocking == false)
                {
                    playerUnit3.TakeDamage(5);
                }

                if (playerUnit1.currentHp <= 0 && playerUnit1.isDead == false)
                {
                    playerUnit1.currentHp = 0;
                    playerUnit1.isDead = true;
                    playerUnit1.justDied = true;
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

                playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
                playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
                playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Tidal Force dealing 15 damage to the chosen " + chosenPlayer.unitName + " and 5 damage to the other enemies  ";


            }
            if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit1.unitName + " blocked the attack";
            }
            if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit2.unitName + " blocked the attack";
            }
            if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit3.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 2
    public void EU2WaterMove2()
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

            if (playerUnit1.isBlocking == false || playerUnit2.isBlocking == false || playerUnit3.isBlocking == false)
            {
                if (chosenPlayer.isBlocking == false)
                {
                    chosenPlayer.TakeDamage(10);
                }
                if (playerUnit1.isBlocking == false)
                {
                    playerUnit1.TakeDamage(5);
                }
                if (playerUnit2.isBlocking == false)
                {
                    playerUnit2.TakeDamage(5);
                }
                if (playerUnit3.isBlocking == false)
                {
                    playerUnit3.TakeDamage(5);
                }

                if (playerUnit1.currentHp <= 0 && playerUnit1.isDead == false)
                {
                    playerUnit1.currentHp = 0;
                    playerUnit1.isDead = true;
                    playerUnit1.justDied = true;
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

                playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
                playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
                playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Tidal Force dealing 15 damage to the chosen " + chosenPlayer.unitName + " and 5 damage to the other enemies  ";


            }
            if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit1.unitName + " blocked the attack";
            }
            if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit2.unitName + " blocked the attack";
            }
            if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit3.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 2
    public void EU3WaterMove2()
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

            if (playerUnit1.isBlocking == false || playerUnit2.isBlocking == false || playerUnit3.isBlocking == false)
            {
                if (chosenPlayer.isBlocking == false)
                {
                    chosenPlayer.TakeDamage(10);
                }
                if (playerUnit1.isBlocking == false)
                {
                    playerUnit1.TakeDamage(5);
                }
                if (playerUnit2.isBlocking == false)
                {
                    playerUnit2.TakeDamage(5);
                }
                if (playerUnit3.isBlocking == false)
                {
                    playerUnit3.TakeDamage(5);
                }

                if (playerUnit1.currentHp <= 0 && playerUnit1.isDead == false)
                {
                    playerUnit1.currentHp = 0;
                    playerUnit1.isDead = true;
                    playerUnit1.justDied = true;
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

                playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
                playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
                playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Tidal Force dealing 15 damage to the chosen " + chosenPlayer.unitName + " and 5 damage to the other enemies ";


            }
            if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit1.unitName + " blocked the attack";
            }
            if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit2.unitName + " blocked the attack";
            }
            if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit3.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
    //e1 move 3
    public void EU1WaterMove3()
    {
        if (enemyUnit1.isStunned == false)
        {
            enemyMove3CD = 5;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenEnemy = enemyUnit1;
                chosenEnemyHUD = enemyHUD1;
            }
            else if (numP == 1)
            {
                chosenEnemy = enemyUnit2;
                chosenEnemyHUD = enemyHUD2;
            }
            else if (numP == 2)
            {
                chosenEnemy = enemyUnit3;
                chosenEnemyHUD = enemyHUD3;
            }

            if (chosenEnemy.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy = enemyUnit1;
                        chosenEnemyHUD = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy = enemyUnit2;
                        chosenEnemyHUD = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy = enemyUnit3;
                        chosenEnemyHUD = enemyHUD3;
                        i = 101;
                    }
                }
            }

            chosenEnemy.HealDamage(30);

            if (chosenEnemy.currentHp > chosenEnemy.maxHp)
            {
                chosenEnemy.currentHp = chosenEnemy.maxHp;
            }

            chosenEnemyHUD.SetHP(chosenEnemy.currentHp, chosenEnemy);

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Restoration Spring on the enemies " + chosenEnemy.unitName + " healing 30 Health";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
    }
    //e2 move 3
    public void EU2WaterMove3()
    {
        if (enemyUnit2.isStunned == false)
        {
            enemyMove3CD = 5;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenEnemy = enemyUnit1;
                chosenEnemyHUD = enemyHUD1;
            }
            else if (numP == 1)
            {
                chosenEnemy = enemyUnit2;
                chosenEnemyHUD = enemyHUD2;
            }
            else if (numP == 2)
            {
                chosenEnemy = enemyUnit3;
                chosenEnemyHUD = enemyHUD3;
            }

            if (chosenEnemy.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy = enemyUnit1;
                        chosenEnemyHUD = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy = enemyUnit2;
                        chosenEnemyHUD = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy = enemyUnit3;
                        chosenEnemyHUD = enemyHUD3;
                        i = 101;
                    }
                }
            }

            chosenEnemy.HealDamage(30);

            if (chosenEnemy.currentHp > chosenEnemy.maxHp)
            {
                chosenEnemy.currentHp = chosenEnemy.maxHp;
            }

            chosenEnemyHUD.SetHP(chosenEnemy.currentHp, chosenEnemy);

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Restoration Spring on the enemies " + chosenEnemy.unitName + " healing 30 Health";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        
    }
    //e3 move 3
    public void EU3WaterMove3()
    {
        if (enemyUnit3.isStunned == false)
        {
            enemyMove3CD = 5;

            int numP = Random.Range(0, 3);

            if (numP == 0)
            {
                chosenEnemy = enemyUnit1;
                chosenEnemyHUD = enemyHUD1;
            }
            else if (numP == 1)
            {
                chosenEnemy = enemyUnit2;
                chosenEnemyHUD = enemyHUD2;
            }
            else if (numP == 2)
            {
                chosenEnemy = enemyUnit3;
                chosenEnemyHUD = enemyHUD3;
            }

            if (chosenEnemy.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy = enemyUnit1;
                        chosenEnemyHUD = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy = enemyUnit2;
                        chosenEnemyHUD = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy = enemyUnit3;
                        chosenEnemyHUD = enemyHUD3;
                        i = 101;
                    }
                }
            }

            chosenEnemy.HealDamage(30);

            if (chosenEnemy.currentHp > chosenEnemy.maxHp)
            {
                chosenEnemy.currentHp = chosenEnemy.maxHp;
            }

            chosenEnemyHUD.SetHP(chosenEnemy.currentHp, chosenEnemy);

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Restoration Spring on the enemies " + chosenEnemy.unitName + " healing 30 Health";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        
    }
    //e1 move 4
    public void EU1WaterMove4()
    {
        if (enemyUnit1.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used their buff increasing healing rain heal by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 4
    public void EU2WaterMove4()
    {
        if (enemyUnit2.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit2.passiveBuff = true;

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used their buff increasing healing rain heal by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 4
    public void EU3WaterMove4()
    {
        if (enemyUnit3.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit3.passiveBuff = true;

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used their buff increasing healing rain heal by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
}
