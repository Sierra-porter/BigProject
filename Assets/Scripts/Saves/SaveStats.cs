using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStats : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterStats st;
    private void Awake()
    {

        LoadStatsChar();
    }
   
     public void SaveStatsChar()
    {
     
        PlayerPrefs.SetFloat("Score" + "", st.Score);
        PlayerPrefs.SetFloat("HpMax" + "", st.HpMax);
        PlayerPrefs.SetFloat("HpCur" + "", st.HpCur);
        PlayerPrefs.SetFloat("HpRegen" + "", st.HpRegen);
        PlayerPrefs.SetFloat("Attack" + "", st.Attack);
        PlayerPrefs.SetFloat("SpeedAttack" + "", st.SpeedAttack);
        PlayerPrefs.SetFloat("Speed" + "", st.Speed);
        PlayerPrefs.SetFloat("Score" + "", st.Score);
        PlayerPrefs.SetFloat("lvl" + "", st.lvl);

    }
    public void LoadStatsChar()
    {
        st.Score = PlayerPrefs.GetFloat("Score" + "", st.Score);
        st.HpMax = PlayerPrefs.GetFloat("HpMax" + "", st.HpMax);
        st.HpCur = PlayerPrefs.GetFloat("HpCur" + "", st.HpCur);
        st.HpRegen = PlayerPrefs.GetFloat("HpRegen" + "", st.HpRegen);
        st.Attack = PlayerPrefs.GetFloat("Attack" + "", st.Attack);
        st.SpeedAttack = PlayerPrefs.GetFloat("SpeedAttack" + "", st.SpeedAttack);
        st.Speed = PlayerPrefs.GetFloat("Speed" + "", st.Speed);
        st.lvl = PlayerPrefs.GetFloat("lvl" + "", st.lvl);

    }

}
