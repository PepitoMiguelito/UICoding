using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq.Expressions;
public class ImpGUI : MonoBehaviour
{

    public string text = "FingerHeart";
    private int defensep1 = 17;
    private int attackp1 = 50;
    private int speedp1 = 8;
    private int luckp1 = 99;
    private int intelligencep1 = 98;
    private int specialp1 = 55;


    private int defensep2 = 16;
    private int attackp2 = 55;
    private int speedp2 = 8;
    private int luckp2 = 99;
    private int intelligencep2 = 95;
    private int specialp2 = 45;

    private int defensep3 = 17;
    private int attackp3 = 1;
    private int speedp3 = 2;
    private int luckp3 = 99999;
    private int intelligencep3 = 1;
    private int specialp3 = 99999;

    private void OnGUI()
    {
        GUI.Box(new Rect(227, 120, 995, 400  ), "Options");        

        if(GUI.Button(new Rect( 260 , 145, 90, 80 ), "Player One"))
        {
            print("Player One");
            text = $"Name : John \r\n Ethnicity : Filipino \r\n Defense : {defensep1} \r\n Attack : {attackp1} \r\n Speed : {speedp1} \r\n Luck : {luckp1} \r\n Intelligence : {intelligencep1} \r\n Special : {specialp1} ";
        }
        if (GUI.Button(new Rect(260, 275, 90, 80), "Player Two"))
        {
            print("pTwo");
            text = $"Name : Andrei \r\n Ethnicity : Filipino \r\n Defense : {defensep2} \r\n Attack : {attackp2} \r\n Speed : {speedp2} \r\n Luck : {luckp2} \r\n Intelligence : {intelligencep2} \r\n Special : {specialp2}  "; 
        }
        if (GUI.Button(new Rect(260, 415, 90, 80), "Player Three" ))
        {
            print("pThree");
            text = $"Name : Karl \r\n Ethnicity : African American \r\n Defense : {defensep3} \r\n Attack : {attackp3} \r\n Speed : {speedp3} \r\n Luck : {luckp3} \r\n Intelligence : {intelligencep3} \r\n Special : {specialp3}  ";
        }

        GUI.Label(new Rect(750, 250, 200, 200), text);
    }

    
}
