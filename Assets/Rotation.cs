using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    public bool prov1 = true;
    public bool prov2 = false;
    public int m = 0;
    void Start()
    {
        gameObject.GetComponent<CubeAssembly>().nachalo();
    }
    public void Update()
    {
        if (prov2 == false && gameObject.GetComponent<Assemble>().assembprov == true)
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit _hit;
                if (Physics.Raycast(ray, out _hit, Mathf.Infinity))
                {
                    if (_hit.transform.tag == "Guppo")
                    {
                        gameObject.GetComponent<CubeRotation>().SetParentUp();
                        prov1 = false;
                        gameObject.GetComponent<CubeAssembly>().uppo();
                        m = 1;
                    }
                    if (_hit.transform.tag == "Gupprotiv")
                    {
                        gameObject.GetComponent<CubeRotation>().SetParentUp();
                        prov1 = false;
                        gameObject.GetComponent<CubeAssembly>().upprotiv();
                        m = 2;     
                    }
                    if (_hit.transform.tag == "Grightpo")
                    {
                        gameObject.GetComponent<CubeRotation>().SetParentRight();
                        prov1 = false;
                        gameObject.GetComponent<CubeAssembly>().rightpo();
                        m = 3;  
                    }
                  if (_hit.transform.tag == "Grightprotiv")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentRight();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().rightprotiv();
                        m = 4; 
                  }
                  if (_hit.transform.tag == "Gleftpo")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentLeft();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().leftpo();
                        m = 5; 
                  }
                  if (_hit.transform.tag == "Gleftprotiv")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentLeft();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().leftprotiv();
                        m = 6; 
                  }
                  if (_hit.transform.tag == "Gdownprotiv")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentDown();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().downprotiv();
                        m = 7; 
                  }
                  if (_hit.transform.tag == "Gdownpo")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentDown();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().downpo();
                        m = 8; 
                  }
                  if (_hit.transform.tag == "Gcentrvertrprotivleft")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentFrontVertical();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().centrvertprotiv();
                        m = 9; 
                  }
                  if (_hit.transform.tag == "Gcentrvertrpoleft")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentFrontVertical();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().centrvertpo();
                        m = 10; 
                  }
                  if (_hit.transform.tag == "Gcentrgorprotiv")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentFrontHorizontal();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().centrgorpo();
                        m = 11; 
                  }
                  if (_hit.transform.tag == "Gcentrgorpo")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentFrontHorizontal();
                      prov1 = false;
                        gameObject.GetComponent<CubeAssembly>().centrgorprotiv();
                        m = 12; 
                  }
                  if (_hit.transform.tag == "Gfrontprotiv")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentFront();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().frontprotiv();
                        m = 13; 
                  }
                  if (_hit.transform.tag == "Gfrontpo")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentFront();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().frontpo();
                        m = 14; 
                  }
                  if (_hit.transform.tag == "Gcentrvertrprotivfront")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentCentrFrontVertical();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().centrvertrprotivfront();
                        m = 15; 
                  }
                  if (_hit.transform.tag == "Gcentrvertrpofront")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentCentrFrontVertical();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().centrvertrpofront();
                        m = 16; 
                  }
                  if (_hit.transform.tag == "Gbackprotiv")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentback();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().backprotiv();
                        m = 17; 
                  }
                  if (_hit.transform.tag == "Gbackpo")
                  {
                      gameObject.GetComponent<CubeRotation>().SetParentback();
                      prov1 = false;
                      gameObject.GetComponent<CubeAssembly>().backpo();
                        m = 18;
                  }
            }

          }
   }
}
