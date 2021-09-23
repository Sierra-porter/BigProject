using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ShieldSpell;
    private CharacterStats st;
    public Image Img;
    private bool Active = false;
    public Text info;


    void Start()
    {
        st = gameObject.GetComponent<CharacterStats>();
    }


    public void ShieldCoolDown()
    {
        st.ShieldRegenBonus = 1;
        if (I > st.ShieldRecharge && st.ManaCur>=st.ShieldSpellMana)
        {
            st.ManaCur -= st.ShieldSpellMana;
            Active = true;
            I = 0;
            ShieldSpell.SetActive(true);
            st.HpRegen += st.ShieldRegenBonus;
            
        }
    }


  

    private int I = 0;
    // Update is called once per frame
   void FixedUpdate()
    {
        I++;
       
        if (I > 200 && Active)
        {
            ShieldSpell.SetActive(false);
            st.HpRegen -= st.ShieldRegenBonus;
            Active = false;
        }
        if (st.ShieldRecharge == 0) return;
        Img.fillAmount = I / st.ShieldRecharge;
    }
}
