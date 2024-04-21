using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk1 : MonoBehaviour
{
    private CharacterController Sgui;
    public GameObject SmallMonster;
    public GameObject player;
    float timer=0;
    // Vector3 gui=new Vector3(0.01f,0.31f,0.01f);
    //Sgui=GetComponent<CharacterController>();  
     
    //float timer2=0;
    // Start is called before the first frame update
    void Start()
    {
      // Vector3 gui =SmallMonster.transform.position.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer%2>1){
        GetComponent<Animator>().SetBool("walk",true);
        SmallMonster.transform.LookAt(player.transform.position-Vector3.up*1);
        transform.Translate(Vector3.forward*0.03f);
        //Sgui.Move(player.transform.position-gui*0.1f);
        }
        else if (timer%2<1 &&timer>2){
        transform.Translate(Vector3.back*0.03f);
        }
    }
}
