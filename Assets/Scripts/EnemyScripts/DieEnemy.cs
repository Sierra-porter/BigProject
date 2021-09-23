using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterStats est;
    void Start()
    {
        
    }

    // Update is called once per frame

        // Update is called once per frame
        void FixedUpdate()
        {
            if (est.HpCur < 0)
            {
            Destroy(gameObject);
            }
        }

}
