using UnityEngine;
using System.Collections;

public class Assemble : MonoBehaviour {
    public bool assembprov = true, res = true;
    public int n = 0, num = 0, size = 0;
    public char str;
    void Update()
    {
        if (assembprov == false && gameObject.GetComponent<Disassemble>().prov == true)
        {
            gameObject.GetComponent<CubeRotation>().two.interactable = false;
            gameObject.GetComponent<CubeRotation>().three.interactable = false;
            size = gameObject.GetComponent<CubeAssembly>().formula1.Length;
            gameObject.GetComponent<Rotation>().prov2 = true;
            gameObject.GetComponent<Rotation>().prov1 = true;
            if (num == 0)
                str = gameObject.GetComponent<CubeAssembly>().formula1[num];
            if (num == size)
            {
                str = 'S';
                assembprov = true;
                num = -1;
                res = false;
            }
            if (n < 15 && str == 'A')
            {
                gameObject.GetComponent<CubeRotation>().SetParentUp();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 6, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -6, 0);
                n++;
            }
            else if (n < 15 && str == 'B')
            {
                gameObject.GetComponent<CubeRotation>().SetParentUp();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -6, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 6, 0);
                n++;
            }
            else if (n < 15 && str == 'C')
            {
                gameObject.GetComponent<CubeRotation>().SetParentRight();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 6);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -6);
                n++;
            }
            else if (n < 15 && str == 'D')
            {
                gameObject.GetComponent<CubeRotation>().SetParentRight();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -6);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 6);
                n++;
            }
            else if (n < 15 && str == 'E')
            {
                gameObject.GetComponent<CubeRotation>().SetParentLeft();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -6);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 6);
                n++;
            }
            else if (n < 15 && str == 'F')
            {
                gameObject.GetComponent<CubeRotation>().SetParentLeft();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 6);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -6);
                n++;
            }
            else if (n < 15 && str == 'G')
            {
                gameObject.GetComponent<CubeRotation>().SetParentDown();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 6, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -6, 0);
                n++;
            }
            else if (n < 15 && str == 'H')
            {
                gameObject.GetComponent<CubeRotation>().SetParentDown();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -6, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 6, 0);
                n++;
            }
            else if (n < 15 && str == 'I')
            {
                gameObject.GetComponent<CubeRotation>().SetParentFrontVertical();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 6);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -6);
                n++;
            }
            else if (n < 15 && str == 'J')
            {
                gameObject.GetComponent<CubeRotation>().SetParentFrontVertical();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, -6);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 0, 6);
                n++;
            }
            else if (n < 15 && str == 'K')
            {
                gameObject.GetComponent<CubeRotation>().SetParentFrontHorizontal();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -6, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 6, 0);
                n++;
            }
            else if (n < 15 && str == 'L')
            {
                gameObject.GetComponent<CubeRotation>().SetParentFrontHorizontal();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, 6, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(0, -6, 0);
                n++;
            }
            else if (n < 15 && str == 'M')
            {
                gameObject.GetComponent<CubeRotation>().SetParentFront();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-6, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(6, 0, 0);
                n++;
            }
            else if (n < 15 && str == 'N')
            {
                gameObject.GetComponent<CubeRotation>().SetParentFront();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(6, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-6, 0, 0);
                n++;
            }
            else if (n < 15 && str == 'O')
            {
                gameObject.GetComponent<CubeRotation>().SetParentCentrFrontVertical();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-6, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(6, 0, 0);
                n++;
            }
            else if (n < 15 && str == 'P')
            {
                gameObject.GetComponent<CubeRotation>().SetParentCentrFrontVertical();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(6, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-6, 0, 0);
                n++;
            }
            else if (n < 15 && str == 'Q')
            {
                gameObject.GetComponent<CubeRotation>().SetParentback();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(6, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-6, 0, 0);
                n++;
            }
            else if (n < 15 && str == 'R')
            {
                gameObject.GetComponent<CubeRotation>().SetParentback();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(-6, 0, 0);
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
                gameObject.GetComponent<CubeRotation>().obj[7].transform.Rotate(6, 0, 0);
                n++;
            }
            else
            {
                n = 0;
                num++;
                if (str == 'A')
                {
                    gameObject.GetComponent<CubeAssembly>().uppo();
                }
                if (str == 'B')
                {
                    gameObject.GetComponent<CubeAssembly>().upprotiv();
                }
                if (str == 'C')
                {
                    gameObject.GetComponent<CubeAssembly>().rightpo();
                }
                if (str == 'D')
                {
                    gameObject.GetComponent<CubeAssembly>().rightprotiv();
                }
                if (str == 'E')
                {
                    gameObject.GetComponent<CubeAssembly>().leftpo();
                }
                if (str == 'F')
                {
                    gameObject.GetComponent<CubeAssembly>().leftprotiv();
                }
                if (str == 'G')
                {
                    gameObject.GetComponent<CubeAssembly>().downprotiv();
                }
                if (str == 'H')
                {
                    gameObject.GetComponent<CubeAssembly>().downpo();
                }
                if (str == 'I')
                {
                    gameObject.GetComponent<CubeAssembly>().centrvertprotiv();
                }
                if (str == 'J')
                {
                    gameObject.GetComponent<CubeAssembly>().centrvertpo();
                }
                if (str == 'K')
                {
                    gameObject.GetComponent<CubeAssembly>().centrgorpo();
                }
                if (str == 'L')
                {
                    gameObject.GetComponent<CubeAssembly>().centrgorprotiv();
                }
                if (str == 'M')
                {
                    gameObject.GetComponent<CubeAssembly>().frontprotiv();
                }
                if (str == 'N')
                {
                    gameObject.GetComponent<CubeAssembly>().frontpo();
                }
                if (str == 'O')
                {
                    gameObject.GetComponent<CubeAssembly>().centrvertrprotivfront();
                }
                if (str == 'P')
                {
                    gameObject.GetComponent<CubeAssembly>().centrvertrpofront();
                }
                if (str == 'Q')
                {
                    gameObject.GetComponent<CubeAssembly>().backprotiv();
                }
                if (str == 'R')
                {
                    gameObject.GetComponent<CubeAssembly>().backpo();
                }
                str = gameObject.GetComponent<CubeAssembly>().formula1[num];
                gameObject.GetComponent<CubeRotation>().obj[7].transform.DetachChildren();
            }
        }
        else
        {
            if (res == false)
            {
                gameObject.GetComponent<CubeRotation>().reset();
                res = true;
            }
            gameObject.GetComponent<CubeRotation>().two.interactable = true;
            gameObject.GetComponent<CubeRotation>().three.interactable = true;
        }
    }
    public void assemb()
    {
        assembprov = false;
        gameObject.GetComponent<Rotation>().prov2 = true;
        gameObject.GetComponent<Rotation>().prov1 = true;
        gameObject.GetComponent<CubeRotation>().two.interactable = false;
        gameObject.GetComponent<CubeRotation>().three.interactable = false;
    }
}
