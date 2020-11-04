using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

     public GameObject TargetPrefab;
  
     public GameObject PlayPlane;
     private GameObject newTarget;

     private bool needSpawn = false;


    void Start()
    {
         spawnNewTarget();
         
    }

    // Update is called once per frame
    void Update()
    {
        
        if (needSpawn) {
            spawnNewTarget();
        }
    }


    public void spawnNewTarget() {
        needSpawn = false;
        newTarget = Instantiate(TargetPrefab, 
                                    new Vector3 (Random.Range (-10, 40 ), Random.Range (0, 5), Random.Range(-17, 17) )  ,
                                    Quaternion.identity);

    }

    public void setNeedSpawn () {
        needSpawn = true;
    }

}
