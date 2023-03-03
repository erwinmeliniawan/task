using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobagenerate : MonoBehaviour
{
    public GameObject Kruin;
    public GameObject Kruin2;
    public GameObject Akasia;
    public GameObject treeInWorldObject;
    public int kruinAmount;
    public int akasiaAmount;
    public int kruin2Amount;

    List<GameObject> kruinList = new List<GameObject>();
    GameObject[] kruinArray;
    List<GameObject> kruinList2 = new List<GameObject>();
    GameObject[] kruinArray2;
    List<GameObject> akasiaList = new List<GameObject>();
    GameObject[] akasiaArray;

    private void Start()
    {
        
    }

    public void createKruin2()
    {
        for (int i = 0; i <= kruin2Amount; i++)
        {
            kruinList2.Add(Instantiate<GameObject>(Kruin2));
            kruinArray2 = kruinList2.ToArray();
            kruinArray2[i].transform.position = new Vector3(Random.Range(-43, 43), 0, Random.Range(-43, 43));
            kruinArray2[i].transform.parent = treeInWorldObject.transform;
            Kruin2.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            Kruin2.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }
    public void createKruin()
    {
        for (int i = 0; i <= kruinAmount; i++)
        {
            kruinList.Add(Instantiate<GameObject>(Kruin));
            kruinArray = kruinList.ToArray();
            kruinArray[i].transform.position = new Vector3(Random.Range(-43, 43), 0, Random.Range(-43, 43));
            kruinArray[i].transform.parent = treeInWorldObject.transform;
            kruinArray[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            kruinArray[i].transform.localScale = new Vector3(Random.Range(40, 60), Random.Range(40, 60), Random.Range(40, 60));
        }
    }

    public void createAkasia()
    {
        for (int i = 0; i <= akasiaAmount; i++)
        {
            akasiaList.Add(Instantiate<GameObject>(Akasia));
            akasiaArray = akasiaList.ToArray();
            akasiaList[i].transform.position = new Vector3(Random.Range(-43, 43), 0, Random.Range(-43, 43));
        }
    }
}
