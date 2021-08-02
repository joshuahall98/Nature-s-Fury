using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattlePhaseScript : MonoBehaviour
{
    public GameObject battleSystem;

    Unit playerUnit1;
    Unit playerUnit2;
    Unit playerUnit3;

    Unit enemyUnit1;
    Unit enemyUnit2;
    Unit enemyUnit3;

    public Text dialogueText;

    public void GetObjects()
    {
        playerUnit1 = GetComponent<BattleSystem>().playerUnit1;
        playerUnit2 = GetComponent<BattleSystem>().playerUnit2;
        playerUnit3 = GetComponent<BattleSystem>().playerUnit3;

        enemyUnit1 = GetComponent<BattleSystem>().enemyUnit1;
        enemyUnit2 = GetComponent<BattleSystem>().enemyUnit2;
        enemyUnit3 = GetComponent<BattleSystem>().enemyUnit3;

    }

    public void MovePrioBattle()
    {
        StartCoroutine(MovePrioBattleCoroutine());
    }

    //BATTLE PHASE MOVE PRIO
    IEnumerator MovePrioBattleCoroutine()
    {
        //PRIO 0 MOVES

        //first attackers
        if (playerUnit1.movePrio == 1 && playerUnit1.isDead == false)
        {
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU1Moves();
        }
        else if (playerUnit2.movePrio == 1  && playerUnit2.isDead == false)
        {
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU2Moves();
        }
        else if (playerUnit3.movePrio == 1 && playerUnit3.isDead == false)
        {
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU3Moves();
        }
        else if (enemyUnit1.movePrio == 1 && enemyUnit1.isDead == false)
        {
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU1Moves();
        }
        else if (enemyUnit2.movePrio == 1 && enemyUnit2.isDead == false)
        {
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU2Moves();
        }
        else if (enemyUnit3.movePrio == 1 && enemyUnit3.isDead == false)
        {
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU3Moves();
        }

        //check deaths 1
        if(playerUnit1.isDead == true && playerUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
            playerUnit1.justDied = false;
        }
        if (playerUnit2.isDead == true && playerUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
            playerUnit2.justDied = false;
        }
        if (playerUnit3.isDead == true && playerUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
            playerUnit3.justDied = false;
        }
        if (enemyUnit1.isDead == true && enemyUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
            enemyUnit1.justDied = false;
        }
        if (enemyUnit2.isDead == true && enemyUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
            enemyUnit2.justDied = false;
        }
        if (enemyUnit3.isDead == true && enemyUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
            enemyUnit3.justDied = false;
        }
        if (playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Enemy Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }
        if (enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Player Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }

        //second attackers
        if (playerUnit1.movePrio == 2 && playerUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU1Moves();
        }
        else if (playerUnit2.movePrio == 2 && playerUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU2Moves();
        }
        else if (playerUnit3.movePrio == 2 && playerUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU3Moves();
        }
        else if (enemyUnit1.movePrio == 2 && enemyUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU1Moves();
        }
        else if (enemyUnit2.movePrio == 2 && enemyUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU2Moves();
        }
        else if (enemyUnit3.movePrio == 2 && enemyUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU3Moves();
        }

        //check deaths 2
        if (playerUnit1.isDead == true && playerUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
            playerUnit1.justDied = false;
        }
        if (playerUnit2.isDead == true && playerUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
            playerUnit2.justDied = false;
        }
        if (playerUnit3.isDead == true && playerUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
            playerUnit3.justDied = false;
        }
        if (enemyUnit1.isDead == true && enemyUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
            enemyUnit1.justDied = false;
        }
        if (enemyUnit2.isDead == true && enemyUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
            enemyUnit2.justDied = false;
        }
        if (enemyUnit3.isDead == true && enemyUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
            enemyUnit3.justDied = false;
        }
        if (playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Enemy Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }
        if (enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Player Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }

        //third attackers
        if (playerUnit1.movePrio == 3 && playerUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU1Moves();
        }
        else if (playerUnit2.movePrio == 3 && playerUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU2Moves();
        }
        else if (playerUnit3.movePrio == 3 && playerUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU3Moves();
        }
        else if (enemyUnit1.movePrio == 3 && enemyUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU1Moves();
        }
        else if (enemyUnit2.movePrio == 3 && enemyUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU2Moves();
        }
        else if (enemyUnit3.movePrio == 3 && enemyUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU3Moves();
        }

        //check deaths 3
        if (playerUnit1.isDead == true && playerUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
            playerUnit1.justDied = false;
        }
        if (playerUnit2.isDead == true && playerUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
            playerUnit2.justDied = false;
        }
        if (playerUnit3.isDead == true && playerUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
            playerUnit3.justDied = false;
        }
        if (enemyUnit1.isDead == true && enemyUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
            enemyUnit1.justDied = false;
        }
        if (enemyUnit2.isDead == true && enemyUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
            enemyUnit2.justDied = false;
        }
        if (enemyUnit3.isDead == true && enemyUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
            enemyUnit3.justDied = false;
        }
        if (playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Enemy Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }
        if (enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Player Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }

        //fourth attackers
        if (playerUnit1.movePrio == 4 && playerUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU1Moves();
        }
        else if (playerUnit2.movePrio == 4 && playerUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU2Moves();
        }
        else if (playerUnit3.movePrio == 4 && playerUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU3Moves();
        }
        else if (enemyUnit1.movePrio == 4 && enemyUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU1Moves();
        }
        else if (enemyUnit2.movePrio == 4 && enemyUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU2Moves();
        }
        else if (enemyUnit3.movePrio == 4 && enemyUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU3Moves();
        }

        //check deaths 4
        if (playerUnit1.isDead == true && playerUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
            playerUnit1.justDied = false;
        }
        if (playerUnit2.isDead == true && playerUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
            playerUnit2.justDied = false;
        }
        if (playerUnit3.isDead == true && playerUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
            playerUnit3.justDied = false;
        }
        if (enemyUnit1.isDead == true && enemyUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
            enemyUnit1.justDied = false;
        }
        if (enemyUnit2.isDead == true && enemyUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
            enemyUnit2.justDied = false;
        }
        if (enemyUnit3.isDead == true && enemyUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
            enemyUnit3.justDied = false;
        }
        if (playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Enemy Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }
        if (enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Player Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }

        //fifth attackers
        if (playerUnit1.movePrio == 5 && playerUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU1Moves();
        }
        else if (playerUnit2.movePrio == 5 && playerUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU2Moves();
        }
        else if (playerUnit3.movePrio == 5 && playerUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU3Moves();
        }
        else if (enemyUnit1.movePrio == 5 && enemyUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU1Moves();
        }
        else if (enemyUnit2.movePrio == 5 && enemyUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU2Moves();
        }
        else if (enemyUnit3.movePrio == 5 && enemyUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU3Moves();
        }

        //check deaths 5
        if (playerUnit1.isDead == true && playerUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
            playerUnit1.justDied = false;
        }
        if (playerUnit2.isDead == true && playerUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
            playerUnit2.justDied = false;
        }
        if (playerUnit3.isDead == true && playerUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
            playerUnit3.justDied = false;
        }
        if (enemyUnit1.isDead == true && enemyUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
            enemyUnit1.justDied = false;
        }
        if (enemyUnit2.isDead == true && enemyUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
            enemyUnit2.justDied = false;
        }
        if (enemyUnit3.isDead == true && enemyUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
            enemyUnit3.justDied = false;
        }
        if (playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Enemy Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }
        if (enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Player Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }

        //sixth attackers
        if (playerUnit1.movePrio == 6 && playerUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU1Moves();
        }
        else if (playerUnit2.movePrio == 6 && playerUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU2Moves();
        }
        else if (playerUnit3.movePrio == 6 && playerUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().PU3Moves();
        }
        else if (enemyUnit1.movePrio == 6 && enemyUnit1.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU1Moves();
        }
        else if (enemyUnit2.movePrio == 6 && enemyUnit2.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU2Moves();
        }
        else if (enemyUnit3.movePrio == 6 && enemyUnit3.isDead == false)
        {
            yield return new WaitForSeconds(5f);
            battleSystem.gameObject.GetComponent<BattlePhaseMoves>().EU3Moves();
        }

        //check deaths 6
        if (playerUnit1.isDead == true && playerUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit1.unitName + " was killed";
            playerUnit1.justDied = false;
        }
        if (playerUnit2.isDead == true && playerUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit2.unitName + " was killed";
            playerUnit2.justDied = false;
        }
        if (playerUnit3.isDead == true && playerUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The player's " + playerUnit3.unitName + " was killed";
            playerUnit3.justDied = false;
        }
        if (enemyUnit1.isDead == true && enemyUnit1.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit1.unitName + " was killed";
            enemyUnit1.justDied = false;
        }
        if (enemyUnit2.isDead == true && enemyUnit2.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit2.unitName + " was killed";
            enemyUnit2.justDied = false;
        }
        if (enemyUnit3.isDead == true && enemyUnit3.justDied == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "The enemy " + enemyUnit3.unitName + " was killed";
            enemyUnit3.justDied = false;
        }
        if (playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Enemy Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }
        if (enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            yield return new WaitForSeconds(5f);
            dialogueText.text = "Player Wins";
            playerUnit1.movePrio = 0;
            playerUnit2.movePrio = 0;
            playerUnit3.movePrio = 0;
            enemyUnit1.movePrio = 0;
            enemyUnit2.movePrio = 0;
            enemyUnit3.movePrio = 0;
        }

        yield return new WaitForSeconds(1f);

        if(playerUnit1.movePrio != 0)
        {
            battleSystem.gameObject.GetComponent<BattleEffects>().EndTurnPassive();
        }
        

    }

}

