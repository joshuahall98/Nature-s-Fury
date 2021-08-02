using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthMovesAI : MonoBehaviour
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
    public void EarthMoveAICD()
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
    public void ChosenEarthMoves()
    {
        if (enemyUnit1.tag == "Earth")
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

        if (enemyUnit2.tag == "Earth")
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

        if (enemyUnit3.tag == "Earth")
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

    //e1 move 1
    public void EU1EarthMove1()
    {

        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

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
                        chosenPlayer = playerUnit3;
                        chosenPlayerHUD = playerHUD3;
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
    public void EU2EarthMove1()
    {

        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

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
    public void EU3EarthMove1()
    {

        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

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
    public void EU1EarthMove2()
    {

        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

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
                int num = Random.Range(10, 31);

                chosenPlayer.TakeDamage(num);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Rock Slide on the player's " + chosenPlayer.unitName + " dealing " + num + " damage";

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
    public void EU2EarthMove2()
    {

        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

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
                int num = Random.Range(10, 31);

                chosenPlayer.TakeDamage(num);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Rock Slide on the player's " + chosenPlayer.unitName + " dealing " + num + " damage";

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
    public void EU3EarthMove2()
    {

        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

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
                int num = Random.Range(10, 31);

                chosenPlayer.TakeDamage(num);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Rock Slide on the player's " + chosenPlayer.unitName + " dealing " + num + " damage";

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
    public void EU1EarthMove3()
    {
        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

        if (enemyUnit1.isStunned == false)
        {
            enemyMove3CD = 4;

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
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy = enemyUnit2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy = enemyUnit3;
                        i = 101;
                    }
                }
            }

            chosenEnemy.isBlocking = true;

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Rock Shield on the enemy " + chosenEnemy.unitName;
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        
    }
    //e2 move 3
    public void EU2EarthMove3()
    {
        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

        if (enemyUnit2.isStunned == false)
        {
            enemyMove3CD = 4;

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
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy = enemyUnit2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy = enemyUnit3;
                        i = 101;
                    }
                }
            }

            chosenEnemy.isBlocking = true;

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Rock Shield on the enemy " + chosenEnemy.unitName;
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }

       
    }
    //e3 move 3
    public void EU3EarthMove3()
    {
        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

        if (enemyUnit3.isStunned == false)
        {
            enemyMove3CD = 4;

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
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy = enemyUnit2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy = enemyUnit3;
                        i = 101;
                    }
                }
            }

            chosenEnemy.isBlocking = true;

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Rock Shield on the enemy " + chosenEnemy.unitName;
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        
    }
    //e1 move 4
    public void EU1EarthMove4()
    {
        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

        if (enemyUnit1.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            enemyUnit1.maxHp = enemyUnit1.maxHp + 10;
            enemyUnit1.currentHp = enemyUnit1.currentHp + 10;
            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

            enemyUnit2.maxHp = enemyUnit2.maxHp + 10;
            enemyUnit2.currentHp = enemyUnit2.currentHp + 10;
            enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

            enemyUnit3.maxHp = enemyUnit3.maxHp + 10;
            enemyUnit3.currentHp = enemyUnit3.currentHp + 10;
            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used their buff increasing rock shield health by 10";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 4
    public void EU2EarthMove4()
    {
        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

        if (enemyUnit2.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            enemyUnit1.maxHp = enemyUnit1.maxHp + 10;
            enemyUnit1.currentHp = enemyUnit1.currentHp + 10;
            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

            enemyUnit2.maxHp = enemyUnit2.maxHp + 10;
            enemyUnit2.currentHp = enemyUnit2.currentHp + 10;
            enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

            enemyUnit3.maxHp = enemyUnit3.maxHp + 10;
            enemyUnit3.currentHp = enemyUnit3.currentHp + 10;
            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used their buff increasing rock shield health by 10";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 4
    public void EU3EarthMove4()
    {
        enemyUnit1.isBlocking = false;
        enemyUnit2.isBlocking = false;
        enemyUnit3.isBlocking = false;

        if (enemyUnit3.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            enemyUnit1.maxHp = enemyUnit1.maxHp + 10;
            enemyUnit1.currentHp = enemyUnit1.currentHp + 10;
            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

            enemyUnit2.maxHp = enemyUnit2.maxHp + 10;
            enemyUnit2.currentHp = enemyUnit2.currentHp + 10;
            enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

            enemyUnit3.maxHp = enemyUnit3.maxHp + 10;
            enemyUnit3.currentHp = enemyUnit3.currentHp + 10;
            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used their buff increasing rock shield health by 10";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
}
