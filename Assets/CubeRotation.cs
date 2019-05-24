using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

public class CubeRotation : MonoBehaviour
{
    public GameObject[] obj = new GameObject[28];
    public float n = 0;
    public float degree = 0;
    public Slider slider;
    public Button two, three;
    private Quaternion[] Q = new Quaternion[28];
    private Vector3[] V = new Vector3[28];
    float PosX(GameObject Obj)
    {
        Vector3 CubePos;
        CubePos = Obj.transform.position;
        return CubePos.x;
    }
    float PosY(GameObject Obj)
    {
        Vector3 CubePos;
        CubePos = Obj.transform.position;
        return CubePos.y;
    }
    float PosZ(GameObject Obj)
    {
        Vector3 CubePos;
        CubePos = Obj.transform.position;
        return CubePos.z;
    }
    public void SetParentUp()
    {
        for (int i = 1; i <= 27; i++)
        if (PosY(obj[i]) >= 1.3)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentRight()
    {
        for (int i = 1; i <= 27; i++)
        if (PosZ(obj[i]) >= -2)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentLeft()
    {
        for (int i = 1; i <= 27; i++)
        if (PosZ(obj[i]) <= -3)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentDown()
    {
        for (int i = 1; i <= 27; i++)
        if (PosY(obj[i]) <= 0.5)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentFrontVertical()
    {
        for (int i = 1; i <= 27; i++)
        if (PosZ(obj[i]) <= -2 && PosZ(obj[i]) >= -3)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentCentrFrontVertical()
    {
        for (int i = 1; i <= 27; i++)
        if (PosX(obj[i]) <= -0.5 && PosX(obj[i]) >= -1.5)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentFront()
    {
        for (int i = 1; i <= 27; i++)
        if (PosX(obj[i]) <= 0.3 && PosX(obj[i]) >= -0.3)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentFrontHorizontal()
    {
        for (int i = 1; i <= 27; i++)
        if (PosY(obj[i]) <= 1.4 && PosY(obj[i]) >= 0.6)
        obj[i].transform.SetParent(obj[7].transform);
    }
    public void SetParentback()
    {
        for (int i = 1; i <= 27; i++)
        if (PosX(obj[i]) <= -1.5)
        obj[i].transform.SetParent(obj[7].transform);
    }
    void Start()
    {
        for (int i = 0; i <= 27; i++)
        {
            Q[i] = obj[i].transform.rotation;
            V[i] = obj[i].transform.position;
        }
    }

    void rotate(float x, float y, float z)
    {
        obj[7].transform.Rotate(x, y, z);
        obj[7].transform.DetachChildren();
        obj[7].transform.Rotate(-x, -y, -z);
        n++;
    }

     public void Update()
     {
        slider.interactable = false;
        two.interactable = false;
        three.interactable = false;
        degree = slider.value;
        if (slider.value == 4) degree = 3;
        if (slider.value == 7) degree = 6;
        if (slider.value == 8) degree = 9;
        if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 1)
        {
            gameObject.GetComponent<Rotation>().prov2 = true;
            SetParentUp();
            rotate(0, 1 * degree, 0); 
         }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 2)
             {
                 gameObject.GetComponent<Rotation>().prov2 = true;
                 SetParentUp();
                 rotate(0, -1 * degree, 0); 
             }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 3)
             {
                 gameObject.GetComponent<Rotation>().prov2 = true;
                 SetParentRight();
                 rotate(0, 0, 1 * degree);
             }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 4)
             {
                 gameObject.GetComponent<Rotation>().prov2 = true;
                 SetParentRight();
                 rotate(0, 0, -1 * degree);
             }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 5)
             {
                 gameObject.GetComponent<Rotation>().prov2 = true;
                 SetParentLeft();
                 rotate(0, 0, -1 * degree);
             }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 6)
             {
                 gameObject.GetComponent<Rotation>().prov2 = true;
                 SetParentLeft();
                 rotate(0, 0, 1 * degree);
             }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 7)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentDown();
                rotate(0, 1 * degree, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 8)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentDown();
                rotate(0, -1 * degree, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 9)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentFrontVertical();
                rotate(0, 0, 1 * degree);
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 10)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentFrontVertical();
                rotate(0, 0, -1 * degree);
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 11)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentFrontHorizontal();
                rotate(0, -1 * degree, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 12)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentFrontHorizontal();
                rotate(0, 1 * degree, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 13)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentFront();
                rotate(-1 * degree, 0, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 14)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentFront();
                rotate(1 * degree, 0, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 15)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentCentrFrontVertical();
                rotate(-1 * degree, 0, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 16)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentCentrFrontVertical();
                rotate(1 * degree, 0, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 17)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentback();
                rotate(1 * degree, 0, 0); 
            }
         else if ((gameObject.GetComponent<Rotation>().prov1 == false && n < (90 / degree)) && gameObject.GetComponent<Rotation>().m == 18)
            {
                gameObject.GetComponent<Rotation>().prov2 = true;
                SetParentback();
                rotate(-1 * degree, 0, 0); 
            }
            else
            {
                n = 0;
                gameObject.GetComponent<Rotation>().prov1 = true;
                gameObject.GetComponent<Rotation>().prov2 = false;
                gameObject.GetComponent<Rotation>().m = 0;
                obj[7].transform.DetachChildren();
                slider.interactable = true;
                two.interactable = true;
                three.interactable = true;
            }
       }
     public void reset()
     {
         gameObject.GetComponent<Assemble>().assembprov = true;
         gameObject.GetComponent<Assemble>().n = 0;
         gameObject.GetComponent<Disassemble>().prov = true;
         gameObject.GetComponent<Disassemble>().n = 0;
         gameObject.GetComponent<Disassemble>().num = 0;
         gameObject.GetComponent<Rotation>().prov1 = true;
         n = 0;
         for (int i = 0; i <= 27; i++)
         {
             obj[i].transform.rotation = Q[i];
             obj[i].transform.position = V[i]; 
         }
         gameObject.GetComponent<CubeAssembly>().nachalo();
         gameObject.GetComponent<CubeAssembly>().obnul();
         gameObject.GetComponent<CubeAssembly>().formula = "";
         gameObject.GetComponent<CubeAssembly>().formula1 = "";
     }
}