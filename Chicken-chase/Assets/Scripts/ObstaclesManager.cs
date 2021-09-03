using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabBranch;

    [SerializeField]
    private GameObject prefabFench;

    private List<GameObject> listObstacles;
    private double timer;
    private int cd;
    private int randomCd;

    void Start()
    {
        listObstacles = new List<GameObject>();
        CalculateNextObstacle();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > cd)
        {
            SpawnObstacle();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void SpawnObstacle()
    {
        int randomObstacle = Random.Range(1, 3);
        GameObject temp;
        if (randomObstacle == 1)
        {
            temp = Instantiate(prefabFench);
        }
        else
        {
            temp = Instantiate(prefabBranch);
        }
        listObstacles.Add(temp);
        CalculateNextObstacle();
    }
    void CalculateNextObstacle()
    {
        randomCd = Random.Range(1, 5);
        if (randomCd == 1 || randomCd == 2)
        {
            cd = 1;
        }
        else if (randomCd == 3)
        {
            cd = 2;
        }
        else
        {
            cd = 3;
        }
    }
}
