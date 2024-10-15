using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq.Expressions;
public class ImpGUI : MonoBehaviour
{

    public string text = "FingerHeart";
    private int agep1 = 17;
    private int attackp1 = 50;
    private int sizep1 = 8;
   
    
    private int agep2 = 16;
    private int attackp2 = 55;
    private int sizep2 = 8;
    
    private int agep3 = 17;
    private int attackp3 = 1;
    private int sizep3 = 2;
    
    private void OnGUI()
    {
        GUI.Box(new Rect(227, 120, 995, 400  ), "Options");        

        if(GUI.Button(new Rect( 260 , 145, 90, 80 ), "Player One"))
        {
            print("Player One");
            text = $"Name : John \r\n Ethnicity : Filipino \r\n Age: {agep1} \r\n Attack : {attackp1} \r\n Size : {sizep1} ";
        }
        if (GUI.Button(new Rect(260, 275, 90, 80), "Player Two"))
        {
            print("pTwo");
            text = $"Name : Andrei \r\n Ethnicity : Filipino \r\n Age: {agep2} \r\n Attack : {attackp2} \r\n Size : {sizep2} "; 
        }
        if (GUI.Button(new Rect(260, 415, 90, 80), "Player Three" ))
        {
            print("pThree");
            text = $"Name : Karl \r\n Ethnicity : African American \r\n Age: {agep3} \r\n Attack : {attackp3} \r\n Size : {sizep3} ";
        }

        GUI.Label(new Rect(750, 250, 200, 200), text);
    }

    
}
