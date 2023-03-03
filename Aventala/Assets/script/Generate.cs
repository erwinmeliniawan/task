using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Kruin;
    public GameObject Kruin2;
    public GameObject Akasia;
    public GameObject Akasia2;
    public GameObject Obstacle;
    public GameObject Kruin3;
    public GameObject Akasia3;
    public GameObject treeInWorldObject;
    public int kruinAmount;
    public int kruinAmount2;
    public int kruinAmount3;
    public int AkasiaAmount;
    public int AkasiaAmount2;
    public int AkasiaAmount3;
    public int ObstacleAmount;
    List<GameObject> kruinList = new List<GameObject>();
    GameObject[] kruinArray;
    List<GameObject> kruinList2 = new List<GameObject>();
    GameObject[] kruinArray2;
    List<GameObject> kruinList3 = new List<GameObject>();
    GameObject[] kruinArray3;
    List<GameObject> akasiaList = new List<GameObject>();
    GameObject[] akasiaArray;
    List<GameObject> akasiaList2 = new List<GameObject>();
    GameObject[] akasiaArray2;
    List<GameObject> akasiaList3 = new List<GameObject>();
    GameObject[] akasiaArray3;
    List<GameObject> obstacleList = new List<GameObject>();
    GameObject[] obstacleArray;

    private void Start()
    {
        createAkasia();
        createKruin();
        createObstacle();
        createAKasia2();
        createKruin2();
        createAKasia3();
        createKruin3();
       
    }

    public void createAkasia()
    {
        for (int i = 0; i <= AkasiaAmount; i++)
        {
            akasiaList.Add(Instantiate<GameObject>(Akasia));
            akasiaArray = akasiaList.ToArray();
            akasiaList[i].transform.position = new Vector3(Random.Range(12, 45), 0, Random.Range(-12, 216));
        }
    }

    public void createAKasia2()
    {
        for (int i = 0; i <= AkasiaAmount2; i++)
        {
            akasiaList2.Add(Instantiate<GameObject>(Akasia2));
            akasiaArray2 = akasiaList2.ToArray();
            akasiaList2[i].transform.position = new Vector3(Random.Range(-8, -50), 0, Random.Range(-12, 190));
            //akasiaArray2[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 360.0f));

        }

    }
    public void createAKasia3()
    {
        for (int i = 0; i <= AkasiaAmount3; i++)
        {
            akasiaList3.Add(Instantiate<GameObject>(Akasia3));
            akasiaArray3 = akasiaList3.ToArray();
            akasiaList3[i].transform.position = new Vector3(Random.Range(-8, -50), 0, Random.Range(-12, 190));
            akasiaArray3[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 360.0f));

        }

    }

    public void createKruin2()
    {
        for (int i = 0; i <= kruinAmount2; i++)
        {
            kruinList2.Add(Instantiate<GameObject>(Kruin2));
            kruinArray2 = kruinList2.ToArray();
            kruinArray2[i].transform.position = new Vector3(Random.Range(12, 45), 0, Random.Range(-12, 190));
            kruinArray2[i].transform.parent = treeInWorldObject.transform;
            Kruin2.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            Kruin2.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }

    public void createKruin3()
    {
        for (int i = 0; i <= kruinAmount3; i++)
        {
            kruinList3.Add(Instantiate<GameObject>(Kruin3));
            kruinArray3 = kruinList3.ToArray();
            kruinArray3[i].transform.position = new Vector3(Random.Range(-8, -20), 0, Random.Range(-12, 190));
            kruinArray3[i].transform.parent = treeInWorldObject.transform;
            Kruin3.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            Kruin3.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }
    public void createKruin()
    {
        for (int i = 0; i <= kruinAmount; i++)
        {
            kruinList.Add(Instantiate<GameObject>(Kruin));
            kruinArray = kruinList.ToArray();
            kruinArray[i].transform.position = new Vector3(Random.Range(12, 45), 0, Random.Range(-12, 190));
            kruinArray[i].transform.parent = treeInWorldObject.transform;
            kruinArray[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            kruinArray[i].transform.localScale = new Vector3(Random.Range(40, 60), Random.Range(40, 60) , Random.Range(40, 60));
        }
    }

    public void createObstacle()
    {
        for (int i = 0; i <= ObstacleAmount; i++)
        {
            obstacleList.Add(Instantiate<GameObject>(Obstacle));
            obstacleArray = obstacleList.ToArray();
            obstacleArray[i].transform.position = new Vector3(Random.Range(-7, 11), 0, Random.Range(68, 150));
            obstacleArray[i].transform.parent = treeInWorldObject.transform;
            Obstacle.transform.rotation = Quaternion.Euler(Random.Range(0.0f, 0.0f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 0.0f));
           // Obstacle.transform.localScale = new Vector3(Random.Range(0, 14), Random.Range(0, 14), Random.Range(0, 14));
            //yourSphere.rotation = Quaternion.Euler(Randon.Range(0.0f, 360.0f), Randon.Range(0.0f, 360.0f), Randon.Range(0.0f, 360.0f));
        }

    }

}
