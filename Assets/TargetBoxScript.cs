using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoxScript : MonoBehaviour
{
  
    private GameObject TargetSpawner;
    
    void Start()
    {
        TargetSpawner = GameObject.FindGameObjectWithTag("TargetSpawner");
        Debug.Log ("ddddddddddddddddddddd");   

    }

   void OnCollisionEnter(Collision collision){

       Debug.Log ("+++++++++++++++++++++++++++++++++++++++++++++ on collision enter"); 

        if(collision.gameObject.tag == "ball"){
            Destroy(this.gameObject);
            TargetSpawner.GetComponent<TargetSpawner>().setNeedSpawn();
        }

    


 }


}
