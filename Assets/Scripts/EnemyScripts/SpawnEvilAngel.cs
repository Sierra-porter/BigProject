using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEvilAngel : MonoBehaviour
{
    public GameObject PEvilAngel;
    public CharacterStats st;
    public CharacterStats est;
    public Text info;
    public int EvilAngelCount;

    void Start()
    {

    }


    public void test()
    {
        print("IT'S WORK!!");
    }
    int I = 0;
    int J = 0;
    private bool EarnAward = true;

    private void FixedUpdate()
    {
        if (I == 500)
        {
            st.ScoreAward += 1;
            if (J < EvilAngelCount)
            {
                Instantiate(PEvilAngel);
                I = 0;
                J++;
            }
        }
        if (est.HpCur < 0)
        {
            if (EarnAward)
            {
                EarnAward = false;
                st.ScoreAward += est.EnemyBounty;
            }
        }
        
        I++;
    }
}
