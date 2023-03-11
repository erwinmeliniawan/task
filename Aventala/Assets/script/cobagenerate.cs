using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobagenerate : MonoBehaviour
{
    public GameObject Paku;
    public GameObject Pohon4;
    public GameObject Akasia;
    public GameObject treeInWorldObject;
    public int PakuAmount;
    public int akasiaAmount;
    public int Pohon4Amount;

    List<GameObject> PakuList = new List<GameObject>();
    GameObject[] PakuArray;
    List<GameObject> PakuList2 = new List<GameObject>();
    GameObject[] PakuArray2;
    List<GameObject> akasiaList = new List<GameObject>();
    GameObject[] akasiaArray;

    private void Start()
    {
        
    }

    public void createPohon4()
    {
        for (int i = 0; i <= Pohon4Amount; i++)
        {
            PakuList2.Add(Instantiate<GameObject>(Pohon4));
            PakuArray2 = PakuList2.ToArray();
            PakuArray2[i].transform.position = new Vector3(Random.Range(-43, 43), 0, Random.Range(-43, 43));
            PakuArray2[i].transform.parent = treeInWorldObject.transform;
            Pohon4.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            Pohon4.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }
    public void createPaku()
    {
        for (int i = 0; i <= PakuAmount; i++)
        {
            PakuList.Add(Instantiate<GameObject>(Paku));
            PakuArray = PakuList.ToArray();
            PakuArray[i].transform.position = new Vector3(Random.Range(-43, 43), 0, Random.Range(-43, 43));
            PakuArray[i].transform.parent = treeInWorldObject.transform;
            PakuArray[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
            PakuArray[i].transform.localScale = new Vector3(Random.Range(40, 60), Random.Range(40, 60), Random.Range(40, 60));
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
