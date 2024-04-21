using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class biggui : MonoBehaviour
{
    //public GameObject person;
    public Animator Anim;
    float timer= 0;
    // Start is called before the first frame update
    void Start()
    {
    
        //GetComponent<Animator>().SetBool("walking", true);
    }

    // Update is called once per frame
    void Update()
    { 
       Anim =GetComponent<Animator>();
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if (timer%12>=11){
        
            Anim.SetTrigger("attack");
           // Debug.Log("ATTACK");
        }
        
    }
}
