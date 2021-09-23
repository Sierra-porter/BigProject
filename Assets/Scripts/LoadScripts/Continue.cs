using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public SaveStats sv;
    public CharacterStats st;
    public void ContinueClck()
    {
       
            sv.SaveStatsChar();
            Application.LoadLevel("CharacterHub");


    }
}

