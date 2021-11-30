using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongManager : MonoBehaviour
{
    [SerializeField] public GameObject ballPrefab;


    IEnumerator Delay()
    {
        Debug.Log("Got to the coroutine");
        yield return new WaitForSeconds(2);
        Debug.Log("Finished coroutine");
        Instantiate(ballPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void SpawnBall()
    {
        Debug.Log("Make new ball");
        StartCoroutine(Delay());
        //Instantiate(ballPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
