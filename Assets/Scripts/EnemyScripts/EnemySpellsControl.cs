using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpellsControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpellAttack;
    private CharacterStats st;
    private int Mull = 3;
    void Start()
    {
        st = gameObject.GetComponent<CharacterStats>();

    }

    public void FAtack()
    {
        if (I > st.SpeedAttack)
        {
            I = 0;
            GameObject g = Instantiate(SpellAttack);
            Vector2 V = gameObject.GetComponent<Rigidbody2D>().velocity;

            g.transform.position = gameObject.transform.position;
            g.transform.localScale = new Vector3(V.x > 0 ? 1 : -1, 1);
            if (V.x == 0 && V.y == 0)
            {
                V.y = (float)gameObject.GetComponent<CharacterStats>().Speed * (-1);
            }
            V.x *= Mull;
            V.y *= Mull;
            if (V.y != 0)
            {
                g.transform.rotation = Quaternion.Euler(0, 0, 90 * (V.y > 0 ? -1 : 1));
            }
            g.GetComponent<Rigidbody2D>().velocity = V;
            g.GetComponent<SpellsStats>().Attack = gameObject.GetComponent<CharacterStats>().Attack;
        }
    }
    private int I = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        I++;
        if (st.SpeedAttack == 0) return;
        FAtack();
    }
}
