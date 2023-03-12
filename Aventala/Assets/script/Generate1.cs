using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Pohon6;
    public int PohonAmount6;
    List<GameObject> pohonList6 = new List<GameObject>();
    GameObject[] pohonArray6;

    public GameObject Pohon5;
    public int PohonAmount5;
    List<GameObject> pohonList5 = new List<GameObject>();
    GameObject[] pohonArray5;

    public GameObject Pohon4;
    public int PohonAmount4;
    List<GameObject> pohonList4 = new List<GameObject>();
    GameObject[] pohonArray4;

    public GameObject Pohon3;
    public int PohonAmount3;
    List<GameObject> PohonList3 = new List<GameObject>();
    GameObject[] PohonArray3;

    public GameObject Pohon2;
    public int PohonAmount2;
    List<GameObject> PohonList2 = new List<GameObject>();
    GameObject[] PohonArray2;

    public GameObject Pohon;
    public int PohonAmount;
    List<GameObject> PohonList = new List<GameObject>();
    GameObject[] PohonArray;

    public GameObject Paku;
    public int PakuAmount;
    List<GameObject> PakuList = new List<GameObject>();
    GameObject[] PakuArray;

    public GameObject Paku3;
    public int PakuAmount3;
    List<GameObject> PakuList3 = new List<GameObject>();
    GameObject[] PakuArray3;

    public GameObject Heliconia;
    public int HeliconiaAmount;
    List<GameObject> heliconiaList = new List<GameObject>();
    GameObject[] heliconiaArray;

    public GameObject Heliconia2;
    public int HeliconiaAmount2;
    List<GameObject> heliconiaList2 = new List<GameObject>();
    GameObject[] heliconiaArray2;

    public GameObject treeInWorldObject;

    public GameObject Obstacle;
    public int ObstacleAmount;
    List<GameObject> obstacleList = new List<GameObject>();
    GameObject[] obstacleArray;   


    private void Start()
    {

        
       
      //  createPaku();
       // createPaku3();
       // createObstacle();
        createPohon();
        createPohon2();
        createPohon4();
        createPohon3();
        createPohon5();
        createPohon6();
        createHeliconia();
        createHeliconia2(); 
       
    }

    public void createPohon()
    {
        for (int i = 0; i <= PohonAmount; i++)
        {
            PohonList.Add(Instantiate<GameObject>(Pohon));
            PohonArray = PohonList.ToArray();
            PohonList[i].transform.position = new Vector3(Random.Range(-99, -80), 0, Random.Range(1, 159));
        }
    }

    public void createPohon2()
    {
        for (int i = 0; i <= PohonAmount2; i++)
        {
            PohonList2.Add(Instantiate<GameObject>(Pohon2));
            PohonArray2 = PohonList2.ToArray();
            PohonList2[i].transform.position = new Vector3(Random.Range(-99, -80), 0, Random.Range(1, 159));
            //PohonArray2[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 360.0f));

        }

    }
    public void createPohon3()
    {
        for (int i = 0; i <= PohonAmount3; i++)
        {
            PohonList3.Add(Instantiate<GameObject>(Pohon3));
            PohonArray3 = PohonList3.ToArray();
            PohonList3[i].transform.position = new Vector3(Random.Range(-140, -130), 0, Random.Range(1, 190));
            PohonArray3[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 360.0f));

        }

    }

    public void createPohon4()
    {
        for (int i = 0; i <= PohonAmount4; i++)
        {
            pohonList4.Add(Instantiate<GameObject>(Pohon4));
            pohonArray4 = pohonList4.ToArray();
            pohonArray4[i].transform.position = new Vector3(Random.Range(-140, -130), 0, Random.Range(1, 190));
            pohonArray4[i].transform.parent = treeInWorldObject.transform;
           // Pohon4.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
           // Pohon4.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }

    public void createPohon5()
    {
        for (int i = 0; i <= PohonAmount5; i++)
        {
            pohonList5.Add(Instantiate<GameObject>(Pohon5));
            pohonArray5 = pohonList5.ToArray();
            pohonArray5[i].transform.position = new Vector3(Random.Range(-8, 101), 0, Random.Range(223, 232));
            pohonArray5[i].transform.parent = treeInWorldObject.transform;
          //  Pohon5.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
           // Pohon5.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }

    public void createPohon6()
    {
        for (int i = 0; i <= PohonAmount6; i++)
        {
            pohonList6.Add(Instantiate<GameObject>(Pohon6));
            pohonArray6 = pohonList6.ToArray();
            pohonArray6[i].transform.position = new Vector3(Random.Range(11, 120), 0, Random.Range(180, 198));
            pohonArray6[i].transform.parent = treeInWorldObject.transform;
           // Pohon6.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
           // Pohon6.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }


    public void createHeliconia()
    {
        for (int i = 0; i <= HeliconiaAmount; i++)
        {
            heliconiaList.Add(Instantiate<GameObject>(Heliconia));
            heliconiaArray = heliconiaList.ToArray();
            heliconiaList[i].transform.position = new Vector3(Random.Range(-6, -10), 0, Random.Range(-12, 190));
           // heliconiaArray[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 360.0f));

        }

    }

    public void createHeliconia2()
    {
        for (int i = 0; i <= HeliconiaAmount2; i++)
        {
            heliconiaList2.Add(Instantiate<GameObject>(Heliconia2));
            heliconiaArray2 = heliconiaList2.ToArray();
            heliconiaList2[i].transform.position = new Vector3(Random.Range(12, 14), 0, Random.Range(-12, 190));
            // heliconiaArray[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 360.0f));

        }

    }

  
    public void createPaku3()
    {
        for (int i = 0; i <= PakuAmount3; i++)
        {
            PakuList3.Add(Instantiate<GameObject>(Paku3));
            PakuArray3 = PakuList3.ToArray();
            PakuArray3[i].transform.position = new Vector3(Random.Range(-8, -20), 0, Random.Range(-12, 190));
            PakuArray3[i].transform.parent = treeInWorldObject.transform;
          //  Paku3.transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
          //  Paku3.transform.localScale = new Vector3(Random.Range(30, 60), Random.Range(30, 60), Random.Range(30, 60));
        }
    }
    public void createPaku()
    {
        for (int i = 0; i <= PakuAmount; i++)
        {
            PakuList.Add(Instantiate<GameObject>(Paku));
            PakuArray = PakuList.ToArray();
            PakuArray[i].transform.position = new Vector3(Random.Range(12, 45), 0, Random.Range(-12, 190));
            PakuArray[i].transform.parent = treeInWorldObject.transform;
           // PakuArray[i].transform.rotation = Quaternion.Euler(Random.Range(-90f, -90f), Random.Range(-10.0f, 90.0f), Random.Range(0.0f, 360.0f));
           // PakuArray[i].transform.localScale = new Vector3(Random.Range(40, 60), Random.Range(40, 60) , Random.Range(40, 60));
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
