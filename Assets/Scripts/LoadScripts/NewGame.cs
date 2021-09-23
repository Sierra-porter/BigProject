using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public SaveStats sv;
    public CharacterStats st;
    public void NewGameClick()
    {
        st.HpMax = 10;
        st.HpCur = 1;
        st.HpRegen = 0.01f;
        st.ManaMax = 10;
        st.ManaCur = 1;
        st.ManaRegen = 0.01f;
        st.Speed = 2;
        st.SpeedAttack = 100;
        st.ShieldRecharge = 500;
        st.ShieldRegenBonus = 1;
        st.ShieldSpellMana = 2;
        st.UltimateCoolDown = 3000;
        st.UltimateDmgBonus = 30;
        st.UltimateMana = 8;
        st.UltimateSpeedBonus = 2;
        st.Attack = 5;
        st.FireBallMana = 2;
        st.Score = 0;
        st.lvl = 0;
        st.ScoreAward = 0;
            sv.SaveStatsChar();
            Application.LoadLevel("CharacterHub");
 

    }
}
