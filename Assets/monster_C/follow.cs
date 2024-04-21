using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject player;
    public GameObject Bgui;
    Vector3 hou =new Vector3(0,-3.7f,1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Bgui.transform.position=player.transform.position+hou;
    }
}
