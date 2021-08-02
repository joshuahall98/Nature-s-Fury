using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleEffects : MonoBehaviour
{
    public GameObject battleSystem;

    Unit playerUnit1;
    Unit playerUnit2;
    Unit playerUnit3;

    Unit enemyUnit1;
    Unit enemyUnit2;
    Unit enemyUnit3;

    public int burnDamage = 2;
    public int waterHeal = 2;

    public BattleHUD playerHUD1;
    public BattleHUD playerHUD2;
    public BattleHUD playerHUD3;

    public BattleHUD enemyHUD1;
    public BattleHUD enemyHUD2;
    public BattleHUD enemyHUD3;

    public Text dialogueText;


    public void GetObjects()
    {
        playerUnit1 = GetComponent<BattleSystem>().playerUnit1;
        playerUnit2 = GetComponent<BattleSystem>().playerUnit2;
        playerUnit3 = GetComponent<BattleSystem>().playerUnit3;

        enemyUnit1 = GetComponent<BattleSystem>().enemyUnit1;
        enemyUnit2 = GetComponent<BattleSystem>().enemyUnit2;
        enemyUnit3 = GetComponent<BattleSystem>().enemyUnit3;

        playerHUD1 = GetComponent<BattleSystem>().playerHUD1;
        playerHUD2 = GetComponent<BattleSystem>().playerHUD2;
        playerHUD3 = GetComponent<BattleSystem>().playerHUD3;

        enemyHUD1 = GetComponent<BattleSystem>().enemyHUD1;
        enemyHUD2 = GetComponent<BattleSystem>().enemyHUD2;
        enemyHUD3 = GetComponent<BattleSystem>().enemyHUD3;


    }

    //START GAME PASSIVES
    public void StartGamePassive()
    {
        EarthHPIncrease();
        TwistedRoots();
        HurricaneWinds();
    }

    //earth passive
    public void EarthHPIncrease()
    {
        if(playerUnit1.tag == "Earth" || playerUnit2.tag == "Earth" || playerUnit3.tag == "Earth")
        {
            playerUnit1.maxHp = playerUnit1.maxHp + 10;
            playerUnit1.currentHp = playerUnit1.currentHp + 10;
            playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);

            playerUnit2.maxHp = playerUnit2.maxHp + 10;
            playerUnit2.currentHp = playerUnit2.currentHp + 10;
            playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);

            playerUnit3.maxHp = playerUnit3.maxHp + 10;
            playerUnit3.currentHp = playerUnit3.currentHp + 10;
            playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);
        }

        if(enemyUnit1.tag == "Earth" || enemyUnit2.tag == "Earth" || enemyUnit3.tag == "Earth")
        {
            enemyUnit1.maxHp = enemyUnit1.maxHp + 10;
            enemyUnit1.currentHp = enemyUnit1.currentHp + 10;
            enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

            enemyUnit2.maxHp = enemyUnit2.maxHp + 10;
            enemyUnit2.currentHp = enemyUnit2.currentHp + 10;
            enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

            enemyUnit3.maxHp = enemyUnit3.maxHp + 10;
            enemyUnit3.currentHp = enemyUnit3.currentHp + 10;
            enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);
        }
        
    }

    //grass passive
    public void TwistedRoots()
    {
        if (playerUnit1.tag == "Grass" || playerUnit2.tag == "Grass" || playerUnit3.tag == "Grass")
        {
            enemyUnit1.unitSpd = enemyUnit1.unitSpd - 1;
            enemyUnit2.unitSpd = enemyUnit2.unitSpd - 1;
            enemyUnit3.unitSpd = enemyUnit3.unitSpd - 1;
        }

        if (enemyUnit1.tag == "Grass" || enemyUnit2.tag == "Grass" || enemyUnit3.tag == "Grass")
        {
            playerUnit1.unitSpd = playerUnit1.unitSpd - 1;
            playerUnit2.unitSpd = playerUnit2.unitSpd - 1;
            playerUnit3.unitSpd = playerUnit3.unitSpd - 1;
        }
    }

    //wind passive
    public void HurricaneWinds()
    {
        if (playerUnit1.tag == "Wind" || playerUnit2.tag == "Wind" || playerUnit3.tag == "Wind")
        {
            playerUnit1.unitSpd = playerUnit1.unitSpd + 1;
            playerUnit2.unitSpd = playerUnit2.unitSpd + 1;
            playerUnit3.unitSpd = playerUnit3.unitSpd + 1;
        }

        if (enemyUnit1.tag == "Wind" || enemyUnit2.tag == "Wind" || enemyUnit3.tag == "Wind")
        {
            enemyUnit1.unitSpd = enemyUnit1.unitSpd + 1;
            enemyUnit2.unitSpd = enemyUnit2.unitSpd + 1;
            enemyUnit3.unitSpd = enemyUnit3.unitSpd + 1;
        }
    }


    //END TURN PASSIVES
    public void EndTurnPassive()
    {
        StartCoroutine(IsBurned());   
    }

    //fire passive
    IEnumerator IsBurned()
    {

        if (playerUnit1.isBurned == true && playerUnit1.isDead == false)
        {
            if(playerUnit1.isBlocking == false)
            {
                yield return new WaitForSeconds(3f);

                playerUnit1.TakeDamage(2);
                int num = 2;

                if (enemyUnit1.tag == "Fire" && enemyUnit1.passiveBuff == true)
                {
                    playerUnit1.TakeDamage(2);
                    num = 4;
                }
                if (enemyUnit2.tag == "Fire" && enemyUnit2.passiveBuff == true)
                {
                    playerUnit1.TakeDamage(2);
                    num = 4;
                }
                if (enemyUnit3.tag == "Fire" && enemyUnit3.passiveBuff == true)
                {
                    playerUnit1.TakeDamage(2);
                    num = 4;
                }
                
                if(playerUnit1.currentHp <= 0)
                {
                    playerUnit1.currentHp = 0;
                    playerUnit1.isDead = true;
                }

                playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);

                dialogueText.text = "Player's " + playerUnit1.unitName + " took "+num+" burn damage";

                if(playerUnit1.isDead == true)
                {
                    yield return new WaitForSeconds(3f);
                    dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
                }
            }
            else if (playerUnit1.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit1.unitName + " blocked the burn damage";
            }

        }

        if (playerUnit2.isBurned == true && playerUnit2.isDead == false)
        {

            if(playerUnit2.isBlocking == false)
            {
                yield return new WaitForSeconds(3f);

                playerUnit2.TakeDamage(2);

                int num = 2;

                if (enemyUnit1.tag == "Fire" && enemyUnit1.passiveBuff == true)
                {
                    playerUnit2.TakeDamage(2);
                    num = 4;
                }
                if (enemyUnit2.tag == "Fire" && enemyUnit2.passiveBuff == true)
                {
                    playerUnit2.TakeDamage(2);
                    num = 4;
                }
                if (enemyUnit3.tag == "Fire" && enemyUnit3.passiveBuff == true)
                {
                    playerUnit2.TakeDamage(2);
                    num = 4;
                }

                if (playerUnit2.currentHp <= 0)
                {
                    playerUnit2.currentHp = 0;
                    playerUnit2.isDead = true;
                }

                playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);

                dialogueText.text = "Player's " + playerUnit2.unitName + " took "+num+" burn damage";

                if (playerUnit2.isDead == true)
                {
                    yield return new WaitForSeconds(3f);
                    dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
                }
            }
            else if (playerUnit2.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit2.unitName + " blocked the burn damage";
            }

        }

        if (playerUnit3.isBurned == true && playerUnit3.isDead == false)
        {
            if (playerUnit3.isBlocking == false)
            {
                yield return new WaitForSeconds(3f);

                playerUnit3.TakeDamage(2);
                int num = 2;

                if (enemyUnit1.tag == "Fire" && enemyUnit1.passiveBuff == true)
                {
                    playerUnit3.TakeDamage(2);
                    num = 4;
                }
                if (enemyUnit2.tag == "Fire" && enemyUnit2.passiveBuff == true)
                {
                    playerUnit3.TakeDamage(2);
                    num = 4;
                }
                if (enemyUnit3.tag == "Fire" && enemyUnit3.passiveBuff == true)
                {
                    playerUnit3.TakeDamage(2);
                    num = 4;
                }

                if (playerUnit3.currentHp <= 0)
                {
                    playerUnit3.currentHp = 0;
                    playerUnit3.isDead = true;
                }

                playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);

                dialogueText.text = "Player's " + playerUnit3.unitName + " took " +num+" burn damage";

                if (playerUnit3.isDead == true)
                {
                    yield return new WaitForSeconds(3f);
                    dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
                }
            }
            else if (playerUnit3.isBlocking == true)
            {
                dialogueText.text = "Player's " + playerUnit3.unitName + " blocked the burn damage";
            }

        }

        if (enemyUnit1.isBurned == true && enemyUnit1.isDead == false)
        {
            if (enemyUnit1.isBlocking == false)
            {
                yield return new WaitForSeconds(3f);

                enemyUnit1.TakeDamage(2);
                int num = 2;

                if (playerUnit1.tag == "Fire" && playerUnit1.passiveBuff == true)
                {
                    enemyUnit1.TakeDamage(2);
                    num = 4;
                }
                if (playerUnit2.tag == "Fire" && playerUnit2.passiveBuff == true)
                {
                    enemyUnit1.TakeDamage(2);
                    num = 4;
                }
                if (playerUnit3.tag == "Fire" && playerUnit3.passiveBuff == true)
                {
                    enemyUnit1.TakeDamage(2);
                    num = 4;
                }

                if (enemyUnit1.currentHp <= 0)
                {
                    enemyUnit1.currentHp = 0;
                    enemyUnit1.isDead = true;
                }

                enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);

                dialogueText.text = "The enemy " + enemyUnit1.unitName + " took "+num+" burn damage";

                if (enemyUnit1.isDead == true)
                {
                    yield return new WaitForSeconds(3f);
                    dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
                }
            }
            else if (enemyUnit1.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit1.unitName + " blocked the burn damage";
            }

        }

        if (enemyUnit2.isBurned == true && enemyUnit2.isDead == false)
        {
            if (enemyUnit2.isBlocking == false)
            {
                yield return new WaitForSeconds(3f);

                enemyUnit2.TakeDamage(2);
                int num = 2;

                if (playerUnit1.tag == "Fire" && playerUnit1.passiveBuff == true)
                {
                    enemyUnit2.TakeDamage(2);
                    num = 4;
                }
                if (playerUnit2.tag == "Fire" && playerUnit2.passiveBuff == true)
                {
                    enemyUnit2.TakeDamage(2);
                    num = 4;
                }
                if (playerUnit3.tag == "Fire" && playerUnit3.passiveBuff == true)
                {
                    enemyUnit2.TakeDamage(2);
                    num = 4;
                }

                if (enemyUnit2.currentHp <= 0)
                {
                    enemyUnit2.currentHp = 0;
                    enemyUnit2.isDead = true;
                }

                enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);

                dialogueText.text = "The enemy " + enemyUnit2.unitName + " took "+num+" burn damage";

                if (enemyUnit2.isDead == true)
                {
                    yield return new WaitForSeconds(3f);
                    dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
                }

            }
            else if (enemyUnit2.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit2.unitName + " blocked the burn damage";
            }

        }

        if (enemyUnit3.isBurned == true && enemyUnit3.isDead == false)
        {
            if (enemyUnit3.isBlocking == false)
            {
                yield return new WaitForSeconds(3f);

                enemyUnit3.TakeDamage(2);
                int num = 2;

                if (playerUnit1.tag == "Fire" && playerUnit1.passiveBuff == true)
                {
                    enemyUnit3.TakeDamage(2);
                    num = 4;
                }
                if (playerUnit2.tag == "Fire" && playerUnit2.passiveBuff == true)
                {
                    enemyUnit3.TakeDamage(2);
                    num = 4;
                }
                if (playerUnit3.tag == "Fire" && playerUnit3.passiveBuff == true)
                {
                    enemyUnit3.TakeDamage(2);
                    num = 4;
                }

                if (enemyUnit3.currentHp <= 0)
                {
                    enemyUnit3.currentHp = 0;
                    enemyUnit3.isDead = true;
                }

                enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);

                dialogueText.text = "The enemy " + enemyUnit3.unitName + " took "+num+" burn damage";

                if (enemyUnit3.isDead == true)
                {
                    yield return new WaitForSeconds(3f);
                    dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
                }

            }
            else if (enemyUnit3.isBlocking == true)
            {
                dialogueText.text = "Enemy " + enemyUnit3.unitName + " blocked the burn damage";
            }

        }

        yield return new WaitForSeconds(1f);
        StartCoroutine(HealingRain());
    }

    //water passive
    IEnumerator HealingRain()
    {

        if ((playerUnit1.tag == "Water" && playerUnit1.isDead == false) || (playerUnit2.tag == "Water" && playerUnit2.isDead == false) || (playerUnit3.tag == "Water" && playerUnit3.isDead == false))
        {
            yield return new WaitForSeconds(3f);
            int num = 2;

            if (playerUnit1.isDead == false)
            {
                playerUnit1.currentHp = playerUnit1.currentHp + 2;
                

                if (playerUnit1.tag == "Water" && playerUnit1.passiveBuff == true)
                {
                    playerUnit1.currentHp = playerUnit1.currentHp + 2;
                    num = 4;
                }
                if (playerUnit2.tag == "Water" && playerUnit2.passiveBuff == true)
                {
                    playerUnit1.currentHp = playerUnit1.currentHp + 2;
                    num = 4;
                }
                if (playerUnit3.tag == "Water" && playerUnit3.passiveBuff == true)
                {
                    playerUnit1.currentHp = playerUnit1.currentHp + 2;
                    num = 4;
                }

                if (playerUnit1.currentHp > playerUnit1.maxHp)
                {
                    playerUnit1.currentHp = playerUnit1.maxHp;
                }
                playerHUD1.SetHP(playerUnit1.currentHp, playerUnit1);
            }
            
            if(playerUnit2.isDead == false)
            {
                playerUnit2.currentHp = playerUnit2.currentHp + 2;

                if (playerUnit1.tag == "Water" && playerUnit1.passiveBuff == true)
                {
                    playerUnit2.currentHp = playerUnit2.currentHp + 2;
                    num = 4;
                }
                if (playerUnit2.tag == "Water" && playerUnit2.passiveBuff == true)
                {
                    playerUnit2.currentHp = playerUnit2.currentHp + 2;
                    num = 4;
                }
                if (playerUnit3.tag == "Water" && playerUnit3.passiveBuff == true)
                {
                    playerUnit2.currentHp = playerUnit2.currentHp + 2;
                    num = 4;
                }

                if (playerUnit2.currentHp > playerUnit2.maxHp)
                {
                    playerUnit2.currentHp = playerUnit2.maxHp;
                }
                playerHUD2.SetHP(playerUnit2.currentHp, playerUnit2);
            }
            
            if(playerUnit3.isDead == false)
            {
                playerUnit3.currentHp = playerUnit3.currentHp + 2;

                if (playerUnit1.tag == "Water" && playerUnit1.passiveBuff == true)
                {
                    playerUnit3.currentHp = playerUnit3.currentHp + 2;
                    num = 4;
                }
                if (playerUnit2.tag == "Water" && playerUnit2.passiveBuff == true)
                {
                    playerUnit3.currentHp = playerUnit3.currentHp + 2;
                    num = 4;
                }
                if (playerUnit3.tag == "Water" && playerUnit3.passiveBuff == true)
                {
                    playerUnit3.currentHp = playerUnit3.currentHp + 2;
                    num = 4;
                }

                if (playerUnit3.currentHp > playerUnit3.maxHp)
                {
                    playerUnit3.currentHp = playerUnit3.maxHp;
                }
                playerHUD3.SetHP(playerUnit3.currentHp, playerUnit3);

                
            }

            dialogueText.text = "The player's Water healed their team " + num + " health";

        }

        if ((enemyUnit1.tag == "Water" && enemyUnit1.isDead == false) || (enemyUnit2.tag == "Water" && enemyUnit2.isDead == false) || (enemyUnit3.tag == "Water" && enemyUnit3.isDead == false))
        {
            yield return new WaitForSeconds(3f);
            int num = 2;

            if(enemyUnit1.isDead == false)
            {
                enemyUnit1.currentHp = enemyUnit1.currentHp + 2;

                if (enemyUnit1.tag == "Water" && enemyUnit1.passiveBuff == true)
                {
                    enemyUnit1.currentHp = enemyUnit1.currentHp + 2;
                    num = 4;
                }
                if (enemyUnit2.tag == "Water" && enemyUnit2.passiveBuff == true)
                {
                    enemyUnit1.currentHp = enemyUnit1.currentHp + 2;
                    num = 4;
                }
                if (enemyUnit3.tag == "Water" && enemyUnit3.passiveBuff == true)
                {
                    enemyUnit1.currentHp = enemyUnit1.currentHp + 2;
                    num = 4;
                }

                if (enemyUnit1.currentHp > enemyUnit1.maxHp)
                {
                    enemyUnit1.currentHp = enemyUnit1.maxHp;
                }
                enemyHUD1.SetHP(enemyUnit1.currentHp, enemyUnit1);
            }
            
            if(enemyUnit2.isDead == false)
            {
                enemyUnit2.currentHp = enemyUnit2.currentHp + 2;

                if (enemyUnit1.tag == "Water" && enemyUnit1.passiveBuff == true)
                {
                    enemyUnit2.currentHp = enemyUnit2.currentHp + 2;
                    num = 4;
                }
                if (enemyUnit2.tag == "Water" && enemyUnit2.passiveBuff == true)
                {
                    enemyUnit2.currentHp = enemyUnit2.currentHp + 2;
                    num = 4;
                }
                if (enemyUnit3.tag == "Water" && enemyUnit3.passiveBuff == true)
                {
                    enemyUnit2.currentHp = enemyUnit2.currentHp + 2;
                    num = 4;
                }

                if (enemyUnit2.currentHp > enemyUnit2.maxHp)
                {
                    enemyUnit2.currentHp = enemyUnit2.maxHp;
                }
                enemyHUD2.SetHP(enemyUnit2.currentHp, enemyUnit2);
            }
            
            if(enemyUnit3.isDead == false)
            {
                enemyUnit3.currentHp = enemyUnit3.currentHp + 2;

                if (enemyUnit1.tag == "Water" && enemyUnit1.passiveBuff == true)
                {
                    enemyUnit3.currentHp = enemyUnit3.currentHp + 2;
                    num = 4;
                }
                if (enemyUnit2.tag == "Water" && enemyUnit2.passiveBuff == true)
                {
                    enemyUnit3.currentHp = enemyUnit3.currentHp + 2;
                    num = 4;
                }
                if (enemyUnit3.tag == "Water" && enemyUnit3.passiveBuff == true)
                {
                    enemyUnit3.currentHp = enemyUnit3.currentHp + 2;
                    num = 4;
                }

                if (enemyUnit3.currentHp > enemyUnit3.maxHp)
                {
                    enemyUnit3.currentHp = enemyUnit3.maxHp;
                }
                enemyHUD3.SetHP(enemyUnit3.currentHp, enemyUnit3);
            }


            dialogueText.text = "The enemy Water healed their team "+num+" health";

        }

        yield return new WaitForSeconds(3f);
        battleSystem.gameObject.GetComponent<BattleSystem>().PlayerTurn();
    }

}
