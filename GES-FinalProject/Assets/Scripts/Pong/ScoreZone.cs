using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    [SerializeField] PongManager pongManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //pongManager.GetComponent<PongManager>().SpawnBall();
        pongManager.SpawnBall();
        if (this.gameObject.name.Equals("RightScoreZone"))
        {

        }
        else if (this.gameObject.name.Equals("LeftScoreZone"))
        {

        }
    }
}
