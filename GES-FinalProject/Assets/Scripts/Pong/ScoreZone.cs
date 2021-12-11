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
            pongManager.leftPlayerScore += 1;
            pongManager.leftScoreText.text = "" + pongManager.leftPlayerScore;
        }
        else if (this.gameObject.name.Equals("LeftScoreZone"))
        {
            pongManager.rightPlayerScore += 1;
            pongManager.rightScoreText.text = "" + pongManager.rightPlayerScore;
        }
    }
}
