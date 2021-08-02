using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrassMovesAI : MonoBehaviour
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
    public void GrassMoveAICD()
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
    public void ChosenGrassMoves()
    {
        if (enemyUnit1.tag == "Grass")
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

        if (enemyUnit2.tag == "Grass")
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

        if (enemyUnit3.tag == "Grass")
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
    public void EU1GrassMove1()
    {

        if(playerUnit1.isStunned == false)
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
    public void EU2GrassMove1()
    {

        if (playerUnit2.isStunned == false)
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
    public void EU3GrassMove1()
    {

        if (playerUnit3.isStunned == false)
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
    public void EU1GrassMove2()
    {

        if (playerUnit1.isStunned == false)
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

                chosenPlayer.TakeDamage(15);
                enemyUnit1.HealDamage(10);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                if (enemyUnit1.currentHp > enemyUnit1.maxHp)
                {
                    enemyUnit1.currentHp = enemyUnit1.maxHp;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);
                enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

                dialogueText.text = "Enemy " + enemyUnit1.unitName + " used Dark Osmosis on the player's " + chosenPlayer.unitName + " dealing 15 damage and absorbing 10 health";


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
    public void EU2GrassMove2()
    {

        if (playerUnit2.isStunned == false)
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

                chosenPlayer.TakeDamage(15);
                enemyUnit2.HealDamage(10);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                if (enemyUnit2.currentHp > enemyUnit2.maxHp)
                {
                    enemyUnit2.currentHp = enemyUnit2.maxHp;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);
                enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

                dialogueText.text = "Enemy " + enemyUnit2.unitName + " used Dark Osmosis on the player's " + chosenPlayer.unitName + " dealing 15 damage and absorbing 10 health";

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
    public void EU3GrassMove2()
    {

        if (playerUnit3.isStunned == false)
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

                chosenPlayer.TakeDamage(15);
                enemyUnit3.HealDamage(10);

                if (chosenPlayer.currentHp <= 0)
                {
                    chosenPlayer.currentHp = 0;
                    chosenPlayer.isDead = true;
                    chosenPlayer.justDied = true;
                }

                if (enemyUnit3.currentHp > enemyUnit3.maxHp)
                {
                    enemyUnit3.currentHp = enemyUnit3.maxHp;
                }

                chosenPlayerHUD.SetHP(chosenPlayer.currentHp, chosenPlayer);
                enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

                dialogueText.text = "Enemy " + enemyUnit3.unitName + " used Dark Osmosis on the player's " + chosenPlayer.unitName + " dealing 15 damage and absorbing 10 health";

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
    public void EU1GrassMove3()
    {
        if (playerUnit1.isStunned == false)
        {
            enemyMove3CD = 5;

            enemyUnit1.HealDamage(40);

            if (enemyUnit1.currentHp > enemyUnit1.maxHp)
            {
                enemyUnit1.currentHp = enemyUnit1.maxHp;
            }

            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

            dialogueText.text = "Enemys " + enemyUnit1.unitName + " used Photosynthesis healing 40 health";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 3
    public void EU2GrassMove3()
    {
        if (playerUnit2.isStunned == false)
        {
            enemyMove3CD = 5;

            enemyUnit2.HealDamage(40);

            if (enemyUnit2.currentHp > enemyUnit2.maxHp)
            {
                enemyUnit2.currentHp = enemyUnit2.maxHp;
            }

            enemyHUD1.SetHP(enemyUnit2.currentHp, enemyUnit2);

            dialogueText.text = "Enemys " + enemyUnit2.unitName + " used Photosynthesis healing 40 health";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 3
    public void EU3GrassMove3()
    {
        if (playerUnit3.isStunned == false)
        {
            enemyMove3CD = 5;

            enemyUnit3.HealDamage(40);

            if (enemyUnit3.currentHp > enemyUnit3.maxHp)
            {
                enemyUnit3.currentHp = enemyUnit3.maxHp;
            }

            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

            dialogueText.text = "Enemys " + enemyUnit3.unitName + " used Photosynthesis healing 40 health";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
    //e1 move 4
    public void EU1GrassMove4()
    {
        if (playerUnit1.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit1.passiveBuff = true;

            playerUnit1.unitSpd = playerUnit1.unitSpd - 2;
            playerUnit2.unitSpd = playerUnit2.unitSpd - 2;
            playerUnit3.unitSpd = playerUnit3.unitSpd - 2;

            dialogueText.text = "Enemy " + enemyUnit1.unitName + " used their buff increasing twisted roots slow by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit1.unitName + " is stunned";
            enemyUnit1.isStunned = false;
        }
        

    }
    //e2 move 4
    public void EU2GrassMove4()
    {
        if (playerUnit2.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit2.passiveBuff = true;

            playerUnit1.unitSpd = playerUnit1.unitSpd - 2;
            playerUnit2.unitSpd = playerUnit2.unitSpd - 2;
            playerUnit3.unitSpd = playerUnit3.unitSpd - 2;

            dialogueText.text = "Enemy " + enemyUnit2.unitName + " used their buff increasing twisted roots slow by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit2.unitName + " is stunned";
            enemyUnit2.isStunned = false;
        }
        

    }
    //e3 move 4
    public void EU3GrassMove4()
    {
        if (playerUnit3.isStunned == false)
        {
            enemyMove4CD = 1000;

            enemyUnit3.passiveBuff = true;

            playerUnit1.unitSpd = playerUnit1.unitSpd - 2;
            playerUnit2.unitSpd = playerUnit2.unitSpd - 2;
            playerUnit3.unitSpd = playerUnit3.unitSpd - 2;

            dialogueText.text = "Enemy " + enemyUnit3.unitName + " used their buff increasing twisted roots slow by 2";
        }
        else
        {
            dialogueText.text = "Enemy " + enemyUnit3.unitName + " is stunned";
            enemyUnit3.isStunned = false;
        }
        

    }
}
