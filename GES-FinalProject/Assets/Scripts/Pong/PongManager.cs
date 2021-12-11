using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongManager : MonoBehaviour
{
    [SerializeField] public GameObject ballPrefab;
    [SerializeField] public Text leftScoreText;
    [SerializeField] public Text rightScoreText;
    public int leftPlayerScore;
    public int rightPlayerScore;

    private void OnDisable()
    {
        PlayerPrefs.SetInt("leftPlayerScore", leftPlayerScore);
        PlayerPrefs.SetInt("rightPlayerScore", rightPlayerScore);
    }

    private void Start()
    {
        leftPlayerScore = PlayerPrefs.GetInt("leftPlayerScore", leftPlayerScore);
        leftScoreText.text = "" + leftPlayerScore;
        rightPlayerScore = PlayerPrefs.GetInt("rightPlayerScore", rightPlayerScore);
        rightScoreText.text = "" + rightPlayerScore;
    }

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

    public void ResetScore()
    {
        leftPlayerScore = 0;
        rightPlayerScore = 0;
        leftScoreText.text = "" + leftPlayerScore;
        rightScoreText.text = "" + rightPlayerScore;
    }
}
