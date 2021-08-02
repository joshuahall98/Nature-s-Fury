using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhaseMoves : MonoBehaviour
{
    public GameObject battleSystem;

    Unit playerUnit1;
    Unit playerUnit2;
    Unit playerUnit3;

    Unit enemyUnit1;
    Unit enemyUnit2;
    Unit enemyUnit3;

    public void GetObjects()
    {
        playerUnit1 = GetComponent<BattleSystem>().playerUnit1;
        playerUnit2 = GetComponent<BattleSystem>().playerUnit2;
        playerUnit3 = GetComponent<BattleSystem>().playerUnit3;

        enemyUnit1 = GetComponent<BattleSystem>().enemyUnit1;
        enemyUnit2 = GetComponent<BattleSystem>().enemyUnit2;
        enemyUnit3 = GetComponent<BattleSystem>().enemyUnit3;

    }

    //PLAYER UNIT 1 MOVES
    public void PU1Moves()
    {
        if (playerUnit1.tag == "Fire")
        {
            if (playerUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU1FireMove1Btn();
            }
            else if (playerUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU1FireMove2Btn();
            }
            else if (playerUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU1FireMove3Btn();
            }
            else if (playerUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU1FireMove4Btn();
            }
        }

        if (playerUnit1.tag == "Water")
        {
            if (playerUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU1WaterMove1Btn();
            }
            else if (playerUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU1WaterMove2Btn();
            }
            else if (playerUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU1WaterMove3Btn();
            }
            else if (playerUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU1WaterMove4Btn();
            }
        }

        if (playerUnit1.tag == "Grass")
        {
            if (playerUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU1GrassMove1Btn();
            }
            else if (playerUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU1GrassMove2Btn();
            }
            else if (playerUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU1GrassMove3Btn();
            }
            else if (playerUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU1GrassMove4Btn();
            }
        }

        if (playerUnit1.tag == "Earth")
        {
            if (playerUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU1EarthMove1Btn();
            }
            else if (playerUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU1EarthMove2Btn();
            }
            else if (playerUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU1EarthMove3Btn();
            }
            else if (playerUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU1EarthMove4Btn();
            }
        }

        if (playerUnit1.tag == "Wind")
        {
            if (playerUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU1WindMove1Btn();
            }
            else if (playerUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU1WindMove2Btn();
            }
            else if (playerUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU1WindMove3Btn();
            }
            else if (playerUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU1WindMove4Btn();
            }
        }

        if (playerUnit1.tag == "Electric")
        {
            if (playerUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU1ElectricMove1Btn();
            }
            else if (playerUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU1ElectricMove2Btn();
            }
            else if (playerUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU1ElectricMove3Btn();
            }
            else if (playerUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU1ElectricMove4Btn();
            }
        }
    }

    //PLAYER UNIT 2 MOVES
    public void PU2Moves()
    {
        if (playerUnit2.tag == "Fire")
        {
            if (playerUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU2FireMove1Btn();
            }
            else if (playerUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU2FireMove2Btn();
            }
            else if (playerUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU2FireMove3Btn();
            }
            else if (playerUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU2FireMove4Btn();
            }
        }

        if (playerUnit2.tag == "Water")
        {
            if (playerUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU2WaterMove1Btn();
            }
            else if (playerUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU2WaterMove2Btn();
            }
            else if (playerUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU2WaterMove3Btn();
            }
            else if (playerUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU2WaterMove4Btn();
            }
        }

        if (playerUnit2.tag == "Grass")
        {
            if (playerUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU2GrassMove1Btn();
            }
            else if (playerUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU2GrassMove2Btn();
            }
            else if (playerUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU2GrassMove3Btn();
            }
            else if (playerUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU2GrassMove4Btn();
            }
        }

        if (playerUnit2.tag == "Earth")
        {
            if (playerUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU2EarthMove1Btn();
            }
            else if (playerUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU2EarthMove2Btn();
            }
            else if (playerUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU2EarthMove3Btn();
            }
            else if (playerUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU2EarthMove4Btn();
            }
        }

        if (playerUnit2.tag == "Wind")
        {
            if (playerUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU2WindMove1Btn();
            }
            else if (playerUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU2WindMove2Btn();
            }
            else if (playerUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU2WindMove3Btn();
            }
            else if (playerUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU2WindMove4Btn();
            }
        }
        if (playerUnit2.tag == "Electric")
        {
            if (playerUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU2ElectricMove1Btn();
            }
            else if (playerUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU2ElectricMove2Btn();
            }
            else if (playerUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU2ElectricMove3Btn();
            }
            else if (playerUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU2ElectricMove4Btn();
            }
        }
    }

    //PLAYER UNIT 3 MOVES
    public void PU3Moves()
    {
        if (playerUnit3.tag == "Fire")
        {
            if (playerUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU3FireMove1Btn();
            }
            else if (playerUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU3FireMove2Btn();
            }
            else if (playerUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU3FireMove3Btn();
            }
            else if (playerUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<FireMoves>().PU3FireMove4Btn();
            }
        }

        if (playerUnit3.tag == "Water")
        {
            if (playerUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU3WaterMove1Btn();
            }
            else if (playerUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU3WaterMove2Btn();
            }
            else if (playerUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU3WaterMove3Btn();
            }
            else if (playerUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WaterMoves>().PU3WaterMove4Btn();
            }
        }

        if (playerUnit3.tag == "Grass")
        {
            if (playerUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU3GrassMove1Btn();
            }
            else if (playerUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU3GrassMove2Btn();
            }
            else if (playerUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU3GrassMove3Btn();
            }
            else if (playerUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<GrassMoves>().PU3GrassMove4Btn();
            }
        }

        if (playerUnit3.tag == "Earth")
        {
            if (playerUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU3EarthMove1Btn();
            }
            else if (playerUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU3EarthMove2Btn();
            }
            else if (playerUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU3EarthMove3Btn();
            }
            else if (playerUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<EarthMoves>().PU3EarthMove4Btn();
            }
        }

        if (playerUnit3.tag == "Wind")
        {
            if (playerUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU3WindMove1Btn();
            }
            else if (playerUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU3WindMove2Btn();
            }
            else if (playerUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU3WindMove3Btn();
            }
            else if (playerUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WindMoves>().PU3WindMove4Btn();
            }
        }
        if (playerUnit3.tag == "Electric")
        {
            if (playerUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU3ElectricMove1Btn();
            }
            else if (playerUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU3ElectricMove2Btn();
            }
            else if (playerUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU3ElectricMove3Btn();
            }
            else if (playerUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<ElectricMoves>().PU3ElectricMove4Btn();
            }
        }
    }

    //ENEMY UNIT 1 MOVES
    public void EU1Moves()
    {
        if (enemyUnit1.tag == "Fire")
        {
            if (enemyUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU1FireMove1();
            }
            else if (enemyUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU1FireMove2();
            }
            else if (enemyUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU1FireMove3();
            }
            else if (enemyUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU1FireMove4();
            }
        }
        if (enemyUnit1.tag == "Water")
        {
            if (enemyUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU1WaterMove1();
            }
            else if (enemyUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU1WaterMove2();
            }
            else if (enemyUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU1WaterMove3();
            }
            else if (enemyUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU1WaterMove4();
            }
        }
        if (enemyUnit1.tag == "Grass")
        {
            if (enemyUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU1GrassMove1();
            }
            else if (enemyUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU1GrassMove2();
            }
            else if (enemyUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU1GrassMove3();
            }
            else if (enemyUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU1GrassMove4();
            }
        }
        if (enemyUnit1.tag == "Earth")
        {
            if (enemyUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU1EarthMove1();
            }
            else if (enemyUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU1EarthMove2();
            }
            else if (enemyUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU1EarthMove3();
            }
            else if (enemyUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU1EarthMove4();
            }
        }
        if (enemyUnit1.tag == "Wind")
        {
            if (enemyUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU1WindMove1();
            }
            else if (enemyUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU1WindMove2();
            }
            else if (enemyUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU1WindMove3();
            }
            else if (enemyUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU1WindMove4();
            }
        }
        if (enemyUnit1.tag == "Electric")
        {
            if (enemyUnit1.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU1ElectricMove1();
            }
            else if (enemyUnit1.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU1ElectricMove2();
            }
            else if (enemyUnit1.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU1ElectricMove3();
            }
            else if (enemyUnit1.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU1ElectricMove4();
            }
        }
    }

    //ENEMY UNIT 2 MOVES
    public void EU2Moves()
    {
        if (enemyUnit2.tag == "Fire")
        {
            if (enemyUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU2FireMove1();
            }
            else if (enemyUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU2FireMove2();
            }
            else if (enemyUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU2FireMove3();
            }
            else if (enemyUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU2FireMove4();
            }
        }
        if (enemyUnit2.tag == "Water")
        {
            if (enemyUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU2WaterMove1();
            }
            else if (enemyUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU2WaterMove2();
            }
            else if (enemyUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU2WaterMove3();
            }
            else if (enemyUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU2WaterMove4();
            }
        }
        if (enemyUnit2.tag == "Grass")
        {
            if (enemyUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU2GrassMove1();
            }
            else if (enemyUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU2GrassMove2();
            }
            else if (enemyUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU2GrassMove3();
            }
            else if (enemyUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU2GrassMove4();
            }
        }
        if (enemyUnit2.tag == "Earth")
        {
            if (enemyUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU2EarthMove1();
            }
            else if (enemyUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU2EarthMove2();
            }
            else if (enemyUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU2EarthMove3();
            }
            else if (enemyUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU2EarthMove4();
            }
        }
        if (enemyUnit2.tag == "Wind")
        {
            if (enemyUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU2WindMove1();
            }
            else if (enemyUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU2WindMove2();
            }
            else if (enemyUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU2WindMove3();
            }
            else if (enemyUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU2WindMove4();
            }
        }
        if (enemyUnit2.tag == "Electric")
        {
            if (enemyUnit2.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU2ElectricMove1();
            }
            else if (enemyUnit2.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU2ElectricMove2();
            }
            else if (enemyUnit2.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU2ElectricMove3();
            }
            else if (enemyUnit2.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU2ElectricMove4();
            }
        }
    }

    //ENEMY UNIT 3 MOVES
    public void EU3Moves()
    {
        if (enemyUnit3.tag == "Fire")
        {
            if (enemyUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU3FireMove1();
            }
            else if (enemyUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU3FireMove2();
            }
            else if (enemyUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU3FireMove3();
            }
            else if (enemyUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<FireMovesAI>().EU3FireMove4();
            }
        }
        if (enemyUnit3.tag == "Water")
        {
            if (enemyUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU3WaterMove1();
            }
            else if (enemyUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU3WaterMove2();
            }
            else if (enemyUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU3WaterMove3();
            }
            else if (enemyUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WaterMovesAI>().EU3WaterMove4();
            }
        }
        if (enemyUnit3.tag == "Grass")
        {
            if (enemyUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU3GrassMove1();
            }
            else if (enemyUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU3GrassMove2();
            }
            else if (enemyUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU3GrassMove3();
            }
            else if (enemyUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<GrassMovesAI>().EU3GrassMove4();
            }
        }
        if (enemyUnit3.tag == "Earth")
        {
            if (enemyUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU3EarthMove1();
            }
            else if (enemyUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU3EarthMove2();
            }
            else if (enemyUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU3EarthMove3();
            }
            else if (enemyUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<EarthMovesAI>().EU3EarthMove4();
            }
        }
        if (enemyUnit3.tag == "Wind")
        {
            if (enemyUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU3WindMove1();
            }
            else if (enemyUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU3WindMove2();
            }
            else if (enemyUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU3WindMove3();
            }
            else if (enemyUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<WindMovesAI>().EU3WindMove4();
            }
        }
        if (enemyUnit3.tag == "Electric")
        {
            if (enemyUnit3.chosenMove == 1)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU3ElectricMove1();
            }
            else if (enemyUnit3.chosenMove == 2)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU3ElectricMove2();
            }
            else if (enemyUnit3.chosenMove == 3)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU3ElectricMove3();
            }
            else if (enemyUnit3.chosenMove == 4)
            {
                battleSystem.gameObject.GetComponent<ElectricMovesAI>().EU3ElectricMove4();
            }
        }
    }
}

