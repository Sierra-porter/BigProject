using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltimateSpell : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterStats st;
    public GameObject Ulticon;
    private CharacterControl ult;
    public Image Img;
    private bool Active = false;
    public Text info;


    void Start()
    {
        st = gameObject.GetComponent<CharacterStats>();
        ult = gameObject.GetComponent<CharacterControl>();
    }


    public void UltimateCoolDown()
    {
        if (I > st.UltimateCoolDown && st.ManaCur >= st.UltimateMana)
        {
            st.ManaCur -= st.UltimateMana;
            Active = true;
            I = 0;
            Ulticon.SetActive(true);
            ult.Ult();
            st.Attack += st.UltimateDmgBonus;
            st.Speed += st.UltimateSpeedBonus;

        }
    }



    private int I = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        I++;
        if (I > 1500 && Active)
        {
            Ulticon.SetActive(false);
            st.Attack -= st.UltimateDmgBonus;
            st.Speed -= st.UltimateSpeedBonus;
            Active = false;
        }
        if (st.UltimateCoolDown == 0) return;
        Img.fillAmount = I / st.UltimateCoolDown;
    }
}
