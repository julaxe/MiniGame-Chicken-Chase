using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listClouds;

    [SerializeField]
    private GameObject cloud;

    [SerializeField]
    private float minX;
    [SerializeField]
    private float maxX;

    [SerializeField]
    private float minZ;
    [SerializeField]
    private float maxZ;

    private double timer;
    private float spawnTimer;

    [SerializeField]
    private int coolDown;

    [SerializeField]
    private float cloudSpeed;

    // Start is called before the first frame update
    void Start()
    {
        listClouds = new List<GameObject>();
        timer = 0;
        spawnTimer = Random.Range(1.0f, coolDown);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTimer)
        {
            CreateCloud();

            spawnTimer = Random.Range(1.0f, coolDown);
            timer = 0;
        }
        UpdateClouds();
        timer += Time.deltaTime;
    }

    void CreateCloud()
    {
        GameObject temp = Instantiate(cloud);
        float xLocation = transform.position.x + Random.Range(minX, maxX);
        float zLocation = transform.position.z + Random.Range(minZ, maxZ);
        float yLocation = transform.position.y;
        Vector3 randomLocation = new Vector3(xLocation, yLocation, zLocation);
        temp.transform.position = randomLocation;
        listClouds.Add(temp);
    }

    void UpdateClouds()
    {
        foreach(GameObject cloud in listClouds)
        {
            if(cloud != null)
            {
                cloud.transform.position = cloud.transform.position + (Vector3.down * cloudSpeed) * Time.deltaTime;
            }
        }

        CheckBoundaries();
    }

    void CheckBoundaries()
    {
        float minY = -400.0f;
        if(listClouds.Count > 0)
        {
            if(listClouds[0].transform.position.y < minY)
            {
                Destroy(listClouds[0]);
                listClouds.RemoveAt(0);
            }
        }
    }
}
