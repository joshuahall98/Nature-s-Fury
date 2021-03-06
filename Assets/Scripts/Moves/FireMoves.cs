using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireMoves : MonoBehaviour
{
    public GameObject battleSystem;

    Unit playerUnit1;
    Unit playerUnit2;
    Unit playerUnit3;

    Unit enemyUnit1;
    Unit enemyUnit2;
    Unit enemyUnit3;

    Unit chosenEnemy1;
    Unit chosenEnemy2;
    Unit chosenEnemy3;

    public BattleHUD playerHUD1;
    public BattleHUD playerHUD2;
    public BattleHUD playerHUD3;

    public BattleHUD enemyHUD1;
    public BattleHUD enemyHUD2;
    public BattleHUD enemyHUD3;

    public BattleHUD chosenEnemyHUD1;
    public BattleHUD chosenEnemyHUD2;
    public BattleHUD chosenEnemyHUD3;

    public int playerMove1CD = 0;
    public int playerMove2CD = 0;
    public int playerMove3CD = 0;
    public int playerMove4CD = 0;

    public int hyperBurnBuff = 0;

    public Button playerUnitBtn1;
    public Button playerUnitBtn2;
    public Button playerUnitBtn3;

    public Button enemyUnitBtn1;
    public Button enemyUnitBtn2;
    public Button enemyUnitBtn3;

    public GameObject playerUnitTxt1;
    public GameObject playerUnitTxt2;
    public GameObject playerUnitTxt3;

    public GameObject enemyUnitTxt1;
    public GameObject enemyUnitTxt2;
    public GameObject enemyUnitTxt3;

    public Button move1btn;
    public Button move2btn;
    public Button move3btn;
    public Button move4btn;
    public Button move5btn;
    public Button move6btn;
    public Button move7btn;
    public Button move8btn;
    public Button move9btn;
    public Button move10btn;
    public Button move11btn;
    public Button move12btn;

    public GameObject move1txt;
    public GameObject move2txt;
    public GameObject move3txt;
    public GameObject move4txt;
    public GameObject move5txt;
    public GameObject move6txt;
    public GameObject move7txt;
    public GameObject move8txt;
    public GameObject move9txt;
    public GameObject move10txt;
    public GameObject move11txt;
    public GameObject move12txt;

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

        chosenEnemy1 = GetComponent<BattleSystem>().chosenEnemy1;
        chosenEnemy2 = GetComponent<BattleSystem>().chosenEnemy2;
        chosenEnemy3 = GetComponent<BattleSystem>().chosenEnemy3;

        chosenEnemyHUD1 = GetComponent<BattleSystem>().chosenEnemyHUD1;
        chosenEnemyHUD2 = GetComponent<BattleSystem>().chosenEnemyHUD2;
        chosenEnemyHUD3 = GetComponent<BattleSystem>().chosenEnemyHUD3;
    }


    //MOVE CDS
    public void FireMoveCD()
    {
        //p1 move cd
        if (playerUnit1.tag == "Fire")
        {
            //move 1 cd
            if (playerMove1CD >= 1)
            {
                move1btn.enabled = false;
                move1txt.GetComponent<ChangeTextColor>().redColor();
                playerMove1CD = playerMove1CD - 1;
                if (playerMove1CD <= 0)
                {
                    move1txt.GetComponent<ChangeTextColor>().greenColor();
                    move1btn.enabled = true;
                }
            }
            else if (playerMove1CD <= 0)
            {
                move1txt.GetComponent<ChangeTextColor>().greenColor();
                move1btn.enabled = true;
            }
            //move 2 cd
            if (playerMove2CD >= 1)
            {
                move2btn.enabled = false;
                move2txt.GetComponent<ChangeTextColor>().redColor();
                playerMove2CD = playerMove2CD - 1;
                if (playerMove2CD <= 0)
                {
                    move2txt.GetComponent<ChangeTextColor>().greenColor();
                    move2btn.enabled = true;
                }
            }
            else if (playerMove2CD <= 0)
            {
                move2txt.GetComponent<ChangeTextColor>().greenColor();
                move2btn.enabled = true;
            }
            //move 3 cd
            if (playerMove3CD >= 1)
            {
                move3btn.enabled = false;
                move3txt.GetComponent<ChangeTextColor>().redColor();
                playerMove3CD = playerMove3CD - 1;
                if (playerMove3CD <= 0)
                {
                    move3txt.GetComponent<ChangeTextColor>().greenColor();
                    move3btn.enabled = true;
                }
            }
            else if (playerMove3CD <= 0)
            {
                move3txt.GetComponent<ChangeTextColor>().greenColor();
                move3btn.enabled = true;
            }
            //move 4 cd
            if (playerMove4CD >= 1)
            {
                move4btn.enabled = false;
                move4txt.GetComponent<ChangeTextColor>().redColor();
                playerMove4CD = playerMove4CD - 1;
                if (playerMove4CD <= 0)
                {
                    move4txt.GetComponent<ChangeTextColor>().greenColor();
                    move4btn.enabled = true;
                }
            }
            else if (playerMove4CD <= 0)
            {
                move4txt.GetComponent<ChangeTextColor>().greenColor();
                move4btn.enabled = true;
            }
        }
        //p2 move cd
        if (playerUnit2.tag == "Fire")
        {
            //move 1 cd
            if (playerMove1CD >= 1)
            {
                move5btn.enabled = false;
                move5txt.GetComponent<ChangeTextColor>().redColor();
                playerMove1CD = playerMove1CD - 1;
                if (playerMove1CD <= 0)
                {
                    move5txt.GetComponent<ChangeTextColor>().greenColor();
                    move5btn.enabled = true;
                }
            }
            else if (playerMove1CD <= 0)
            {
                move5txt.GetComponent<ChangeTextColor>().greenColor();
                move5btn.enabled = true;
            }
            //move 2 cd
            if (playerMove2CD >= 1)
            {
                move6btn.enabled = false;
                move6txt.GetComponent<ChangeTextColor>().redColor();
                playerMove2CD = playerMove2CD - 1;
                if (playerMove2CD <= 0)
                {
                    move6txt.GetComponent<ChangeTextColor>().greenColor();
                    move6btn.enabled = true;
                }
            }
            else if (playerMove2CD <= 0)
            {
                move6txt.GetComponent<ChangeTextColor>().greenColor();
                move6btn.enabled = true;
            }
            //move 3 cd
            if (playerMove3CD >= 1)
            {
                move7btn.enabled = false;
                move7txt.GetComponent<ChangeTextColor>().redColor();
                playerMove3CD = playerMove3CD - 1;
                if (playerMove3CD <= 0)
                {
                    move7txt.GetComponent<ChangeTextColor>().greenColor();
                    move7btn.enabled = true;
                }
            }
            else if (playerMove3CD <= 0)
            {
                move7txt.GetComponent<ChangeTextColor>().greenColor();
                move7btn.enabled = true;
            }
            //move 4 cd
            if (playerMove4CD >= 1)
            {
                move8btn.enabled = false;
                move8txt.GetComponent<ChangeTextColor>().redColor();
                playerMove4CD = playerMove4CD - 1;
                if (playerMove4CD <= 0)
                {
                    move8txt.GetComponent<ChangeTextColor>().greenColor();
                    move8btn.enabled = true;
                }
            }
            else if (playerMove4CD <= 0)
            {
                move8txt.GetComponent<ChangeTextColor>().greenColor();
                move8btn.enabled = true;
            }
        }
        //p3 move cd
        if (playerUnit3.tag == "Fire")
        {
            //move 1 cd
            if (playerMove1CD >= 1)
            {
                move9btn.enabled = false;
                move9txt.GetComponent<ChangeTextColor>().redColor();
                playerMove1CD = playerMove1CD - 1;
                if (playerMove1CD <= 0)
                {
                    move9txt.GetComponent<ChangeTextColor>().greenColor();
                    move9btn.enabled = true;
                }
            }
            else if (playerMove1CD <= 0)
            {
                move9txt.GetComponent<ChangeTextColor>().greenColor();
                move9btn.enabled = true;
            }
            //move 2 cd
            if (playerMove2CD >= 1)
            {
                move10btn.enabled = false;
                move10txt.GetComponent<ChangeTextColor>().redColor();
                playerMove2CD = playerMove2CD - 1;
                if (playerMove2CD <= 0)
                {
                    move10txt.GetComponent<ChangeTextColor>().greenColor();
                    move10btn.enabled = true;
                }
            }
            else if (playerMove2CD <= 0)
            {
                move10txt.GetComponent<ChangeTextColor>().greenColor();
                move10btn.enabled = true;
            }
            //move 3 cd
            if (playerMove3CD >= 1)
            {
                move11btn.enabled = false;
                move11txt.GetComponent<ChangeTextColor>().redColor();
                playerMove3CD = playerMove3CD - 1;
                if (playerMove3CD <= 0)
                {
                    move11txt.GetComponent<ChangeTextColor>().greenColor();
                    move11btn.enabled = true;
                }
            }
            else if (playerMove3CD <= 0)
            {
                move11txt.GetComponent<ChangeTextColor>().greenColor();
                move11btn.enabled = true;
            }
            //move 4 cd
            if (playerMove4CD >= 1)
            {
                move12btn.enabled = false;
                move12txt.GetComponent<ChangeTextColor>().redColor();
                playerMove4CD = playerMove4CD - 1;
                if (playerMove4CD <= 0)
                {
                    move12txt.GetComponent<ChangeTextColor>().greenColor();
                    move12btn.enabled = true;
                }
            }
            else if (playerMove4CD <= 0)
            {
                move12txt.GetComponent<ChangeTextColor>().greenColor();
                move12btn.enabled = true;
            }
        }

        //ability buff cd
        hyperBurnBuff = hyperBurnBuff + 1;
    }


    //MOVES
    //p1 move 1
    public void PU1FireMove1Btn()
    {
        if(playerUnit1.isStunned == false)
        {
            playerMove1CD = 1;

            if (chosenEnemy1.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit1;
                        chosenEnemyHUD1 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit2;
                        chosenEnemyHUD1 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit3;
                        chosenEnemyHUD1 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenEnemy1.isBlocking == false)
            {
                chosenEnemy1.TakeDamage(playerUnit1.unitAtk);

                if (chosenEnemy1.tag == "Fire")
                {
                    chosenEnemy1.isBurned = false;
                }
                else
                {
                    chosenEnemy1.isBurned = true;
                }

                if (chosenEnemy1.currentHp <= 0)
                {
                    chosenEnemy1.currentHp = 0;
                    chosenEnemy1.isDead = true;
                    chosenEnemy1.justDied = true;
                }

                chosenEnemyHUD1.SetHP(chosenEnemy1.currentHp, chosenEnemy1);

                dialogueText.text = "Player's " + playerUnit1.unitName + " used Attack on the enemy " + chosenEnemy1.unitName + " dealing " + playerUnit1.unitAtk + " damage";

            }
            else if (chosenEnemy1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy1.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit1.unitName + " is stunned";
            playerUnit1.isStunned = false;
        }
        
    }
    //p2 move 1
    public void PU2FireMove1Btn()
    {

        if(playerUnit2.isStunned == false)
        {
            playerMove1CD = 1;

            if (chosenEnemy2.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit1;
                        chosenEnemyHUD2 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit2;
                        chosenEnemyHUD2 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit3;
                        chosenEnemyHUD2 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenEnemy2.isBlocking == false)
            {
                chosenEnemy2.TakeDamage(playerUnit2.unitAtk);

                if (chosenEnemy2.tag == "Fire")
                {
                    chosenEnemy2.isBurned = false;
                }
                else
                {
                    chosenEnemy2.isBurned = true;
                }

                if (chosenEnemy2.currentHp <= 0)
                {
                    chosenEnemy2.currentHp = 0;
                    chosenEnemy2.isDead = true;
                    chosenEnemy2.justDied = true;
                }

                chosenEnemyHUD2.SetHP(chosenEnemy2.currentHp, chosenEnemy2);

                dialogueText.text = "Player's " + playerUnit2.unitName + " used Attack on the enemy " + chosenEnemy2.unitName + " dealing " + playerUnit2.unitAtk + " damage";

            }
            else if (chosenEnemy2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy2.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit2.unitName + " is stunned";
            playerUnit2.isStunned = false;
        }
           
    }
    //p3 move 1
    public void PU3FireMove1Btn()
    {
        if (playerUnit3.isStunned == false)
        {
            playerMove1CD = 1;

            if (chosenEnemy3.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit1;
                        chosenEnemyHUD3 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit2;
                        chosenEnemyHUD3 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit3;
                        chosenEnemyHUD3 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenEnemy3.isBlocking == false)
            {
                chosenEnemy3.TakeDamage(playerUnit3.unitAtk);

                if (chosenEnemy3.tag == "Fire")
                {
                    chosenEnemy3.isBurned = false;
                }
                else
                {
                    chosenEnemy3.isBurned = true;
                }

                if (chosenEnemy3.currentHp <= 0)
                {
                    chosenEnemy3.currentHp = 0;
                    chosenEnemy3.isDead = true;
                    chosenEnemy3.justDied = true;
                }

                chosenEnemyHUD3.SetHP(chosenEnemy3.currentHp, chosenEnemy3);

                dialogueText.text = "Player's " + playerUnit3.unitName + " used Attack on the enemy " + chosenEnemy3.unitName + " dealing " + playerUnit3.unitAtk + " damage";

            }
            else if (chosenEnemy3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy3.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit3.unitName + " is stunned";
            playerUnit3.isStunned = false;
        }

        

    }
    //p1 move 2
    public void PU1FireMove2Btn()
    {

        if (playerUnit1.isStunned == false)
        {
            playerMove2CD = 1;

            if (chosenEnemy1.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit1;
                        chosenEnemyHUD1 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit2;
                        chosenEnemyHUD1 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit3;
                        chosenEnemyHUD1 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            hyperBurnBuff = hyperBurnBuff * 10;

            if (chosenEnemy1.isBlocking == false)
            {
                chosenEnemy1.TakeDamage(hyperBurnBuff);

                if (chosenEnemy1.tag == "Fire")
                {
                    chosenEnemy1.isBurned = false;
                }
                else
                {
                    chosenEnemy1.isBurned = true;
                }

                if (chosenEnemy1.currentHp <= 0)
                {
                    chosenEnemy1.currentHp = 0;
                    chosenEnemy1.isDead = true;
                    chosenEnemy1.justDied = true;
                }

                chosenEnemyHUD1.SetHP(chosenEnemy1.currentHp, chosenEnemy1);

                dialogueText.text = "Player's " + playerUnit1.unitName + " used Hyper Burn on the enemy " + chosenEnemy1.unitName + " dealing " + hyperBurnBuff + " damage";

                hyperBurnBuff = 0;

            }
            else if (chosenEnemy1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy1.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit1.unitName + " is stunned";
            playerUnit1.isStunned = false;
        }
        

    }
    //p2 move 2
    public void PU2FireMove2Btn()
    {

        if (playerUnit2.isStunned == false)
        {
            playerMove2CD = 1;

            if (chosenEnemy2.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit1;
                        chosenEnemyHUD2 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit2;
                        chosenEnemyHUD2 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit3;
                        chosenEnemyHUD2 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            hyperBurnBuff = hyperBurnBuff * 10;

            if (chosenEnemy2.isBlocking == false)
            {

                chosenEnemy2.TakeDamage(hyperBurnBuff);

                if (chosenEnemy2.tag == "Fire")
                {
                    chosenEnemy2.isBurned = false;
                }
                else
                {
                    chosenEnemy2.isBurned = true;
                }

                if (chosenEnemy2.currentHp <= 0)
                {
                    chosenEnemy2.currentHp = 0;
                    chosenEnemy2.isDead = true;
                    chosenEnemy2.justDied = true;
                }

                chosenEnemyHUD2.SetHP(chosenEnemy2.currentHp, chosenEnemy2);

                dialogueText.text = "Player's " + playerUnit2.unitName + " used Hyper Burn on the enemy " + chosenEnemy2.unitName + " dealing " + hyperBurnBuff + " damage";

                hyperBurnBuff = 0;
            }
            else if (chosenEnemy2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy2.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit2.unitName + " is stunned";
            playerUnit2.isStunned = false;
        }
        

    }
    //p3 move 2
    public void PU3FireMove2Btn()
    {

        if (playerUnit3.isStunned == false)
        {
            playerMove2CD = 1;

            if (chosenEnemy3.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit1;
                        chosenEnemyHUD3 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit2;
                        chosenEnemyHUD3 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit3;
                        chosenEnemyHUD3 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            hyperBurnBuff = hyperBurnBuff * 10;

            if (chosenEnemy3.isBlocking == false)
            {
                chosenEnemy3.TakeDamage(hyperBurnBuff);

                if (chosenEnemy3.tag == "Fire")
                {
                    chosenEnemy3.isBurned = false;
                }
                else
                {
                    chosenEnemy3.isBurned = true;
                }

                if (chosenEnemy3.currentHp <= 0)
                {
                    chosenEnemy3.currentHp = 0;
                    chosenEnemy3.isDead = true;
                    chosenEnemy3.justDied = true;
                }

                chosenEnemyHUD3.SetHP(chosenEnemy3.currentHp, chosenEnemy3);

                dialogueText.text = "Player's " + playerUnit3.unitName + " used Hyper Burn on the enemy " + chosenEnemy3.unitName + " dealing " + hyperBurnBuff + " damage";

                hyperBurnBuff = 0;

            }
            else if (chosenEnemy3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy3.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit3.unitName + " is stunned";
            playerUnit3.isStunned = false;
        }
        
       
    }
    //p1 move 3
    public void PU1FireMove3Btn()
    {
        playerMove3CD = 3;

        if (playerUnit1.isStunned == false)
        {
            if (chosenEnemy1.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit1;
                        chosenEnemyHUD1 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit2;
                        chosenEnemyHUD1 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy1 = enemyUnit3;
                        chosenEnemyHUD1 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenEnemy1.isBlocking == false)
            {
                chosenEnemy1.TakeDamage(25);

                if (playerUnit1.isBlocking == false)
                {
                    playerUnit1.TakeDamage(15);
                }

                if (chosenEnemy1.tag == "Fire")
                {
                    chosenEnemy1.isBurned = false;
                }
                else
                {
                    chosenEnemy1.isBurned = true;
                }

                if (chosenEnemy1.currentHp <= 0)
                {
                    chosenEnemy1.currentHp = 0;
                    chosenEnemy1.isDead = true;
                    chosenEnemy1.justDied = true;
                }
                else if (playerUnit1.currentHp <= 0)
                {
                    playerUnit1.currentHp = 0;
                    playerUnit1.isDead = true;
                    playerUnit1.justDied = true;
                }

                chosenEnemyHUD1.SetHP(chosenEnemy1.currentHp, chosenEnemy1);
                playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);

                if (playerUnit1.isBlocking == false)
                {
                    dialogueText.text = "Player's " + playerUnit1.unitName + " used Inferno on the enemy " + chosenEnemy1.unitName + " dealing 25 damage and receiving 15 damage";
                }
                else if (playerUnit1.isBlocking == true)
                {
                    dialogueText.text = "Player's " + playerUnit1.unitName + " used Inferno on the enemy " + chosenEnemy1.unitName + " dealing 25 damage and blocked the recoil damage";
                }


            }
            else if (chosenEnemy1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy1.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit1.unitName + " is stunned";
            playerUnit1.isStunned = false;
        }
        

        
    }
    //p2 move 3
    public void PU2FireMove3Btn()
    {
        if (playerUnit2.isStunned == false)
        {
            playerMove3CD = 3;

            if (chosenEnemy2.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit1;
                        chosenEnemyHUD2 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit2;
                        chosenEnemyHUD2 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy2 = enemyUnit3;
                        chosenEnemyHUD2 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenEnemy2.isBlocking == false)
            {
                chosenEnemy2.TakeDamage(25);

                if (playerUnit2.isBlocking == false)
                {
                    playerUnit2.TakeDamage(15);
                }

                if (chosenEnemy2.tag == "Fire")
                {
                    chosenEnemy2.isBurned = false;
                }
                else
                {
                    chosenEnemy2.isBurned = true;
                }

                if (chosenEnemy2.currentHp < 0)
                {
                    chosenEnemy2.currentHp = 0;
                    chosenEnemy2.isDead = true;
                    chosenEnemy2.justDied = true;
                }
                else if (playerUnit2.currentHp <= 0)
                {
                    playerUnit2.currentHp = 0;
                    playerUnit2.isDead = true;
                    playerUnit2.justDied = true;
                }

                chosenEnemyHUD2.SetHP(chosenEnemy2.currentHp, chosenEnemy2);
                playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);

                if (playerUnit2.isBlocking == false)
                {
                    dialogueText.text = "Player's " + playerUnit2.unitName + " used Inferno on the enemy " + chosenEnemy2.unitName + " dealing 25 damage and receiving 15 damage";
                }
                else if (playerUnit2.isBlocking == true)
                {
                    dialogueText.text = "Player's " + playerUnit2.unitName + " used Inferno on the enemy " + chosenEnemy2.unitName + " dealing 25 damage and blocked the recoil damage";
                }

            }
            else if (chosenEnemy2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy2.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit2.unitName + " is stunned";
            playerUnit2.isStunned = false;
        }
         
    }
    //p3 move 3
    public void PU3FireMove3Btn()
    {
        if (playerUnit3.isStunned == false)
        {
            playerMove3CD = 3;

            if (chosenEnemy3.isDead == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    int num = Random.Range(0, 3);

                    if (num == 0 && enemyUnit1.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit1;
                        chosenEnemyHUD3 = enemyHUD1;
                        i = 101;
                    }
                    if (num == 1 && enemyUnit2.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit2;
                        chosenEnemyHUD3 = enemyHUD2;
                        i = 101;
                    }
                    if (num == 2 && enemyUnit3.isDead == false)
                    {
                        chosenEnemy3 = enemyUnit3;
                        chosenEnemyHUD3 = enemyHUD3;
                        i = 101;
                    }
                }
            }

            if (chosenEnemy3.isBlocking == false)
            {
                chosenEnemy3.TakeDamage(25);

                if (playerUnit3.isBlocking == false)
                {
                    playerUnit3.TakeDamage(15);
                }

                if (chosenEnemy3.tag == "Fire")
                {
                    chosenEnemy3.isBurned = false;
                }
                else
                {
                    chosenEnemy3.isBurned = true;
                }

                if (chosenEnemy3.currentHp < 0)
                {
                    chosenEnemy3.currentHp = 0;
                    chosenEnemy3.isDead = true;
                    chosenEnemy3.justDied = true;
                }
                else if (playerUnit3.currentHp <= 0)
                {
                    playerUnit3.currentHp = 0;
                    playerUnit3.isDead = true;
                    playerUnit3.justDied = true;
                }

                chosenEnemyHUD3.SetHP(chosenEnemy3.currentHp, chosenEnemy3);
                playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);

                if (playerUnit3.isBlocking == false)
                {
                    dialogueText.text = "Player's " + playerUnit3.unitName + " used Inferno on the enemy " + chosenEnemy3.unitName + " dealing 25 damage and receiving 15 damage";
                }
                else if (playerUnit3.isBlocking == true)
                {
                    dialogueText.text = "Player's " + playerUnit3.unitName + " used Inferno on the enemy " + chosenEnemy3.unitName + " dealing 25 damage and blocked the recoil damage";
                }


            }
            else if (chosenEnemy3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + chosenEnemy3.unitName + " blocked the attack";
            }
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit3.unitName + " is stunned";
            playerUnit3.isStunned = false;
        }
         
    }
    //p1 move 4
    public void PU1FireMove4Btn()
    {
        if (playerUnit1.isStunned == false)
        {
            playerMove4CD = 1000;

            playerUnit1.passiveBuff = true;

            dialogueText.text = "Player's " + playerUnit1.unitName + " used their buff increasing burn damage by 2";

        }
        else
        {
            dialogueText.text = "Player's " + playerUnit1.unitName + " is stunned";
            playerUnit1.isStunned = false;
        }
       
    }
    //p2 move 4
    public void PU2FireMove4Btn()
    {
        if (playerUnit2.isStunned == false)
        {
            playerMove4CD = 1000;

            playerUnit2.passiveBuff = true;

            dialogueText.text = "Player's " + playerUnit2.unitName + " used their buff increasing burn damage by 2";
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit2.unitName + " is stunned";
            playerUnit2.isStunned = false;
        }
       

    }
    //p3 move 4
    public void PU3FireMove4Btn()
    {
        if (playerUnit3.isStunned == false)
        {
            playerMove4CD = 1000;

            playerUnit3.passiveBuff = true;

            dialogueText.text = "Player's " + playerUnit3.unitName + " used their buff increasing burn damage by 2";
        }
        else
        {
            dialogueText.text = "Player's " + playerUnit3.unitName + " is stunned";
            playerUnit3.isStunned = false;
        }
       

    }
}
