using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, BATTLEPHASE, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    public GameObject battleSystem;

    //Stored Characters
    public GameObject rightFlame;
    public GameObject leftFlame;
    public GameObject rightWater;
    public GameObject leftWater;
    public GameObject rightGrass;
    public GameObject leftGrass;
    public GameObject rightEarth;
    public GameObject leftEarth;
    public GameObject rightWind;
    public GameObject leftWind;
    public GameObject rightElectric;
    public GameObject leftElectric;

    public bool flameUsed = false;
    public bool waterUsed = false;
    public bool grassUsed = false;
    public bool earthUsed = false;
    public bool windUsed = false;
    public bool electricUsed = false;

    //selected characters
    public int selectedCharacter1;
    public int selectedCharacter2;
    public int selectedCharacter3;

    //player prefabs
    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    public GameObject playerPrefab3;

    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    //player spawns
    public Transform playerSpawn1;
    public Transform playerSpawn2;
    public Transform playerSpawn3;

    public Transform enemySpawn1;
    public Transform enemySpawn2;
    public Transform enemySpawn3;

    //clone data
    public Unit playerUnit1;
    public Unit playerUnit2;
    public Unit playerUnit3;

    public Unit enemyUnit1;
    public Unit enemyUnit2;
    public Unit enemyUnit3;

    //hp hud
    public BattleHUD playerHUD1;
    public BattleHUD playerHUD2;
    public BattleHUD playerHUD3;

    public BattleHUD enemyHUD1;
    public BattleHUD enemyHUD2;
    public BattleHUD enemyHUD3;

    //buttons
    public ButtonHUD btns;

    public Button playerUnitBtn1;
    public Button playerUnitBtn2;
    public Button playerUnitBtn3;

    public Button playerUnitBtn4;
    public Button playerUnitBtn5;
    public Button playerUnitBtn6;

    public Button enemyUnitBtn1;
    public Button enemyUnitBtn2;
    public Button enemyUnitBtn3;

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

    //button text 
    public GameObject playerUnitTxt1;
    public GameObject playerUnitTxt2;
    public GameObject playerUnitTxt3;

    public GameObject playerUnitTxt4;
    public GameObject playerUnitTxt5;
    public GameObject playerUnitTxt6;

    public GameObject enemyUnitTxt1;
    public GameObject enemyUnitTxt2;
    public GameObject enemyUnitTxt3;

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

    //attack sequence
    public bool player1Move;
    public bool player2Move;
    public bool player3Move;
    
    //choosing players and enemys during combat
    public Unit chosenEnemy1;
    public Unit chosenEnemy2;
    public Unit chosenEnemy3;

    public Unit chosenPlayer1;
    public Unit chosenPlayer2;
    public Unit chosenPlayer3;

    public BattleHUD chosenPlayerHUD1;
    public BattleHUD chosenPlayerHUD2;
    public BattleHUD chosenPlayerHUD3;

    public BattleHUD chosenEnemyHUD1;
    public BattleHUD chosenEnemyHUD2;
    public BattleHUD chosenEnemyHUD3;

    //support moves
    public bool support = false;
    

    //BATTLE SETUP
    void Start()
    {       
        state = BattleState.START;

        selectedCharacter1 = PlayerPrefs.GetInt("selectedCharacter1");
        selectedCharacter2 = PlayerPrefs.GetInt("selectedCharacter2");
        selectedCharacter3 = PlayerPrefs.GetInt("selectedCharacter3");

        // selecting first player character
        if(selectedCharacter1 == 1)
        {
            playerPrefab1 = rightFlame;
        }
        else if(selectedCharacter1 == 2)
        {
            playerPrefab1 = rightWater;
        }
        else if(selectedCharacter1 == 3)
        {
            playerPrefab1 = rightGrass;
        }
        else if(selectedCharacter1 == 4)
        {
            playerPrefab1 = rightEarth;
        }
        else if (selectedCharacter1 == 5)
        {
            playerPrefab1 = rightWind;
        }
        else if (selectedCharacter1 == 6)
        {
            playerPrefab1 = rightElectric;
        }

        //selecting second player character
        if (selectedCharacter2 == 1)
        {
            playerPrefab2 = rightFlame;
        }
        else if (selectedCharacter2 == 2)
        {
            playerPrefab2 = rightWater;
        }
        else if (selectedCharacter2 == 3)
        {
            playerPrefab2 = rightGrass;
        }
        else if (selectedCharacter2 == 4)
        {
            playerPrefab2 = rightEarth;
        }
        else if (selectedCharacter2 == 5)
        {
            playerPrefab2 = rightWind;
        }
        else if (selectedCharacter2 == 6)
        {
            playerPrefab2 = rightElectric;
        }

        //selecting third player character
        if (selectedCharacter3 == 1)
        {
            playerPrefab3 = rightFlame;
        }
        else if (selectedCharacter3 == 2)
        {
            playerPrefab3 = rightWater;
        }
        else if (selectedCharacter3 == 3)
        {
            playerPrefab3 = rightGrass;
        }
        else if (selectedCharacter3 == 4)
        {
            playerPrefab3 = rightEarth;
        }
        else if (selectedCharacter3 == 5)
        {
            playerPrefab3 = rightWind;
        }
        else if (selectedCharacter3 == 6)
        {
            playerPrefab3 = rightElectric;
        }

        //selecting first enemy character
        for (int i=0; i <= 1000; i++)
        {
            int enemy1 = Random.Range(0, 6);

            if (enemy1 == 0 && flameUsed == false)
            {
                enemyPrefab1 = leftFlame;
                flameUsed = true;
                i = 1001;
            }
            if (enemy1 == 1 && waterUsed == false)
            {
                enemyPrefab1 = leftWater;
                waterUsed = true;
                i = 1001;
            }
            if (enemy1 == 2 && grassUsed == false)
            {
                enemyPrefab1 = leftGrass;
                grassUsed = true;
                i = 1001;
            }
            if (enemy1 == 3 && earthUsed == false)
            {
                enemyPrefab1 = leftEarth;
                earthUsed = true;
                i = 1001;
            }
            if (enemy1 == 4 && windUsed == false)
            {
                enemyPrefab1 = leftWind;
                windUsed = true;
                i = 1001;
            }
            if (enemy1 == 5 && electricUsed == false)
            {
                enemyPrefab1 = leftElectric;
                electricUsed = true;
                i = 1001;
            }
        }

        //selecting second enemy character
        for (int i = 0; i <= 1000; i++)
        {
            int enemy2 = Random.Range(0, 6);

            if (enemy2 == 0 && flameUsed == false)
            {
                enemyPrefab2 = leftFlame;
                flameUsed = true;
                i = 1001;
            }
            if (enemy2 == 1 && waterUsed == false)
            {
                enemyPrefab2 = leftWater;
                waterUsed = true;
                i = 1001;
            }
            if (enemy2 == 2 && grassUsed == false)
            {
                enemyPrefab2 = leftGrass;
                grassUsed = true;
                i = 1001;
            }
            if (enemy2 == 3 && earthUsed == false)
            {
                enemyPrefab2 = leftEarth;
                earthUsed = true;
                i = 1001;
            }
            if (enemy2 == 4 && windUsed == false)
            {
                enemyPrefab2 = leftWind;
                windUsed = true;
                i = 1001;
                if (enemy2 == 5 && electricUsed == false)
                {
                    enemyPrefab2 = leftElectric;
                    electricUsed = true;
                    i = 1001;
                }
            }
        }

        //selecting third enemy character
        for (int i = 0; i <= 1000; i++)
        {
            int enemy3 = Random.Range(0, 6);

            if (enemy3 == 0 && flameUsed == false)
            {
                enemyPrefab3 = leftFlame;
                flameUsed = true;
                i = 1001;
            }
            if (enemy3 == 1 && waterUsed == false)
            {
                enemyPrefab3 = leftWater;
                waterUsed = true;
                i = 1001;
            }
            if (enemy3 == 2 && grassUsed == false)
            {
                enemyPrefab3 = leftGrass;
                grassUsed = true;
                i = 1001;
            }
            if (enemy3 == 3 && earthUsed == false)
            {
                enemyPrefab3 = leftEarth;
                earthUsed = true;
                i = 1001;
            }
            if (enemy3 == 4 && windUsed == false)
            {
                enemyPrefab3 = leftWind;
                windUsed = true;
                i = 1001;
            }
            if (enemy3 == 5 && electricUsed == false)
            {
                enemyPrefab3 = leftElectric;
                electricUsed = true;
                i = 1001;
            }
        }

        StartCoroutine(SetupBattle());        
    }

    public void Update()
    {
        if(playerUnit1.isDead == true)
        {
            playerUnit1.gameObject.SetActive(false);
            playerUnit1.unitSpd = -100;
        }
        if (playerUnit2.isDead == true)
        {
            playerUnit2.gameObject.SetActive(false);
            playerUnit2.unitSpd = -100;
        }
        if (playerUnit3.isDead == true)
        {
            playerUnit3.gameObject.SetActive(false);
            playerUnit3.unitSpd = -100;
        }
        if(enemyUnit1.isDead == true)
        {
            enemyUnit1.gameObject.SetActive(false);
            enemyUnit1.unitSpd = -100;
        }
        if (enemyUnit2.isDead == true)
        {
            enemyUnit2.gameObject.SetActive(false);
            enemyUnit2.unitSpd = -100;
        }
        if (enemyUnit3.isDead == true)
        {
            enemyUnit3.gameObject.SetActive(false);
            enemyUnit3.unitSpd = -100;
        }
    }

    IEnumerator SetupBattle()
    {
        //spawn player position
        GameObject playerGO = Instantiate(playerPrefab1, playerSpawn1);
        playerUnit1 = playerGO.GetComponent<Unit>();
        GameObject playerGO2 = Instantiate(playerPrefab2, playerSpawn2);
        playerUnit2 = playerGO2.GetComponent<Unit>();
        GameObject playerGO3 = Instantiate(playerPrefab3, playerSpawn3);
        playerUnit3 = playerGO3.GetComponent<Unit>();

        //spawn enemy position
        GameObject enemyGO = Instantiate(enemyPrefab1, enemySpawn1);
        enemyUnit1 = enemyGO.GetComponent<Unit>();
        GameObject enemyGO2 = Instantiate(enemyPrefab2, enemySpawn2);
        enemyUnit2 = enemyGO2.GetComponent<Unit>();
        GameObject enemyGO3 = Instantiate(enemyPrefab3, enemySpawn3);
        enemyUnit3 = enemyGO3.GetComponent<Unit>();

        //set hud and buttons for units
        playerHUD1.SetHUD(playerUnit1);
        playerHUD2.SetHUD(playerUnit2);
        playerHUD3.SetHUD(playerUnit3);

        enemyHUD1.SetHUD(enemyUnit1);
        enemyHUD2.SetHUD(enemyUnit2);
        enemyHUD3.SetHUD(enemyUnit3);

        btns.SetBtnHUD(playerUnit1);
        btns.SetBtnHUD2(playerUnit2);
        btns.SetBtnHUD3(playerUnit3);

        btns.SetUnitName(playerUnit1);
        btns.SetUnitName2(playerUnit2);
        btns.SetUnitName3(playerUnit3);
        btns.SetUnitName4(playerUnit1);
        btns.SetUnitName5(playerUnit2);
        btns.SetUnitName6(playerUnit3);
        btns.SetEnemyUnitName1(enemyUnit1);
        btns.SetEnemyUnitName2(enemyUnit2);
        btns.SetEnemyUnitName3(enemyUnit3);

        //set text color
        playerUnitTxt1.GetComponent<ChangeTextColor>().greenColor();
        playerUnitTxt2.GetComponent<ChangeTextColor>().greenColor();
        playerUnitTxt3.GetComponent<ChangeTextColor>().greenColor();

        playerUnitTxt4.GetComponent<ChangeTextColor>().greenColor();
        playerUnitTxt5.GetComponent<ChangeTextColor>().greenColor();
        playerUnitTxt6.GetComponent<ChangeTextColor>().greenColor();

        enemyUnitTxt1.GetComponent<ChangeTextColor>().greenColor();
        enemyUnitTxt2.GetComponent<ChangeTextColor>().greenColor();
        enemyUnitTxt3.GetComponent<ChangeTextColor>().greenColor();

        move1txt.GetComponent<ChangeTextColor>().greenColor();
        move2txt.GetComponent<ChangeTextColor>().greenColor();
        move3txt.GetComponent<ChangeTextColor>().greenColor();
        move4txt.GetComponent<ChangeTextColor>().greenColor();
        move5txt.GetComponent<ChangeTextColor>().greenColor();
        move6txt.GetComponent<ChangeTextColor>().greenColor();
        move7txt.GetComponent<ChangeTextColor>().greenColor();
        move8txt.GetComponent<ChangeTextColor>().greenColor();
        move9txt.GetComponent<ChangeTextColor>().greenColor();
        move10txt.GetComponent<ChangeTextColor>().greenColor();
        move11txt.GetComponent<ChangeTextColor>().greenColor();
        move12txt.GetComponent<ChangeTextColor>().greenColor();

        //buttons
        playerUnitBtn1.gameObject.SetActive(false);
        playerUnitBtn2.gameObject.SetActive(false);
        playerUnitBtn3.gameObject.SetActive(false);

        playerUnitBtn4.gameObject.SetActive(false);
        playerUnitBtn5.gameObject.SetActive(false);
        playerUnitBtn6.gameObject.SetActive(false);

        enemyUnitBtn1.gameObject.SetActive(false);
        enemyUnitBtn2.gameObject.SetActive(false);
        enemyUnitBtn3.gameObject.SetActive(false);

        move1btn.gameObject.SetActive(false);
        move2btn.gameObject.SetActive(false);
        move3btn.gameObject.SetActive(false);
        move4btn.gameObject.SetActive(false);
        move5btn.gameObject.SetActive(false);
        move6btn.gameObject.SetActive(false);
        move7btn.gameObject.SetActive(false);
        move8btn.gameObject.SetActive(false);
        move9btn.gameObject.SetActive(false);
        move10btn.gameObject.SetActive(false);
        move11btn.gameObject.SetActive(false);
        move12btn.gameObject.SetActive(false);

        //clone stats
        CloneStats();

        //start passives
        StartPassives();

        dialogueText.text = "The battle has begun ";

        yield return new WaitForSeconds(3f);

        PlayerTurn();
    }

    
    //GET CLONE STATS
    public void CloneStats()
    {
        battleSystem.gameObject.GetComponent<MoveOrder>().GetObjects();
        battleSystem.gameObject.GetComponent<BattlePhaseScript>().GetObjects();
        battleSystem.gameObject.GetComponent<BattlePhaseMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<BattleEffects>().GetObjects();

        battleSystem.gameObject.GetComponent<FireMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<FireMovesAI>().GetObjects();
        battleSystem.gameObject.GetComponent<WaterMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<WaterMovesAI>().GetObjects();
        battleSystem.gameObject.GetComponent<GrassMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<GrassMovesAI>().GetObjects();
        battleSystem.gameObject.GetComponent<EarthMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<EarthMovesAI>().GetObjects();
        battleSystem.gameObject.GetComponent<WindMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<WindMovesAI>().GetObjects();
        battleSystem.gameObject.GetComponent<ElectricMoves>().GetObjects();
        battleSystem.gameObject.GetComponent<ElectricMovesAI>().GetObjects();
    }

    public void StartPassives()
    {
        battleSystem.gameObject.GetComponent<BattleEffects>().StartGamePassive();
    }


    //PLAYERS TURN
    public void PlayerTurn()
    {
        if (state == BattleState.WON || state == BattleState.LOST)
            return;

        state = BattleState.PLAYERTURN;

        dialogueText.text = "Select your fighter ";

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        move1btn.gameObject.SetActive(false);
        move2btn.gameObject.SetActive(false);
        move3btn.gameObject.SetActive(false);
        move4btn.gameObject.SetActive(false);
        move5btn.gameObject.SetActive(false);
        move6btn.gameObject.SetActive(false);
        move7btn.gameObject.SetActive(false);
        move8btn.gameObject.SetActive(false);
        move9btn.gameObject.SetActive(false);
        move10btn.gameObject.SetActive(false);
        move11btn.gameObject.SetActive(false);
        move12btn.gameObject.SetActive(false);

        //reset prio and speed
        battleSystem.gameObject.GetComponent<MoveOrder>().PrioReset();

        //set move speed and prio
        battleSystem.gameObject.GetComponent<MoveOrder>().MovePrio();

        //moves cds;
        battleSystem.gameObject.GetComponent<FireMoves>().FireMoveCD();
        battleSystem.gameObject.GetComponent<FireMovesAI>().FireMoveAICD();
        battleSystem.gameObject.GetComponent<WaterMoves>().WaterMoveCD();
        battleSystem.gameObject.GetComponent<WaterMovesAI>().WaterMoveAICD();
        battleSystem.gameObject.GetComponent<GrassMoves>().GrassMoveCD();
        battleSystem.gameObject.GetComponent<GrassMovesAI>().GrassMoveAICD();
        battleSystem.gameObject.GetComponent<EarthMoves>().EarthMoveCD();
        battleSystem.gameObject.GetComponent<EarthMovesAI>().EarthMoveAICD();
        battleSystem.gameObject.GetComponent<WindMoves>().WindMoveCD();
        battleSystem.gameObject.GetComponent<WindMovesAI>().WindMoveAICD();
        battleSystem.gameObject.GetComponent<ElectricMoves>().ElectricMoveCD();
        battleSystem.gameObject.GetComponent<ElectricMovesAI>().ElectricMoveAICD();

        playerUnitBtn1.enabled = true;
        playerUnitTxt1.GetComponent<ChangeTextColor>().greenColor();
        playerUnitBtn2.enabled = true;
        playerUnitTxt2.GetComponent<ChangeTextColor>().greenColor();
        playerUnitBtn3.enabled = true;
        playerUnitTxt3.GetComponent<ChangeTextColor>().greenColor();

        //check if units are dead
        if (playerUnit1.isDead == true)
        {
            playerUnitBtn1.enabled = false;
            playerUnitTxt1.GetComponent<ChangeTextColor>().redColor();
            playerUnitBtn4.enabled = false;
            playerUnitTxt4.GetComponent<ChangeTextColor>().redColor();
        }
        if (playerUnit2.isDead == true)
        {
            playerUnitBtn2.enabled = false;
            playerUnitTxt2.GetComponent<ChangeTextColor>().redColor();
            playerUnitBtn5.enabled = false;
            playerUnitTxt5.GetComponent<ChangeTextColor>().redColor();
        }
        if(playerUnit3.isDead == true)
        {
            playerUnitBtn3.enabled = false;
            playerUnitTxt3.GetComponent<ChangeTextColor>().redColor();
            playerUnitBtn6.enabled = false;
            playerUnitTxt6.GetComponent<ChangeTextColor>().redColor();
        }
        if(enemyUnit1.isDead == true)
        {
            enemyUnitBtn1.enabled = false;
            enemyUnitTxt1.GetComponent<ChangeTextColor>().redColor();
        }
        if (enemyUnit2.isDead == true)
        {
            enemyUnitBtn2.enabled = false;
            enemyUnitTxt2.GetComponent<ChangeTextColor>().redColor();
        }
        if (enemyUnit3.isDead == true)
        {
            enemyUnitBtn3.enabled = false;
            enemyUnitTxt3.GetComponent<ChangeTextColor>().redColor();
        }

        //stop multiple passive buffs
        if (playerUnit1.passiveBuff == true)
        {
            move4btn.enabled = false;
            move4txt.GetComponent<ChangeTextColor>().redColor();
            move8btn.enabled = false;
            move8txt.GetComponent<ChangeTextColor>().redColor();
            move12btn.enabled = false;
            move12txt.GetComponent<ChangeTextColor>().redColor();
        }
        else if (playerUnit2.passiveBuff == true)
        {
            move4btn.enabled = false;
            move4txt.GetComponent<ChangeTextColor>().redColor();
            move8btn.enabled = false;
            move8txt.GetComponent<ChangeTextColor>().redColor();
            move12btn.enabled = false;
            move12txt.GetComponent<ChangeTextColor>().redColor();
        }
        else if (playerUnit3.passiveBuff == true)
        {
            move4btn.enabled = false;
            move4txt.GetComponent<ChangeTextColor>().redColor();
            move8btn.enabled = false;
            move8txt.GetComponent<ChangeTextColor>().redColor();
            move12btn.enabled = false;
            move12txt.GetComponent<ChangeTextColor>().redColor();
        }

        //AI random move chooser
        battleSystem.gameObject.GetComponent<FireMovesAI>().ChosenFireMoves();
        battleSystem.gameObject.GetComponent<WaterMovesAI>().ChosenWaterMoves();
        battleSystem.gameObject.GetComponent<GrassMovesAI>().ChosenGrassMoves();
        battleSystem.gameObject.GetComponent<EarthMovesAI>().ChosenEarthMoves();
        battleSystem.gameObject.GetComponent<WindMovesAI>().ChosenWindMoves();
        battleSystem.gameObject.GetComponent<ElectricMovesAI>().ChosenElectricMoves();
    }

    //SELECTING YOUR SPRITE AND WHO TO ATTACK
    //chooseplayer 1
    public void PlayerUnit1Btn()
    {
        dialogueText.text = "Select your move ";

        playerUnitBtn1.gameObject.SetActive(false);
        playerUnitBtn2.gameObject.SetActive(false);
        playerUnitBtn3.gameObject.SetActive(false);

        move1btn.gameObject.SetActive(true);
        move2btn.gameObject.SetActive(true);
        move3btn.gameObject.SetActive(true);
        move4btn.gameObject.SetActive(true);

        playerUnitTxt1.GetComponent<ChangeTextColor>().redColor();
        playerUnitBtn1.enabled = false;

        player1Move = true;
    }
    //choose player 2
    public void PlayerUnit2Btn()
    {
        dialogueText.text = "Select your move ";

        playerUnitBtn1.gameObject.SetActive(false);
        playerUnitBtn2.gameObject.SetActive(false);
        playerUnitBtn3.gameObject.SetActive(false);

        move5btn.gameObject.SetActive(true);
        move6btn.gameObject.SetActive(true);
        move7btn.gameObject.SetActive(true);
        move8btn.gameObject.SetActive(true);

        playerUnitTxt2.GetComponent<ChangeTextColor>().redColor();
        playerUnitBtn2.enabled = false;
        
        player2Move = true;
    }
    //choose player 3
    public void PlayerUnit3Btn()
    {
        dialogueText.text = "Select your move ";

        playerUnitBtn1.gameObject.SetActive(false);
        playerUnitBtn2.gameObject.SetActive(false);
        playerUnitBtn3.gameObject.SetActive(false);

        move9btn.gameObject.SetActive(true);
        move10btn.gameObject.SetActive(true);
        move11btn.gameObject.SetActive(true);
        move12btn.gameObject.SetActive(true);

        playerUnitTxt3.GetComponent<ChangeTextColor>().redColor();
        playerUnitBtn3.enabled = false;

        player3Move = true;
    }
    //choose move 1
    public void OnMove1Button()
    {
        /*if (state != BattleState.PLAYERTURN)
            return;*/

        dialogueText.text = "Select your target ";

        enemyUnitBtn1.gameObject.SetActive(true);
        enemyUnitBtn2.gameObject.SetActive(true);
        enemyUnitBtn3.gameObject.SetActive(true);

        move1btn.gameObject.SetActive(false);
        move2btn.gameObject.SetActive(false);
        move3btn.gameObject.SetActive(false);
        move4btn.gameObject.SetActive(false);
        move5btn.gameObject.SetActive(false);
        move6btn.gameObject.SetActive(false);
        move7btn.gameObject.SetActive(false);
        move8btn.gameObject.SetActive(false);
        move9btn.gameObject.SetActive(false);
        move10btn.gameObject.SetActive(false);
        move11btn.gameObject.SetActive(false);
        move12btn.gameObject.SetActive(false);

        if (player1Move == true)
        {
            playerUnit1.chosenMove = 1;
        }
        else if(player2Move == true)
        {
            playerUnit2.chosenMove = 1;
        }
        else if(player3Move == true)
        {
            playerUnit3.chosenMove = 1;
        }

        
    }
    //choose move 2
    public void OnMove2Button()
    {
       /* if (state != BattleState.PLAYERTURN)
            return;*/

        dialogueText.text = "Select your target ";

        enemyUnitBtn1.gameObject.SetActive(true);
        enemyUnitBtn2.gameObject.SetActive(true);
        enemyUnitBtn3.gameObject.SetActive(true);

        move1btn.gameObject.SetActive(false);
        move2btn.gameObject.SetActive(false);
        move3btn.gameObject.SetActive(false);
        move4btn.gameObject.SetActive(false);
        move5btn.gameObject.SetActive(false);
        move6btn.gameObject.SetActive(false);
        move7btn.gameObject.SetActive(false);
        move8btn.gameObject.SetActive(false);
        move9btn.gameObject.SetActive(false);
        move10btn.gameObject.SetActive(false);
        move11btn.gameObject.SetActive(false);
        move12btn.gameObject.SetActive(false);

        if (player1Move == true)
        {
            playerUnit1.chosenMove = 2;
        }
        else if (player2Move == true)
        {
            playerUnit2.chosenMove = 2;
        }
        else if (player3Move == true)
        {
            playerUnit3.chosenMove = 2;
        }
    }
    //choose move 3
    public void OnMove3Button()
    {
        /*if (state != BattleState.PLAYERTURN)
            return;*/

        dialogueText.text = "Select your target ";

        enemyUnitBtn1.gameObject.SetActive(true);
        enemyUnitBtn2.gameObject.SetActive(true);
        enemyUnitBtn3.gameObject.SetActive(true);

        move1btn.gameObject.SetActive(false);
        move2btn.gameObject.SetActive(false);
        move3btn.gameObject.SetActive(false);
        move4btn.gameObject.SetActive(false);
        move5btn.gameObject.SetActive(false);
        move6btn.gameObject.SetActive(false);
        move7btn.gameObject.SetActive(false);
        move8btn.gameObject.SetActive(false);
        move9btn.gameObject.SetActive(false);
        move10btn.gameObject.SetActive(false);
        move11btn.gameObject.SetActive(false);
        move12btn.gameObject.SetActive(false);

        if (player1Move == true)
        {
            playerUnit1.chosenMove = 3;
            //supports
            if(playerUnit1.isSupport == true)
            {
                enemyUnitBtn1.gameObject.SetActive(false);
                enemyUnitBtn2.gameObject.SetActive(false);
                enemyUnitBtn3.gameObject.SetActive(false);

                playerUnitBtn4.gameObject.SetActive(true);
                playerUnitBtn5.gameObject.SetActive(true);
                playerUnitBtn6.gameObject.SetActive(true);  
            }
            if (playerUnit1.tag == "Grass" || playerUnit1.tag == "Electric")
            {
                enemyUnitBtn1.gameObject.SetActive(false);
                enemyUnitBtn2.gameObject.SetActive(false);
                enemyUnitBtn3.gameObject.SetActive(false);

                playerUnitBtn4.gameObject.SetActive(false);
                playerUnitBtn5.gameObject.SetActive(false);
                playerUnitBtn6.gameObject.SetActive(false);

                playerUnitBtn1.gameObject.SetActive(true);
                playerUnitBtn2.gameObject.SetActive(true);
                playerUnitBtn3.gameObject.SetActive(true);

                player1Move = false;
                player2Move = false;
                player3Move = false;

                if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
                {
                    playerUnitBtn1.gameObject.SetActive(false);
                    playerUnitBtn2.gameObject.SetActive(false);
                    playerUnitBtn3.gameObject.SetActive(false);

                    dialogueText.text = "Calculating stats ";

                    CloneStats();
                    BattlePhase();
                }
            }
        }
        else if (player2Move == true)
        {
            playerUnit2.chosenMove = 3;
            //supports
            if (playerUnit2.isSupport == true)
            {
                enemyUnitBtn1.gameObject.SetActive(false);
                enemyUnitBtn2.gameObject.SetActive(false);
                enemyUnitBtn3.gameObject.SetActive(false);

                playerUnitBtn4.gameObject.SetActive(true);
                playerUnitBtn5.gameObject.SetActive(true);
                playerUnitBtn6.gameObject.SetActive(true);
            }
            if (playerUnit2.tag == "Grass" || playerUnit2.tag == "Electric")
            {
                enemyUnitBtn1.gameObject.SetActive(false);
                enemyUnitBtn2.gameObject.SetActive(false);
                enemyUnitBtn3.gameObject.SetActive(false);

                playerUnitBtn4.gameObject.SetActive(false);
                playerUnitBtn5.gameObject.SetActive(false);
                playerUnitBtn6.gameObject.SetActive(false);

                playerUnitBtn1.gameObject.SetActive(true);
                playerUnitBtn2.gameObject.SetActive(true);
                playerUnitBtn3.gameObject.SetActive(true);

                player1Move = false;
                player2Move = false;
                player3Move = false;

                if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
                {
                    playerUnitBtn1.gameObject.SetActive(false);
                    playerUnitBtn2.gameObject.SetActive(false);
                    playerUnitBtn3.gameObject.SetActive(false);

                    dialogueText.text = "Calculating stats ";

                    CloneStats();
                    BattlePhase();
                }
            }
        }
        else if (player3Move == true)
        {
            playerUnit3.chosenMove = 3;
            //supports
            if (playerUnit3.isSupport == true)
            {
                enemyUnitBtn1.gameObject.SetActive(false);
                enemyUnitBtn2.gameObject.SetActive(false);
                enemyUnitBtn3.gameObject.SetActive(false);

                playerUnitBtn4.gameObject.SetActive(true);
                playerUnitBtn5.gameObject.SetActive(true);
                playerUnitBtn6.gameObject.SetActive(true);
            }
            if (playerUnit3.tag == "Grass" || playerUnit3.tag == "Electric")
            {
                enemyUnitBtn1.gameObject.SetActive(false);
                enemyUnitBtn2.gameObject.SetActive(false);
                enemyUnitBtn3.gameObject.SetActive(false);

                playerUnitBtn4.gameObject.SetActive(false);
                playerUnitBtn5.gameObject.SetActive(false);
                playerUnitBtn6.gameObject.SetActive(false);

                playerUnitBtn1.gameObject.SetActive(true);
                playerUnitBtn2.gameObject.SetActive(true);
                playerUnitBtn3.gameObject.SetActive(true);

                player1Move = false;
                player2Move = false;
                player3Move = false;

                if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
                {
                    playerUnitBtn1.gameObject.SetActive(false);
                    playerUnitBtn2.gameObject.SetActive(false);
                    playerUnitBtn3.gameObject.SetActive(false);

                    dialogueText.text = "Calculating stats ";

                    CloneStats();
                    BattlePhase();
                }
            }
        }
    }
    //choose move 4
    public void OnMove4Button()
    {

        dialogueText.text = "Select your fighter ";

        enemyUnitBtn1.gameObject.SetActive(false);
        enemyUnitBtn2.gameObject.SetActive(false);
        enemyUnitBtn3.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        move1btn.gameObject.SetActive(false);
        move2btn.gameObject.SetActive(false);
        move3btn.gameObject.SetActive(false);
        move4btn.gameObject.SetActive(false);
        move5btn.gameObject.SetActive(false);
        move6btn.gameObject.SetActive(false);
        move7btn.gameObject.SetActive(false);
        move8btn.gameObject.SetActive(false);
        move9btn.gameObject.SetActive(false);
        move10btn.gameObject.SetActive(false);
        move11btn.gameObject.SetActive(false);
        move12btn.gameObject.SetActive(false);

        move4btn.enabled = false;
        move4txt.GetComponent<ChangeTextColor>().redColor();

        move8btn.enabled = false;
        move8txt.GetComponent<ChangeTextColor>().redColor();

        move12btn.enabled = false;
        move12txt.GetComponent<ChangeTextColor>().redColor();

        if (player1Move == true)
        {
            playerUnit1.chosenMove = 4;
        }
        else if (player2Move == true)
        {
            playerUnit2.chosenMove = 4;
        }
        else if (player3Move == true)
        {
            playerUnit3.chosenMove = 4;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();
        }

    }
    //choose enemy 1
    public void EnemyUnit1Btn()
    {
        dialogueText.text = "Select your fighter ";

        enemyUnitBtn1.gameObject.SetActive(false);
        enemyUnitBtn2.gameObject.SetActive(false);
        enemyUnitBtn3.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        if (player1Move == true)
        {
            chosenEnemy1 = enemyUnit1;
            chosenEnemyHUD1 = enemyHUD1;
        }
        else if (player2Move == true)
        {
            chosenEnemy2 = enemyUnit1;
            chosenEnemyHUD2 = enemyHUD1;
        }
        else if (player3Move == true)
        {
            chosenEnemy3 = enemyUnit1;
            chosenEnemyHUD3 = enemyHUD1;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();
        }
    }
    //choose enemy 2
    public void EnemyUnit2Btn()
    {
        dialogueText.text = "Select your fighter ";

        enemyUnitBtn1.gameObject.SetActive(false);
        enemyUnitBtn2.gameObject.SetActive(false);
        enemyUnitBtn3.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        if (player1Move == true)
        {
            chosenEnemy1 = enemyUnit2;
            chosenEnemyHUD1 = enemyHUD2;
        }
        else if (player2Move == true)
        {
            chosenEnemy2 = enemyUnit2;
            chosenEnemyHUD2 = enemyHUD2;
        }
        else if (player3Move == true)
        {
            chosenEnemy3 = enemyUnit2;
            chosenEnemyHUD3 = enemyHUD2;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();
        }
    }
    //choose enemy 3
    public void EnemyUnit3Btn()
    {
        dialogueText.text = "Select your fighter ";

        enemyUnitBtn1.gameObject.SetActive(false);
        enemyUnitBtn2.gameObject.SetActive(false);
        enemyUnitBtn3.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        if (player1Move == true)
        {
            chosenEnemy1 = enemyUnit3;
            chosenEnemyHUD1 = enemyHUD3;
        }
        else if (player2Move == true)
        {
            chosenEnemy2 = enemyUnit3;
            chosenEnemyHUD2 = enemyHUD3;
        }
        else if (player3Move == true)
        {
            chosenEnemy3 = enemyUnit3;
            chosenEnemyHUD3 = enemyHUD3;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();
            
        }
    }
    //choose player 4
    public void PlayerUnit1Btn2()
    {
        dialogueText.text = "Select your fighter ";

        playerUnitBtn4.gameObject.SetActive(false);
        playerUnitBtn5.gameObject.SetActive(false);
        playerUnitBtn6.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        if (player1Move == true)
        {
            chosenPlayer1 = playerUnit1;
            chosenPlayerHUD1 = playerHUD1;
        }
        else if (player2Move == true)
        {
            chosenPlayer2 = playerUnit1;
            chosenPlayerHUD2 = playerHUD1;
        }
        else if (player3Move == true)
        {
            chosenPlayer3 = playerUnit1;
            chosenPlayerHUD3 = playerHUD1;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();

        }
    }
    //choose player 5
    public void PlayerUnit2Btn2()
    {
        dialogueText.text = "Select your fighter ";

        playerUnitBtn4.gameObject.SetActive(false);
        playerUnitBtn5.gameObject.SetActive(false);
        playerUnitBtn6.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        if (player1Move == true)
        {
            chosenPlayer1 = playerUnit2;
            chosenPlayerHUD1 = playerHUD2;
        }
        else if (player2Move == true)
        {
            chosenPlayer2 = playerUnit2;
            chosenPlayerHUD2 = playerHUD2;
        }
        else if (player3Move == true)
        {
            chosenPlayer3 = playerUnit2;
            chosenPlayerHUD3 = playerHUD2;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();

        }
    }
    //choose player 6
    public void PlayerUnit3Btn2()
    {
        dialogueText.text = "Select your fighter ";

        playerUnitBtn4.gameObject.SetActive(false);
        playerUnitBtn5.gameObject.SetActive(false);
        playerUnitBtn6.gameObject.SetActive(false);

        playerUnitBtn1.gameObject.SetActive(true);
        playerUnitBtn2.gameObject.SetActive(true);
        playerUnitBtn3.gameObject.SetActive(true);

        if (player1Move == true)
        {
            chosenPlayer1 = playerUnit3;
            chosenPlayerHUD1 = playerHUD3;
        }
        else if (player2Move == true)
        {
            chosenPlayer2 = playerUnit3;
            chosenPlayerHUD2 = playerHUD3;
        }
        else if (player3Move == true)
        {
            chosenPlayer3 = playerUnit3;
            chosenPlayerHUD3 = playerHUD3;
        }

        player1Move = false;
        player2Move = false;
        player3Move = false;

        if (playerUnitBtn1.enabled == false && playerUnitBtn2.enabled == false && playerUnitBtn3.enabled == false)
        {
            playerUnitBtn1.gameObject.SetActive(false);
            playerUnitBtn2.gameObject.SetActive(false);
            playerUnitBtn3.gameObject.SetActive(false);

            dialogueText.text = "Calculating stats ";

            CloneStats();
            BattlePhase();

        }
    }   


    //BATTLE PHASE
    public void BattlePhase()
    {
        state = BattleState.BATTLEPHASE;

        if (state != BattleState.BATTLEPHASE)
            return;
        
        //battle sequence
        battleSystem.gameObject.GetComponent<BattlePhaseScript>().MovePrioBattle();
    }


    /*//CHANGE TO END STATE
    public void CheckGameOver() 
    { 
        if(enemyUnit1.isDead == true && enemyUnit2.isDead == true && enemyUnit3.isDead == true)
        {
            state = BattleState.WON;
            EndBattle();
        }
        if(playerUnit1.isDead == true && playerUnit2.isDead == true && playerUnit3.isDead == true)
        {
            state = BattleState.LOST;
            EndBattle();
        }
    }


    //END BATTLE
    void EndBattle()
    {
        if (state == BattleState.WON)
        {
            dialogueText.text = "Player Wins";
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "Enemy Wins";
        }
    }*/

}