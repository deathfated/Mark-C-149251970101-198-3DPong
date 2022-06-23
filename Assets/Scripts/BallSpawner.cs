using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    /*public List<GameObject> BallTemplateList;
    private List<GameObject> BallList;

    public int maxBallAmount;
    public Transform spawnArea;
    public Vector3 BallAreaMin;
    public Vector3 BallAreaMax;*/

    public int ball1spawn;
    private float timer;

    private void Start()
    {
        //BallList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > ball1spawn)
        {
            //GenerateRandomPowerUp();
            timer -= ball1spawn;
        }
    }

    /*public void GenerateRandomBall() 
    { 
        GenerateRandomBall(new Vector3(Random.Range(BallAreaMin.x, BallAreaMax.x), Random.Range(BallAreaMin.y, BallAreaMax.y), Random.Range(BallAreaMin.z, BallAreaMax.z))); 
    } 
 
    public void GenerateRandomBall(Vector3 position) 
    { 
        if (BallList.Count >= maxBallAmount) 
        { 
            return; 
        } 
 
        if (position.x < BallAreaMin.x || 
            position.x > BallAreaMax.x || 
            position.y < BallAreaMin.y || 
            position.y > BallAreaMax.y ||
            position.z < BallAreaMin.z ||
            position.z > BallAreaMax.z) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, BallTemplateList.Count); 
 
        GameObject Ball = Instantiate(BallTemplateList[randomIndex], new Vector3(position.x, position.y, BallTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea); 
        Ball.SetActive(true); 
 
        BallList.Add(Ball); 
    } 

    public void RemoveBall(GameObject ball)
    {
        BallList.Remove(ball);
        Destroy(ball);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }*/
}
