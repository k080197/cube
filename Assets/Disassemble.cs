using UnityEngine;
using System.Collections;

public class Disassemble : MonoBehaviour {
    public bool prov = true;
    public int x = 0, num = 0, n;
	void Update () {
        if (prov == false)
        {
            gameObject.GetComponent<CubeRotation>().two.enabled = false;
            gameObject.GetComponent<CubeRotation>().three.enabled = false;
            gameObject.GetComponent<Rotation>().prov1 = true;
            gameObject.GetComponent<Rotation>().prov2 = true;
            if (x == 0)
                x = Random.Range(1, 8);
            if (n < 9 && x == 1)
            {
                gameObject.GetComponent<CubeRotation>().SetParentUp();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -10, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 10, 0);
                n++;
            }
            else if (n < 9 && x == 2)
            {
                gameObject.GetComponent<CubeRotation>().SetParentRight();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -10);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 10);
                n++;
            }
            else if (n < 9 && x == 3)
            {
                gameObject.GetComponent<CubeRotation>().SetParentLeft();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 10);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -10);
                n++;
            }
            else if (n < 9 && x == 4)
            {
                gameObject.GetComponent<CubeRotation>().SetParentDown();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 10, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -10, 0);
                n++;
            }
            else if (n < 9 && x == 5)
            {
                gameObject.GetComponent<CubeRotation>().SetParentFrontVertical();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -10);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 10);
                n++;
            }
            else if (n < 9 && x == 6)
            {
                gameObject.GetComponent<CubeRotation>().SetParentFrontHorizontal();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 10, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -10, 0);
                n++;
            }
            else if (n < 9 && x == 7)
            {
                gameObject.GetComponent<CubeRotation>().SetParentFront();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-10, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(10, 0, 0);
                n++;
            }
            else if (n < 9 && x == 8)
            {
                gameObject.GetComponent<CubeRotation>().SetParentback();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(10, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-10, 0, 0);
                n++;
            }
            else
            {
                n = 0;
                num++;
                if (x == 1)
                {
                    gameObject.GetComponent<CubeAssembly>().upprotiv();
                }
                if (x == 2)
                {
                    gameObject.GetComponent<CubeAssembly>().rightprotiv();
                }
                if (x == 3)
                {
                    gameObject.GetComponent<CubeAssembly>().leftprotiv();
                }
                if (x == 4)
                {
                    gameObject.GetComponent<CubeAssembly>().downprotiv();
                }
                if (x == 5)
                {
                    gameObject.GetComponent<CubeAssembly>().centrvertpo();
                }
                if (x == 6)
                {
                    gameObject.GetComponent<CubeAssembly>().centrgorprotiv();
                }
                if (x == 7)
                {
                    gameObject.GetComponent<CubeAssembly>().frontprotiv();
                }
                if (x == 8)
                {
                    gameObject.GetComponent<CubeAssembly>().backprotiv();
                }
                x = 0;
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                if (num == 10)
                {
                    prov = true;
                    num = 0;
                }
            }
        }
        else
        {
            gameObject.GetComponent<CubeRotation>().two.enabled = true;
            gameObject.GetComponent<CubeRotation>().three.enabled = true;
        }
	}
    public void disassemb()
    {
        prov = false;
        gameObject.GetComponent<CubeRotation>().two.enabled = false;
        gameObject.GetComponent<CubeRotation>().three.enabled = false;
    }
}
