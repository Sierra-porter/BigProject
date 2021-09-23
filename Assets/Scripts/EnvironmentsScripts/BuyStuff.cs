using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyStuff : MonoBehaviour
{
    public WeaponStats ws;
    public CharacterStats st;
    public Text info;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        info.text = "| Cost:" + ws.Cost + "| " + "| Hp Bonus: " + ws.HpMax + "| " + "| Hp Regeneration: " + ws.HpRegen + " | " +
                  "| Mana Bonus: " + ws.ManaMax + " | " + "| Mana Regeneration: " + ws.ManaRegen + " | " + "| Speed Bonus: " + ws.Speed + " | " + "| Speed Attack Bonus: " + ws.SpeedAttack + " | " + "| Damage Bonus: " + ws.Attack + " | " + "| Already Have: " + ws.flag + " | ";

        if (collision.gameObject.tag == "Player" && st.Score>= ws.Cost && ws.flag==0 )
        {
            st.Score -= ws.Cost;
            st.HpMax += ws.HpMax;
            st.HpRegen += ws.HpRegen;
            st.ManaMax += ws.ManaMax;
            st.ManaRegen += ws.ManaRegen;
            st.Speed += ws.Speed;
            st.SpeedAttack += ws.SpeedAttack;
            st.Attack += ws.Attack;
            ws.flag = 1;
          


        }


    }
   
}
