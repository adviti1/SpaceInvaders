using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {

            if (gameObject.tag == "Enemy")
            { 
                Destroy(gameObject);

            }
        
    }
}