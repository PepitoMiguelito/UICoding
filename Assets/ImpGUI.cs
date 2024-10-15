using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq.Expressions;
public class ImpGUI : MonoBehaviour
{

    public string labelText;
    private void OnGUI()
    {
        GUI.Box(new Rect(227, 120, 995, 400  ), "Options");        

        if(GUI.Button(new Rect( 260 , 145, 90, 80 ), "Leader"))
        {
            print("Player One");
            labelText = "Name: John\n\rAge: 17\n\rEthnicity : Filipino";
        }
        if (GUI.Button(new Rect(260, 275, 90, 80), "Big Booty Mf"))
        {
            print("pTwo");
            labelText = "Name: Andrei\n\rAge: 1999\n\rEthnicity : AncientBlack";
        }
        if (GUI.Button(new Rect(260, 415, 90, 80), "ScoliosisGuy"))
        {
            print("pThree");
            labelText = "Name: Karl\n\rAge: 45\n\rEthnicity : African American\n\rAchievements : Child Sexual Abuse, Child Abusement, Child Predator, SmartSchoolBoy9 no.2";
        }

        GUI.Label(new Rect(750, 250, 200, 200), labelText);
    }

    
}
