using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public Button startGame;

    public Button fireSprite;
    public Button waterSprite;
    public Button grassSprite;
    public Button earthSprite;
    public Button windSprite;
    public Button electricSprite;

    public Image fireCheck;
    public Image waterCheck;
    public Image grassCheck;
    public Image earthCheck;
    public Image windCheck;
    public Image electricCheck;

    public bool fireChosen = false;
    public bool waterChosen = false;
    public bool grassChosen = false;
    public bool earthChosen = false;
    public bool windChosen = false;
    public bool electricChosen = false;

    public int selectedCharacter1 = 0;
    public int selectedCharacter2 = 0;
    public int selectedCharacter3 = 0;

    public void Start()
    {
        startGame.enabled = false;

        fireCheck.enabled = false;
        waterCheck.enabled = false;
        grassCheck.enabled = false;
        earthCheck.enabled = false;
        windCheck.enabled = false;
        electricCheck.enabled = false;

    }

    public void Update()
    {
        if (selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 != 0)
        {
            startGame.enabled = true;
        }
        else if(selectedCharacter1 == 0 || selectedCharacter2 == 0 || selectedCharacter3 == 0)
        {
            startGame.enabled = false;
        }
    }

    public void FireSelect()
    {
        if(fireChosen == false )
        { 
            if(selectedCharacter1 == 0 )
            {
                selectedCharacter1 = 1;
                fireChosen = true;
                fireCheck.enabled = true;
            }
            else if(selectedCharacter1 != 0 && selectedCharacter2 == 0)
            {
                selectedCharacter2 = 1;
                fireChosen = true;
                fireCheck.enabled = true;
            }
            else if(selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 == 0)
            {
                selectedCharacter3 = 1;
                fireChosen = true;
                fireCheck.enabled = true;
            }    
        }
        else if (fireChosen == true && selectedCharacter1 == 1)
        {
            fireChosen = false;
            fireCheck.enabled = false;
            selectedCharacter1 = 0;
        }
        else if (fireChosen == true && selectedCharacter2 == 1)
        {
            fireChosen = false;
            fireCheck.enabled = false;
            selectedCharacter2 = 0;
        }
        else if (fireChosen == true && selectedCharacter3 == 1)
        {
            fireChosen = false;
            fireCheck.enabled = false;
            selectedCharacter3 = 0;
        }
    }

    public void WaterSelect()
    {
        if (waterChosen == false)
        {
            
            if (selectedCharacter1 == 0)
            {
                selectedCharacter1 = 2;
                waterChosen = true;
                waterCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 == 0)
            {
                selectedCharacter2 = 2;
                waterChosen = true;
                waterCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 == 0)
            {
                selectedCharacter3 = 2;
                waterChosen = true;
                waterCheck.enabled = true;
            }
        }
        else if (waterChosen == true && selectedCharacter1 == 2)
        {
            waterChosen = false;
            waterCheck.enabled = false;
            selectedCharacter1 = 0;
        }
        else if (waterChosen == true && selectedCharacter2 == 2)
        {
            waterChosen = false;
            waterCheck.enabled = false;
            selectedCharacter2 = 0;
        }
        else if (waterChosen == true && selectedCharacter3 == 2)
        {
            waterChosen = false;
            waterCheck.enabled = false;
            selectedCharacter3 = 0;
        }
    }

    public void GrassSelect()
    {
        if (grassChosen == false)
        {
            
            if (selectedCharacter1 == 0)
            {
                selectedCharacter1 = 3;
                grassChosen = true;
                grassCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 == 0)
            {
                selectedCharacter2 = 3;
                grassChosen = true;
                grassCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 == 0)
            {
                selectedCharacter3 = 3;
                grassChosen = true;
                grassCheck.enabled = true;
            }
        }
        else if (grassChosen == true && selectedCharacter1 == 3)
        {
            grassChosen = false;
            grassCheck.enabled = false;
            selectedCharacter1 = 0;
        }
        else if (grassChosen == true && selectedCharacter2 == 3)
        {
            grassChosen = false;
            grassCheck.enabled = false;
            selectedCharacter2 = 0;
        }
        else if (grassChosen == true && selectedCharacter3 == 3)
        {
            grassChosen = false;
            grassCheck.enabled = false;
            selectedCharacter3 = 0;
        }
    }

    public void EarthSelect()
    {
        if (earthChosen == false)
        {

            if (selectedCharacter1 == 0)
            {
                selectedCharacter1 = 4;
                earthChosen = true;
                earthCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 == 0)
            {
                selectedCharacter2 = 4;
                earthChosen = true;
                earthCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 == 0)
            {
                selectedCharacter3 = 4;
                earthChosen = true;
                earthCheck.enabled = true;
            }
        }
        else if (earthChosen == true && selectedCharacter1 == 4)
        {
            earthChosen = false;
            earthCheck.enabled = false;
            selectedCharacter1 = 0;
        }
        else if (earthChosen == true && selectedCharacter2 == 4)
        {
            earthChosen = false;
            earthCheck.enabled = false;
            selectedCharacter2 = 0;
        }
        else if (earthChosen == true && selectedCharacter3 == 4)
        {
            earthChosen = false;
            earthCheck.enabled = false;
            selectedCharacter3 = 0;
        }
    }

    public void WindSelect()
    {
        if (windChosen == false)
        {

            if (selectedCharacter1 == 0)
            {
                selectedCharacter1 = 5;
                windChosen = true;
                windCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 == 0)
            {
                selectedCharacter2 = 5;
                windChosen = true;
                windCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 == 0)
            {
                selectedCharacter3 = 5;
                windChosen = true;
                windCheck.enabled = true;
            }
        }
        else if (windChosen == true && selectedCharacter1 == 5)
        {
            windChosen = false;
            windCheck.enabled = false;
            selectedCharacter1 = 0;
        }
        else if (windChosen == true && selectedCharacter2 == 5)
        {
            windChosen = false;
            windCheck.enabled = false;
            selectedCharacter2 = 0;
        }
        else if (windChosen == true && selectedCharacter3 == 5)
        {
            windChosen = false;
            windCheck.enabled = false;
            selectedCharacter3 = 0;
        }
    }

    public void ElectricSelect()
    {
        if (electricChosen == false)
        {

            if (selectedCharacter1 == 0)
            {
                selectedCharacter1 = 6;
                electricChosen = true;
                electricCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 == 0)
            {
                selectedCharacter2 = 6;
                electricChosen = true;
                electricCheck.enabled = true;
            }
            else if (selectedCharacter1 != 0 && selectedCharacter2 != 0 && selectedCharacter3 == 0)
            {
                selectedCharacter3 = 6;
                electricChosen = true;
                electricCheck.enabled = true;
            }
        }
        else if (electricChosen == true && selectedCharacter1 == 6)
        {
            electricChosen = false;
            electricCheck.enabled = false;
            selectedCharacter1 = 0;
        }
        else if (electricChosen == true && selectedCharacter2 == 6)
        {
            electricChosen = false;
            electricCheck.enabled = false;
            selectedCharacter2 = 0;
        }
        else if (electricChosen == true && selectedCharacter3 == 6)
        {
            electricChosen = false;
            electricCheck.enabled = false;
            selectedCharacter3 = 0;
        }
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter1", selectedCharacter1);
        PlayerPrefs.SetInt("selectedCharacter2", selectedCharacter2);
        PlayerPrefs.SetInt("selectedCharacter3", selectedCharacter3);
        SceneManager.LoadScene("Battle");
    }


}
