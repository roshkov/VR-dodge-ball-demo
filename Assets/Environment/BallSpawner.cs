using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject BallPrefab;
    private GameObject newBall;
    private Rigidbody newBallRB;

    // Start is called before the first frame update
    void Start()

    {
        newBall = Instantiate(BallPrefab, gameObject.transform.position, Quaternion.identity);
        // StartCoroutine(ThrowBallAtPlayer(newBall) );
    }

    // Update is called once per frame
    void Update()
    {
       
         
    }

    //   IEnumerator ThrowBallAtPlayer(GameObject thenewBall) {
    //      Debug.Log("1ahaaaa");
    //      yield return new WaitForSeconds(5);

    //     Debug.Log("2ahaaaa");
    //     // var heading = transform.position - thenewBall.transform.position;
    //     // thenewBall.GetComponent<Rigidbody>().AddForce (new Vector3(heading.x, 1, heading.z) * 50);
    
    // }

}
