using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlControl : MonoBehaviour
{
    public CharacterStats st;
    public GameObject Teleport1;
    public GameObject Teleport2;
    public GameObject Teleport3;
    public GameObject HellTeleport;


    private void Update()
    {
        if (st.lvl >= 1)
        {
            Teleport1.SetActive(true);
        }
        if (st.lvl >= 2)
        {
            Teleport2.SetActive(true);
        }
        if (st.lvl >= 3)
        {
            Teleport3.SetActive(true);
        }
        if (st.lvl >= 4)
        {
            HellTeleport.SetActive(true);
        }


    }
}
