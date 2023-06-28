using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("attack")&& currentState !=PlayerState.a)
        {
            StartCoroutine(AttackCo());
        }
    }
    private IEnumerator AttackCo()
    {
        Animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        Animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);
        currentState = PlayerState.walk;
    }
}

