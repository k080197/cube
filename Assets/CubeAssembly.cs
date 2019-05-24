using UnityEngine;
using System.Collections;
using System;
using System.Threading;

public class CubeAssembly : MonoBehaviour
{
    public int[] rubik = new int[55];
    public int[] buf = new int[55];
    public int[] rubiktmp = new int[22];
    public bool auto = true;
    public int s = 0, assemb = 0;
    public int s1 = 0, s1_1 = 0, s2 = 0, s3 = 0, s2_2 = 0,s3_3=0,s7_7=0,s7=0,s6=0,s6_6=0,s5_5=0;
    public string formula, formula1;
    public void nachalo()
    {
        for (int i = 1; i <= 9; i++)
            rubik[i] = 2;
        for (int i = 10; i <= 18; i++)
            rubik[i] = 1;
        for (int i = 19; i <= 27; i++)
            rubik[i] = 5;
        for (int i = 28; i <= 36; i++)
            rubik[i] = 6;
        for (int i = 37; i <= 45; i++)
            rubik[i] = 3;
        for (int i = 46; i <= 54; i++)
            rubik[i] = 4;
    }
    public void obnul()
    {
        s = 0; 
        assemb = 0;
        s1 = 0; 
        s1_1 = 0; 
        s2 = 0; 
        s3 = 0; 
        s2_2 = 0;
        s3_3 = 0;
        s7_7 = 0;
        s7 = 0;
        s6 = 0;
        s6_6 = 0;
        s5_5 = 0;
    }
    void analiz1()
    {
        s1 = 0;

        if ((rubik[14] == rubik[11]) && (rubik[23] == rubik[8]))
        {
            frontpo();
            frontpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[50] == rubik[47]) && (rubik[23] == rubik[6]))
        {
            rightpo();
            rightpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[41] == rubik[38]) && (rubik[23] == rubik[4]))
        {
            leftpo();
            leftpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[32] == rubik[35]) && (rubik[23] == rubik[2]))
        {
            backpo();
            backpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[14] == rubik[8]) && (rubik[23] == rubik[11]))
        {
            upprotiv();
            rightprotiv();
            frontpo();
            rightpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[50] == rubik[6]) && (rubik[23] == rubik[47]))
        {
            upprotiv();
            backprotiv();
            rightpo();
            backpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[4] == rubik[41]) && (rubik[38] == rubik[23]))
        {
            upprotiv();
            frontprotiv();
            leftpo();
            frontpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[2] == rubik[32]) && (rubik[23] == rubik[35]))
        {
            upprotiv();
            leftprotiv();
            backpo();
            leftpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[15])
        {
            frontprotiv();
            upprotiv();
            frontpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[51])
        {
            rightprotiv();
            upprotiv();
            rightpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[42])
        {
            leftprotiv();
            upprotiv();
            leftpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[31])
        {
            backprotiv();
            upprotiv();
            backpo();
            s1_1 = 0;
            s1 = 1;
        }
        else if (rubik[23] == rubik[13])
        {
            frontpo();
            upprotiv();
            frontprotiv();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[49])
        {
            rightpo();
            upprotiv();
            rightprotiv();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[40])
        {
            leftpo();
            upprotiv();
            leftprotiv();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[33])
        {
            backpo();
            upprotiv();
            backprotiv();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[17])
        {
            frontpo();
            frontpo();
            upprotiv();
            frontpo();
            frontpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[53])
        {
            rightpo();
            rightpo();
            upprotiv();
            rightpo();
            rightpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[44])
        {
            leftpo();
            leftpo();
            upprotiv();
            leftpo();
            leftpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (rubik[23] == rubik[29])
        {
            backpo();
            backpo();
            upprotiv();
            backpo();
            backpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[23] == rubik[20]) && (rubik[14] != rubik[17]))
        {
            frontpo();
            frontpo();
            upprotiv();
            frontpo();
            frontpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[23] == rubik[24]) && (rubik[50] != rubik[53]))
        {
            rightpo();
            rightpo();
            upprotiv();
            rightpo();
            rightpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[23] == rubik[22]) && (rubik[41] != rubik[44]))
        {
            leftpo();
            leftpo();
            upprotiv();
            leftpo();
            leftpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if ((rubik[23] == rubik[26]) && (rubik[32] != rubik[29]))
        {
            backpo();
            backpo();
            upprotiv();
            backpo();
            backpo();
            s1 = 1;
            s1_1 = 0;
        }
        else if (s1 == 0)
        {
            uppo();
            s1_1 += 1;
        }
    }
    void analiz2()
    {
        s2 = 0;

        if ((rubik[12] == rubik[23]) && (rubik[9] == rubik[14])&&(rubik[46]==rubik[50])&&(rubik[17] == rubik[14]) && (rubik[50] == rubik[53]))
        {
            frontprotiv();
            upprotiv();
            frontpo();
            s2 = 1;
            s2_2 = 0;
        }
        else if ((rubik[10] == rubik[14]) && (rubik[39] == rubik[23])&&(rubik[7]==rubik[41])&&(rubik[14] == rubik[17]) && (rubik[41] == rubik[44]))
        {
            leftprotiv();
            upprotiv();
            leftpo();
            s2 = 1;
            s2_2 = 0;
        }
        else if ((rubik[36] == rubik[32]) && (rubik[3] == rubik[50])&&(rubik[48]==rubik[23])&&(rubik[29] == rubik[32]) && (rubik[50] == rubik[53]))
        {
            rightprotiv();
            upprotiv();
            rightpo();
            s2 = 1;
            s2_2 = 0;
        }
        else if ((rubik[34] == rubik[23]) && (rubik[1] == rubik[32])&&(rubik[37]==rubik[41])&&(rubik[41] == rubik[44]) && (rubik[29] == rubik[32]))
        {
            backprotiv();
            upprotiv();
            backpo();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[12] == rubik[14]) && (rubik[17] == rubik[14])&&(rubik[46]==rubik[23])&&(rubik[50] == rubik[53]) && (rubik[9] == rubik[50]))
        {
            rightpo();
           uppo();
           rightprotiv();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[14] == rubik[17]) && (rubik[10] == rubik[23])&&(rubik[39]==rubik[41])&&(rubik[44] == rubik[41]) && (rubik[7] == rubik[14]))
        {
            frontpo();
           uppo();
           frontprotiv();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[29] == rubik[32]) && (rubik[50] == rubik[53])&&(rubik[48]==rubik[50])&&(rubik[32] == rubik[3]) && (rubik[23] == rubik[36]))
        {
            backpo();
           uppo();
           backprotiv();
            s2 = 1;
            s2_2 = 0;
        }
        else if ((rubik[32] == rubik[29]) && (rubik[41] == rubik[44])&&(rubik[37]==rubik[23])&&(rubik[32] == rubik[34]) && (rubik[41] == rubik[1]))
        {
            leftpo();
            uppo();
            leftprotiv();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[14] == rubik[17]) && (rubik[12] == rubik[50])&&(rubik[46]==rubik[14])&&(rubik[50] == rubik[53]) && (rubik[9] == rubik[23]))
        {
            rightpo();
           upprotiv();
           rightprotiv();
           uppo();
           uppo();
           rightpo();
           uppo();
           rightprotiv();
            s2 = 1;
            s2_2 = 0;
        }
        else if ((rubik[14] == rubik[17]) && (rubik[41] == rubik[44])&&(rubik[10]==rubik[41])&&(rubik[39] == rubik[14]) && (rubik[7] == rubik[23]))
        {
            frontpo();
            upprotiv();
            frontprotiv();
            uppo();
            uppo();
            frontpo();
            uppo();
            frontprotiv();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[32] == rubik[29]) && (rubik[36] == rubik[50])&&(rubik[50]==rubik[53])&&(rubik[48] == rubik[32]) && (rubik[3] == rubik[23]))
        {
            backpo();
           upprotiv();
           backprotiv();
           uppo();
           uppo();
           backpo();
           uppo();
           backprotiv();
            s2 = 1;
            s2_2 = 0;
        }
        else if ((rubik[32] == rubik[29]) && (rubik[34] == rubik[41])&&(rubik[37]==rubik[32])&&(rubik[1] == rubik[23]) && (rubik[41] == rubik[44]))
        {
            leftpo();
            upprotiv();
            leftprotiv();
            uppo();
            uppo();
            leftpo();
            uppo();
            leftprotiv();
            s2 = 1;
            s2_2 = 0;
        }
        else  if ((rubik[14] == rubik[17]) && (rubik[18] == rubik[23])&& (rubik[50] == rubik[53]))
        {
            frontprotiv();
            upprotiv();
            frontpo();
            s2 = 1;
            s2_2 = 0;
        }
       else   if ((rubik[14] == rubik[17]) && (rubik[41] == rubik[44])&& (rubik[45] == rubik[23]))
        {
            leftprotiv();
           upprotiv();
           leftpo();
            s2 = 1;
            s2_2 = 0;
        }
       else   if ((rubik[29] == rubik[32]) && (rubik[50] == rubik[53])&& (rubik[54] == rubik[23]))
        {
            rightprotiv();
           upprotiv();
           rightpo();
            s2 = 1;
            s2_2 = 0;
        }
        else  if ((rubik[29] == rubik[32]) && (rubik[28] == rubik[23])&& (rubik[41] == rubik[44]))
        {
            backprotiv();
            upprotiv();
            backpo();
            s2 = 1;
            s2_2 = 0;
        }
       else   if ((rubik[14] == rubik[17]) && (rubik[50] == rubik[53])&& (rubik[52] == rubik[23]))
        {
            frontprotiv();
           upprotiv();
           frontpo();
            s2 = 1;
            s2_2 = 0;
        }
        else  if ((rubik[14] == rubik[17]) && (rubik[41] == rubik[44])&& (rubik[16] == rubik[23]))
        {
            leftprotiv();
            upprotiv();
            leftpo();
            s2 = 1;
            s2_2 = 0;
        }
       else   if ((rubik[29] == rubik[32]) && (rubik[30] == rubik[23])&& (rubik[50] == rubik[53]))
        {
            rightprotiv();
           upprotiv();
           rightpo();
            s2 = 1;
            s2_2 = 0;
        }
       else   if ((rubik[29] == rubik[32]) && (rubik[41] == rubik[44])&& (rubik[43] == rubik[23]))
        {
            backprotiv();
           upprotiv();
           backpo();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[41] == rubik[44]) && (rubik[14] == rubik[17])&& (rubik[23] == rubik[22])&& (rubik[23] == rubik[20])&& (rubik[23] == rubik[24])&& (rubik[23] == rubik[26])&& (rubik[23] == rubik[19])&& ((rubik[45]!=rubik[41])||(rubik[16]!=rubik[14])))
        {
            frontpo();
           upprotiv();
           frontprotiv();
            s2 = 1;
            s2_2 = 0;
        }
       else  if ((rubik[14] == rubik[17]) && (rubik[50] == rubik[53])&& (rubik[23] == rubik[20])&& (rubik[23] == rubik[21])&& (rubik[23] == rubik[24])&& (rubik[23] == rubik[26])&& (rubik[23] == rubik[22])&& ((rubik[18]!=rubik[14])||(rubik[52]!=rubik[50])))
        {
            rightpo();
           upprotiv();
           rightprotiv();
            s2 = 1;
            s2_2 = 0;
        }
      else   if ((rubik[29] == rubik[32]) && (rubik[50] == rubik[53])&& (rubik[27] == rubik[23])&& (rubik[26] == rubik[23])&& (rubik[24] == rubik[23])&& (rubik[20] == rubik[23])&& (rubik[22] == rubik[23])&& ((rubik[54]!=rubik[50])||(rubik[32]!=rubik[30])))
        {
            backpo();
          upprotiv();
          backprotiv();
            s2 = 1;
            s2_2 = 0;
        }
      else   if ((rubik[29] == rubik[32]) && (rubik[41] == rubik[44])&& (rubik[25] == rubik[23])&& (rubik[26] == rubik[23])&& (rubik[22] == rubik[23])&& (rubik[20] == rubik[23])&& (rubik[24] == rubik[23])&& ((rubik[28]!=rubik[32])||(rubik[43]!=rubik[41])))
        {
            leftpo();
          upprotiv();
          leftprotiv();
            s2 = 1;
            s2_2 = 0;
        }
       else  if (s2 == 0)
        {
            uppo();
            s2_2 += 1;
        }
    } 
    void analiz3()
    {
        s3=0;
        if ((rubik[14]==rubik[11]) && (rubik[8]==rubik[41]))
        {
            upprotiv();
            leftprotiv();
            uppo();
            leftpo();
            uppo();
            frontpo();
            upprotiv();
            frontprotiv();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[50] == rubik[47]) && (rubik[6] == rubik[14]))
        {
            upprotiv();
            frontprotiv();
            uppo();
            frontpo();
            uppo();
            rightpo();
            upprotiv();
            rightprotiv();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[32] == rubik[35]) && (rubik[2] == rubik[50]))
        {
            upprotiv();
            rightprotiv();
            uppo();
            rightpo();
            uppo();
            backpo();
            upprotiv();
            backprotiv();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[4] == rubik[32]) && (rubik[38] == rubik[41]))
        {
            upprotiv();
            backprotiv();
            uppo();
            backpo();
            uppo();
            leftpo();
            upprotiv();
            leftprotiv();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[11] == rubik[14]) && (rubik[8] == rubik[50]))
        {
            uppo();
            rightpo();
            upprotiv();
            rightprotiv();
            upprotiv();
            frontprotiv();
            uppo();
            frontpo();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[38] == rubik[41]) && (rubik[4] == rubik[14]))
        {
            uppo();
            frontpo();
            upprotiv();
            frontprotiv();
            upprotiv();
            leftprotiv();
            uppo();
            leftpo();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[35] == rubik[32]) && (rubik[2] == rubik[41]))
        {
            uppo();
            leftpo();
            upprotiv();
            leftprotiv();
            upprotiv();
            backprotiv();
            uppo();
            backpo();
            s3 =1;
            s3_3=0;
        }
        else if ((rubik[47] == rubik[50]) && (rubik[6] == rubik[32]))
        {
            uppo();
            backpo();
            upprotiv();
            backprotiv();
            upprotiv();
            rightprotiv();
            uppo();
            rightpo();
            s3 =1;
            s3_3=0;
        }
         if (s3_3==4)
         if ((rubik[15]!=rubik[14]) || (rubik[49]!=rubik[50]))
        {
            uppo();
            rightpo();
            upprotiv();
            rightprotiv();
            upprotiv();
            frontprotiv();
            uppo();
            frontpo();
        }
        else if ((rubik[13]!=rubik[14]) || (rubik[42]!=rubik[41]))
        {
            uppo();
            frontpo();
            upprotiv();
            frontprotiv();
            upprotiv();
            leftprotiv();
            uppo();
            leftpo();
        }
        else if ((rubik[40] != rubik[41]) || (rubik[31] != rubik[32]))
        {
            uppo();
            leftpo();
            upprotiv();
            leftprotiv();
            upprotiv();
            backprotiv();
            uppo();
            backpo();
        }
        else if ((rubik[33] != rubik[32]) || (rubik[51] != rubik[50]))
        {
            uppo();
            backpo();
            upprotiv();
            backprotiv();
            upprotiv();
            rightprotiv();
            uppo();
            rightpo();
        }
        if (s3 == 0)
        {
            uppo();
            s3_3 += 1;
        }
    }
    void analiz4()
    {
        if ((rubik[4]==rubik[5]) && (rubik[2]==rubik[5]) && (rubik[11]==rubik[5]) && (rubik[47]==rubik[5]))
        {
            frontpo();
            uppo();
            rightpo();
            upprotiv();
            rightprotiv();
            frontprotiv();
        }
        if ((rubik[6]==rubik[5]) && (rubik[2]==rubik[5]) && (rubik[11]==rubik[5]) && (rubik[38]==rubik[5]))
        {
            leftpo();
            uppo();
            frontpo();
            upprotiv();
            frontprotiv();
            leftprotiv();
        }
        if ((rubik[4]==rubik[5]) && (rubik[8]==rubik[5]) && (rubik[47]==rubik[5]) && (rubik[35]==rubik[5]))
        {
            rightpo();
            uppo();
            backpo();
            upprotiv();
            backprotiv();
            rightprotiv();
        }
        if ((rubik[8]==rubik[5]) && (rubik[6]==rubik[5]) && (rubik[38]==rubik[5]) && (rubik[35]==rubik[5]))
        {
            backpo();
            uppo();
            leftpo();
            upprotiv();
            leftprotiv();
            backprotiv();
        }
        if ((rubik[4]==rubik[5]) && (rubik[6]==rubik[5]) && (rubik[11]==rubik[5]) && (rubik[35]==rubik[5]))
        {
            frontpo();
            rightpo();
            uppo();
            rightprotiv();
            upprotiv();
            frontprotiv();
        }
        if ((rubik[2]==rubik[5]) && (rubik[8]==rubik[5]) && (rubik[47]==rubik[5]) && (rubik[38]==rubik[5]))
        {
            rightpo();
            backpo();
            uppo();
            backprotiv();
            upprotiv();
            rightprotiv();
        }
        if ((rubik[11]==rubik[47]) && (rubik[47]==rubik[35]) && (rubik[35]==rubik[38]) && (rubik[38]==rubik[11]))
        {
            frontpo();
            uppo();
            rightpo();
            upprotiv();
            rightprotiv();
            frontprotiv();
            rightpo();
            backpo();
            uppo();
            backprotiv();
            upprotiv();
            rightprotiv();
        }
    }
    void analiz5()
    {
        if (rubik[47]==rubik[14] && (rubik[2] == rubik[5] && rubik[4] == rubik[5] && rubik[6] == rubik[5] &&rubik[8] == rubik[5]))
        {
            uppo();
            leftprotiv();
            uppo();
            uppo();
            leftpo();
            uppo();
            leftprotiv();
            uppo();
            leftpo();
        }
        if (rubik[38] == rubik[14] && (rubik[2] == rubik[5] && rubik[4] == rubik[5] && rubik[6] == rubik[5] && rubik[8] == rubik[5]))
        {
            uppo();
            backprotiv();
            uppo();
            uppo();
            backpo();
            uppo();
            backprotiv();
            uppo();
            backpo();
        }
        if (rubik[35] == rubik[14] && (rubik[2] == rubik[5] && rubik[4] == rubik[5] && rubik[6] == rubik[5] && rubik[8] == rubik[5]))
        {
            uppo();
            rightprotiv();
            uppo();
            uppo();
            rightpo();
            uppo();
            rightprotiv();
            uppo();
            rightpo();
            uppo();
            backprotiv();
            uppo();
            uppo();
            backpo();
            uppo();
            backprotiv();
            uppo();
            backpo();
            uppo();
            rightprotiv();
            uppo();
            uppo();
            rightpo();
            uppo();
            rightprotiv();
            uppo();
            rightpo();
        }
        if (rubik[50] == rubik[35] && (rubik[2] == rubik[5] && rubik[4] == rubik[5] && rubik[6] == rubik[5] && rubik[8] == rubik[5]))
        {
            uppo();
            frontprotiv();
            uppo();
            uppo();
            frontpo();
            uppo();
            frontprotiv();
            uppo();
            frontpo();
        }
        if (rubik[50] == rubik[38] && (rubik[2] == rubik[5] && rubik[4] == rubik[5] && rubik[6] == rubik[5] && rubik[8] == rubik[5]))
        {
            uppo();
            backprotiv();
            uppo();
            uppo();
            backpo();
            uppo();
            backprotiv();
            uppo();
            backpo();
            uppo();
            leftprotiv();
            uppo();
            uppo();
            leftpo();
            uppo();
            leftprotiv();
            uppo();
            leftpo();
            uppo();
            backprotiv();
            uppo();
            uppo();
            backpo();
            uppo();
            backprotiv();
            uppo();
            backpo();
        }
        if (rubik[32] == rubik[38] && (rubik[2] == rubik[5] && rubik[4] == rubik[5] && rubik[6] == rubik[5] && rubik[8] == rubik[5]))
        {
            uppo();
            rightprotiv();
            uppo();
            uppo();
            rightpo();
            uppo();
            rightprotiv();
            uppo();
            rightpo();
        }
    }
    void analiz5_5()
    {
        if ((rubik[9] == rubik[5] || rubik[12] == rubik[5] || rubik[46] == rubik[5]) &&
             (rubik[9] == rubik[14] || rubik[12] == rubik[14] || rubik[46] == rubik[14]) &&
             (rubik[9] == rubik[50] || rubik[12] == rubik[50] || rubik[46] == rubik[50]))
        {
            
                uppo();
                centrgorprotiv();
                downprotiv();
                uppo();
                centrgorprotiv();
                downprotiv();
        }

        if ((rubik[39] == rubik[2]) || (rubik[39] == rubik[3]) || (rubik[39] == rubik[6]) &&
            (rubik[10] == rubik[2]) || (rubik[10] == rubik[3]) || (rubik[10] == rubik[6]) &&
            (rubik[7] == rubik[2]) || (rubik[7] == rubik[3]) || (rubik[7] == rubik[6]))
        {
            
            
                uppo();
                centrgorprotiv();
                downprotiv();
        }
        if ((rubik[48] == rubik[2]) || (rubik[48] == rubik[3]) || (rubik[48] == rubik[6]) &&
           (rubik[36] == rubik[2]) || (rubik[36] == rubik[3]) || (rubik[36] == rubik[6]) &&
           (rubik[3] == rubik[2]) || (rubik[3] == rubik[3]) || (rubik[3] == rubik[6]))
        {
            
                upprotiv();
                centrgorpo();
                downpo();
            }
        

        if ((rubik[37] == rubik[41] || rubik[37] == rubik[32] || rubik[37] == rubik[5]) &&
             (rubik[1] == rubik[41] || rubik[1] == rubik[32] || rubik[1] == rubik[5]) &&
             (rubik[34] == rubik[41] || rubik[34] == rubik[32] || rubik[34] == rubik[5]) )
        {
            
                do
                {
                    rightprotiv();
                    uppo();
                    leftpo();
                    upprotiv();
                    rightpo();
                    uppo();
                    leftprotiv();
                    upprotiv();
                    s5_5 = 1;
                }
                while (!(((rubik[37] == rubik[41] || rubik[37] == rubik[32] || rubik[37] == rubik[5]) &&
                        (rubik[1] == rubik[41] || rubik[1] == rubik[32] || rubik[1] == rubik[5]) &&
                        (rubik[34] == rubik[41] || rubik[34] == rubik[32] || rubik[34] == rubik[5])) &&

                       ((rubik[39] == rubik[41] || rubik[39] == rubik[14] || rubik[39] == rubik[5]) &&
                        (rubik[10] == rubik[41] || rubik[10] == rubik[14] || rubik[10] == rubik[5]) &&
                        (rubik[7] == rubik[41] || rubik[7] == rubik[14] || rubik[7] == rubik[5])) &&

                       ((rubik[46] == rubik[50] || rubik[46] == rubik[5] || rubik[46] == rubik[14]) &&
                        (rubik[12] == rubik[50] || rubik[12] == rubik[5] || rubik[12] == rubik[14]) &&
                        (rubik[9] == rubik[50] || rubik[9] == rubik[5] || rubik[9] == rubik[14])) &&

                       ((rubik[3] == rubik[50] || rubik[3] == rubik[5] || rubik[3] == rubik[32]) &&
                        (rubik[48] == rubik[50] || rubik[48] == rubik[5] || rubik[48] == rubik[32]) &&
                        (rubik[36] == rubik[50] || rubik[36] == rubik[5] || rubik[36] == rubik[32]))));
        }
        else
        { if (s5_5!=1)
            {
          
                rightprotiv();
                uppo();
                leftpo();
                upprotiv();
                rightpo();
                uppo();
                leftprotiv();
                upprotiv();
            }
        }

    }
    void analiz6()
    {
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
        }

        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                analiz5_5();
            }
            if (s5_5 == 0)
            {
                uppo();
                centrgorprotiv();
                downprotiv();
            }
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (s5_5 == 0)
        {
            analiz5_5();
        }
        if (((rubik[37] == rubik[41] || rubik[37] == rubik[32] || rubik[37] == rubik[5]) &&
                   (rubik[1] == rubik[41] || rubik[1] == rubik[32] || rubik[1] == rubik[5]) &&
                   (rubik[34] == rubik[41] || rubik[34] == rubik[32] || rubik[34] == rubik[5])) &&

                  ((rubik[39] == rubik[41] || rubik[39] == rubik[14] || rubik[39] == rubik[5]) &&
                   (rubik[10] == rubik[41] || rubik[10] == rubik[14] || rubik[10] == rubik[5]) &&
                   (rubik[7] == rubik[41] || rubik[7] == rubik[14] || rubik[7] == rubik[5])) &&

                  ((rubik[46] == rubik[50] || rubik[46] == rubik[5] || rubik[46] == rubik[14]) &&
                   (rubik[12] == rubik[50] || rubik[12] == rubik[5] || rubik[12] == rubik[14]) &&
                   (rubik[9] == rubik[50] || rubik[9] == rubik[5] || rubik[9] == rubik[14])) &&

                  ((rubik[3] == rubik[50] || rubik[3] == rubik[5] || rubik[3] == rubik[32]) &&
                   (rubik[48] == rubik[50] || rubik[48] == rubik[5] || rubik[48] == rubik[32]) &&
                   (rubik[36] == rubik[50] || rubik[36] == rubik[5] || rubik[36] == rubik[32])))
        {
            s += 1;
        }
    }
    void analiz7()
    {
        s7=0;
        if (rubik[46]==rubik[5])
        {
            s7=1;
            s7_7=0;
            frontprotiv();
            rightpo();
            frontpo();
            rightprotiv();
            frontprotiv();
            rightpo();
            frontpo();
            rightprotiv();
        }
        else  if (rubik[12]==rubik[5])
        {

            s7=1;
            s7_7=0;
            rightpo();
            frontprotiv();
            rightprotiv();
            frontpo();
            rightpo();
            frontprotiv();
            rightprotiv();
            frontpo();
        }
        else  if (s7 == 0)
        {
            uppo();
            s7_7 += 1;
        }
    }
    public void analiz()
    {
        formula = "";
        formula1 = "";
        for (int i = 0; i < 54; i++)
            buf[i] = rubik[i];
        auto = false;
        s = 0;
        if (s == 0)
        {
            while (s1_1 != 8)
            {
                analiz1();
            }
            s = 1;
        }
        if (s == 1)
        {
            while (s2_2 != 8)
            {
                analiz2();
            }
            s = 2;
        }
        if (s == 2)
        {
            while (s3_3 != 14)
            {
                analiz3();
            }
            s = 3;
        }
        if (s == 3)
        {
            analiz4();
            s = 4;
        }
        if (s == 4)
        {
            analiz5();
            s = 5;
        }
        if (s == 5)
        {
            analiz6();
        }
        if (s == 6)
        {
            while (s7_7 != 8)
            {
                analiz7();
                s = 7;
            }
            
        }
        if (s == 7)
        {
            do
            {
                uppo();
            } while ((rubik[11] != rubik[14]) && (rubik[38] != rubik[41]) && (rubik[47] != rubik[50]) && (rubik[35] != rubik[32])) ;
         }
         for (int i = 0; i < 54; i++)
             rubik[i] = buf[i];
        s = 0;
        auto = true;
        obnul();
    }
    void proverka(int[] rubik)
    {
        if (((rubik[1] == rubik[2]) && (rubik[2] == rubik[3]) && (rubik[3] == rubik[4]) && (rubik[4] == rubik[5]) && (rubik[5] == rubik[6]) && (rubik[6] == rubik[7]) && (rubik[7] == rubik[8]) && (rubik[8] == rubik[9])) &&
           ((rubik[10] == rubik[11]) && (rubik[11] == rubik[12]) && (rubik[12] == rubik[13]) && (rubik[13] == rubik[14]) && (rubik[14] == rubik[15]) && (rubik[15] == rubik[16]) && (rubik[16] == rubik[17]) && (rubik[17] == rubik[18])) &&
           ((rubik[19] == rubik[20]) && (rubik[20] == rubik[21]) && (rubik[21] == rubik[22]) && (rubik[22] == rubik[23]) && (rubik[23] == rubik[24]) && (rubik[24] == rubik[25]) && (rubik[25] == rubik[26]) && (rubik[26] == rubik[27])) &&
           ((rubik[28] == rubik[29]) && (rubik[29] == rubik[30]) && (rubik[30] == rubik[31]) && (rubik[31] == rubik[32]) && (rubik[32] == rubik[33]) && (rubik[33] == rubik[34]) && (rubik[34] == rubik[35]) && (rubik[35] == rubik[36])) &&
           ((rubik[37] == rubik[38]) && (rubik[38] == rubik[39]) && (rubik[39] == rubik[40]) && (rubik[40] == rubik[41]) && (rubik[41] == rubik[42]) && (rubik[42] == rubik[43]) && (rubik[43] == rubik[44]) && (rubik[44] == rubik[45])) &&
           (((rubik[46] == rubik[47]) && (rubik[47] == rubik[48]) && (rubik[48] == rubik[49]) && (rubik[49] == rubik[50]) && (rubik[50] == rubik[51]) && (rubik[51] == rubik[52]) && (rubik[52] == rubik[53]) && (rubik[53] == rubik[54]))))
        {
            assemb = 1;          
        }
        else
        {
            assemb = 0;       
        }
    }
    void fronttmp()
    {
        rubiktmp[1] = rubik[10];
        rubiktmp[2] = rubik[11];
        rubiktmp[3] = rubik[12];
        rubiktmp[4] = rubik[13];
        rubiktmp[5] = rubik[14];
        rubiktmp[6] = rubik[15];
        rubiktmp[7] = rubik[16];
        rubiktmp[8] = rubik[17];
        rubiktmp[9] = rubik[18];
        rubiktmp[10] = rubik[7];
        rubiktmp[11] = rubik[8];
        rubiktmp[12] = rubik[9];
        rubiktmp[13] = rubik[45];
        rubiktmp[14] = rubik[42];
        rubiktmp[15] = rubik[39];
        rubiktmp[16] = rubik[46];
        rubiktmp[17] = rubik[49];
        rubiktmp[18] = rubik[52];
        rubiktmp[19] = rubik[19];
        rubiktmp[20] = rubik[20];
        rubiktmp[21] = rubik[21];
    }
    public void frontpo()
    {
        fronttmp();
        rubik[10] = rubiktmp[7];
        rubik[11] = rubiktmp[4];
        rubik[12] = rubiktmp[1];
        rubik[13] = rubiktmp[8];
        rubik[14] = rubiktmp[5];
        rubik[15] = rubiktmp[2];
        rubik[16] = rubiktmp[9];
        rubik[17] = rubiktmp[6];
        rubik[18] = rubiktmp[3];
        rubik[7] = rubiktmp[13];
        rubik[8] = rubiktmp[14];
        rubik[9] = rubiktmp[15];
        rubik[45] = rubiktmp[21];
        rubik[42] = rubiktmp[20];
        rubik[39] = rubiktmp[19];
        rubik[46] = rubiktmp[10];
        rubik[49] = rubiktmp[11];
        rubik[52] = rubiktmp[12];
        rubik[19] = rubiktmp[18];
        rubik[20] = rubiktmp[17];
        rubik[21] = rubiktmp[16];
        
        if (!auto)
        {
            formula += "F ";
            formula1 += "N";
        }
    }
    public void frontprotiv()
    {
        fronttmp();
        rubik[10] = rubiktmp[3];
        rubik[11] = rubiktmp[6];
        rubik[12] = rubiktmp[9];
        rubik[13] = rubiktmp[2];
        rubik[14] = rubiktmp[5];
        rubik[15] = rubiktmp[8];
        rubik[16] = rubiktmp[1];
        rubik[17] = rubiktmp[4];
        rubik[18] = rubiktmp[7];
        rubik[7] = rubiktmp[16];
        rubik[8] = rubiktmp[17];
        rubik[9] = rubiktmp[18];
        rubik[45] = rubiktmp[10];
        rubik[42] = rubiktmp[11];
        rubik[39] = rubiktmp[12];
        rubik[46] = rubiktmp[21];
        rubik[49] = rubiktmp[20];
        rubik[52] = rubiktmp[19];
        rubik[19] = rubiktmp[15];
        rubik[20] = rubiktmp[14];
        rubik[21] = rubiktmp[13];
        if (!auto)
        {
            formula += "F' ";
            formula1 += "M";
        }
    }
    void lefttmp()
    {
        rubiktmp[1] = rubik[37];
        rubiktmp[2] = rubik[38];
        rubiktmp[3] = rubik[39];
        rubiktmp[4] = rubik[40];
        rubiktmp[5] = rubik[41];
        rubiktmp[6] = rubik[42];
        rubiktmp[7] = rubik[43];
        rubiktmp[8] = rubik[44];
        rubiktmp[9] = rubik[45];
        rubiktmp[10] = rubik[1];
        rubiktmp[11] = rubik[4];
        rubiktmp[12] = rubik[7];
        rubiktmp[13] = rubik[10];
        rubiktmp[14] = rubik[13];
        rubiktmp[15] = rubik[16];
        rubiktmp[16] = rubik[19];
        rubiktmp[17] = rubik[22];
        rubiktmp[18] = rubik[25];
        rubiktmp[19] = rubik[28];
        rubiktmp[20] = rubik[31];
        rubiktmp[21] = rubik[34];
    }
    public void leftpo()
    {
        lefttmp();
        rubik[37] = rubiktmp[7];
        rubik[38] = rubiktmp[4];
        rubik[39] = rubiktmp[1];
        rubik[40] = rubiktmp[8];
        rubik[41] = rubiktmp[5];
        rubik[42] = rubiktmp[2];
        rubik[43] = rubiktmp[9];
        rubik[44] = rubiktmp[6];
        rubik[45] = rubiktmp[3];
        rubik[19] = rubiktmp[13];
        rubik[22] = rubiktmp[14];
        rubik[25] = rubiktmp[15];
        rubik[7] = rubiktmp[21];
        rubik[4] = rubiktmp[20];
        rubik[1] = rubiktmp[19];
        rubik[10] = rubiktmp[10];
        rubik[13] = rubiktmp[11];
        rubik[16] = rubiktmp[12];
        rubik[34] = rubiktmp[18];
        rubik[31] = rubiktmp[17];
        rubik[28] = rubiktmp[16];
        if (!auto)
        {
            formula += "L ";
            formula1 += "E";
        }
    }
    public void leftprotiv()
    {
        lefttmp();
        rubik[37] = rubiktmp[3];
        rubik[38] = rubiktmp[6];
        rubik[39] = rubiktmp[9];
        rubik[40] = rubiktmp[2];
        rubik[41] = rubiktmp[5];
        rubik[42] = rubiktmp[8];
        rubik[43] = rubiktmp[1];
        rubik[44] = rubiktmp[4];
        rubik[45] = rubiktmp[7];
        rubik[25] = rubiktmp[21];
        rubik[22] = rubiktmp[20];
        rubik[19] = rubiktmp[19];
        rubik[1] = rubiktmp[13];
        rubik[4] = rubiktmp[14];
        rubik[7] = rubiktmp[15];
        rubik[34] = rubiktmp[12];
        rubik[31] = rubiktmp[11];
        rubik[28] = rubiktmp[10];
        rubik[16] = rubiktmp[18];
        rubik[13] = rubiktmp[17];
        rubik[10] = rubiktmp[16];
        if (!auto)
        {
            formula += "L' ";
            formula1 += "F";
        }
    }
    void righttmp()
    {
        rubiktmp[1] = rubik[46];
        rubiktmp[2] = rubik[47];
        rubiktmp[3] = rubik[48];
        rubiktmp[4] = rubik[49];
        rubiktmp[5] = rubik[50];
        rubiktmp[6] = rubik[51];
        rubiktmp[7] = rubik[52];
        rubiktmp[8] = rubik[53];
        rubiktmp[9] = rubik[54];
        rubiktmp[10] = rubik[9];
        rubiktmp[11] = rubik[6];
        rubiktmp[12] = rubik[3];
        rubiktmp[13] = rubik[36];
        rubiktmp[14] = rubik[33];
        rubiktmp[15] = rubik[30];
        rubiktmp[16] = rubik[27];
        rubiktmp[17] = rubik[24];
        rubiktmp[18] = rubik[21];
        rubiktmp[19] = rubik[18];
        rubiktmp[20] = rubik[15];
        rubiktmp[21] = rubik[12];
    }
    public void rightpo()
    {
        righttmp();
        rubik[46] = rubiktmp[7];
        rubik[47] = rubiktmp[4];
        rubik[48] = rubiktmp[1];
        rubik[49] = rubiktmp[8];
        rubik[50] = rubiktmp[5];
        rubik[51] = rubiktmp[2];
        rubik[52] = rubiktmp[9];
        rubik[53] = rubiktmp[6];
        rubik[54] = rubiktmp[3];
        rubik[27] = rubiktmp[13];
        rubik[24] = rubiktmp[14];
        rubik[21] = rubiktmp[15];
        rubik[3] = rubiktmp[21];
        rubik[6] = rubiktmp[20];
        rubik[9] = rubiktmp[19];
        rubik[36] = rubiktmp[10];
        rubik[33] = rubiktmp[11];
        rubik[30] = rubiktmp[12];
        rubik[12] = rubiktmp[18];
        rubik[15] = rubiktmp[17];
        rubik[18] = rubiktmp[16];
        if (!auto)
        {
            formula += "R ";
            formula1 += "C";
        }
    }
    public void rightprotiv()
    {
        righttmp();
        rubik[46] = rubiktmp[3];
        rubik[47] = rubiktmp[6];
        rubik[48] = rubiktmp[9];
        rubik[49] = rubiktmp[2];
        rubik[50] = rubiktmp[5];
        rubik[51] = rubiktmp[8];
        rubik[52] = rubiktmp[1];
        rubik[53] = rubiktmp[4];
        rubik[54] = rubiktmp[7];
        rubik[21] = rubiktmp[21];
        rubik[24] = rubiktmp[20];
        rubik[27] = rubiktmp[19];
        rubik[9] = rubiktmp[13];
        rubik[6] = rubiktmp[14];
        rubik[3] = rubiktmp[15];
        rubik[12] = rubiktmp[12];
        rubik[15] = rubiktmp[11];
        rubik[18] = rubiktmp[10];
        rubik[30] = rubiktmp[18];
        rubik[33] = rubiktmp[17];
        rubik[36] = rubiktmp[16];
        if (!auto)
        {
            formula += "R' ";
            formula1 += "D";
        }
    }
    void uptmp()
    {
        rubiktmp[1] = rubik[1];
        rubiktmp[2] = rubik[2];
        rubiktmp[3] = rubik[3];
        rubiktmp[4] = rubik[4];
        rubiktmp[5] = rubik[5];
        rubiktmp[6] = rubik[6];
        rubiktmp[7] = rubik[7];
        rubiktmp[8] = rubik[8];
        rubiktmp[9] = rubik[9];
        rubiktmp[10] = rubik[34];
        rubiktmp[11] = rubik[35];
        rubiktmp[12] = rubik[36];
        rubiktmp[13] = rubik[48];
        rubiktmp[14] = rubik[47];
        rubiktmp[15] = rubik[46];
        rubiktmp[16] = rubik[12];
        rubiktmp[17] = rubik[11];
        rubiktmp[18] = rubik[10];
        rubiktmp[19] = rubik[39];
        rubiktmp[20] = rubik[38];
        rubiktmp[21] = rubik[37];
    }
    public void uppo()
    {
        uptmp();
        rubik[1] = rubiktmp[7];
        rubik[2] = rubiktmp[4];
        rubik[3] = rubiktmp[1];
        rubik[4] = rubiktmp[8];
        rubik[5] = rubiktmp[5];
        rubik[6] = rubiktmp[2];
        rubik[7] = rubiktmp[9];
        rubik[8] = rubiktmp[6];
        rubik[9] = rubiktmp[3];
        rubik[10] = rubiktmp[15];
        rubik[11] = rubiktmp[14];
        rubik[12] = rubiktmp[13];
        rubik[34] = rubiktmp[19];
        rubik[35] = rubiktmp[20];
        rubik[36] = rubiktmp[21];
        rubik[37] = rubiktmp[18];
        rubik[38] = rubiktmp[17];
        rubik[39] = rubiktmp[16];
        rubik[46] = rubiktmp[12];
        rubik[47] = rubiktmp[11];
        rubik[48] = rubiktmp[10];
        if (!auto)
        {
            formula += "U ";
            formula1 += "A";
        }
    }
    public void upprotiv()
    {
        uptmp();
        rubik[1] = rubiktmp[3];
        rubik[2] = rubiktmp[6];
        rubik[3] = rubiktmp[9];
        rubik[4] = rubiktmp[2];
        rubik[5] = rubiktmp[5];
        rubik[6] = rubiktmp[8];
        rubik[7] = rubiktmp[1];
        rubik[8] = rubiktmp[4];
        rubik[9] = rubiktmp[7];
        rubik[10] = rubiktmp[21];
        rubik[11] = rubiktmp[20];
        rubik[12] = rubiktmp[19];
        rubik[34] = rubiktmp[13];
        rubik[35] = rubiktmp[14];
        rubik[36] = rubiktmp[15];
        rubik[37] = rubiktmp[12];
        rubik[38] = rubiktmp[11];
        rubik[39] = rubiktmp[10];
        rubik[46] = rubiktmp[18];
        rubik[47] = rubiktmp[17];
        rubik[48] = rubiktmp[16];
        if (!auto)
        {
            formula += "U' ";
            formula1 += "B";
        }
    }
    void backtmp()
    {
        rubiktmp[1] = rubik[28];
        rubiktmp[2] = rubik[29];
        rubiktmp[3] = rubik[30];
        rubiktmp[4] = rubik[31];
        rubiktmp[5] = rubik[32];
        rubiktmp[6] = rubik[33];
        rubiktmp[7] = rubik[34];
        rubiktmp[8] = rubik[35];
        rubiktmp[9] = rubik[36];
        rubiktmp[10] = rubik[25];
        rubiktmp[11] = rubik[26];
        rubiktmp[12] = rubik[27];
        rubiktmp[13] = rubik[54];
        rubiktmp[14] = rubik[51];
        rubiktmp[15] = rubik[48];
        rubiktmp[16] = rubik[3];
        rubiktmp[17] = rubik[2];
        rubiktmp[18] = rubik[1];
        rubiktmp[19] = rubik[37];
        rubiktmp[20] = rubik[40];
        rubiktmp[21] = rubik[43];
    }
    public void backpo()
    {
        backtmp();
        rubik[28] = rubiktmp[7];
        rubik[29] = rubiktmp[4];
        rubik[30] = rubiktmp[1];
        rubik[31] = rubiktmp[8];
        rubik[32] = rubiktmp[5];
        rubik[33] = rubiktmp[2];
        rubik[34] = rubiktmp[9];
        rubik[35] = rubiktmp[6];
        rubik[36] = rubiktmp[3];
        rubik[3] = rubiktmp[13];
        rubik[2] = rubiktmp[14];
        rubik[1] = rubiktmp[15];
        rubik[27] = rubiktmp[21];
        rubik[26] = rubiktmp[20];
        rubik[25] = rubiktmp[19];
        rubik[54] = rubiktmp[10];
        rubik[51] = rubiktmp[11];
        rubik[48] = rubiktmp[12];
        rubik[43] = rubiktmp[18];
        rubik[40] = rubiktmp[17];
        rubik[37] = rubiktmp[16];
        if (!auto)
        {
            formula += "B ";
            formula1 += "R";
        }
    }
    public void backprotiv()
    {
        backtmp();
        rubik[28] = rubiktmp[3];
        rubik[29] = rubiktmp[6];
        rubik[30] = rubiktmp[9];
        rubik[31] = rubiktmp[2];
        rubik[32] = rubiktmp[5];
        rubik[33] = rubiktmp[8];
        rubik[34] = rubiktmp[1];
        rubik[35] = rubiktmp[4];
        rubik[36] = rubiktmp[7];
        rubik[1] = rubiktmp[21];
        rubik[2] = rubiktmp[20];
        rubik[3] = rubiktmp[19];
        rubik[25] = rubiktmp[13];
        rubik[26] = rubiktmp[14];
        rubik[27] = rubiktmp[15];
        rubik[43] = rubiktmp[12];
        rubik[40] = rubiktmp[11];
        rubik[37] = rubiktmp[10];
        rubik[48] = rubiktmp[18];
        rubik[51] = rubiktmp[17];
        rubik[54] = rubiktmp[16];
        if (!auto)
        {
            formula += "B' ";
            formula1 += "Q";
        }
    }
    void downtmp()
    {
        rubiktmp[1] = rubik[19];
        rubiktmp[2] = rubik[20];
        rubiktmp[3] = rubik[21];
        rubiktmp[4] = rubik[22];
        rubiktmp[5] = rubik[23];
        rubiktmp[6] = rubik[24];
        rubiktmp[7] = rubik[25];
        rubiktmp[8] = rubik[26];
        rubiktmp[9] = rubik[27];
        rubiktmp[10] = rubik[16];
        rubiktmp[11] = rubik[17];
        rubiktmp[12] = rubik[18];
        rubiktmp[13] = rubik[52];
        rubiktmp[14] = rubik[53];
        rubiktmp[15] = rubik[54];
        rubiktmp[16] = rubik[30];
        rubiktmp[17] = rubik[29];
        rubiktmp[18] = rubik[28];
        rubiktmp[19] = rubik[43];
        rubiktmp[20] = rubik[44];
        rubiktmp[21] = rubik[45];
    }
    public void downpo()
    {
        downtmp();
        rubik[19] = rubiktmp[7];
        rubik[20] = rubiktmp[4];
        rubik[21] = rubiktmp[1];
        rubik[22] = rubiktmp[8];
        rubik[23] = rubiktmp[5];
        rubik[24] = rubiktmp[2];
        rubik[25] = rubiktmp[9];
        rubik[26] = rubiktmp[6];
        rubik[27] = rubiktmp[3];
        rubik[30] = rubiktmp[13];
        rubik[29] = rubiktmp[14];
        rubik[28] = rubiktmp[15];
        rubik[18] = rubiktmp[21];
        rubik[17] = rubiktmp[20];
        rubik[16] = rubiktmp[19];
        rubik[52] = rubiktmp[10];
        rubik[53] = rubiktmp[11];
        rubik[54] = rubiktmp[12];
        rubik[45] = rubiktmp[18];
        rubik[44] = rubiktmp[17];
        rubik[43] = rubiktmp[16];
        if (!auto)
        {
            formula += "D ";
            formula1 += "H";
        }
    }
    public void downprotiv()
    {
        downtmp();
        rubik[19] = rubiktmp[3];
        rubik[20] = rubiktmp[6];
        rubik[21] = rubiktmp[9];
        rubik[22] = rubiktmp[2];
        rubik[23] = rubiktmp[5];
        rubik[24] = rubiktmp[8];
        rubik[25] = rubiktmp[1];
        rubik[26] = rubiktmp[4];
        rubik[27] = rubiktmp[7];
        rubik[28] = rubiktmp[21];
        rubik[29] = rubiktmp[20];
        rubik[30] = rubiktmp[19];
        rubik[16] = rubiktmp[13];
        rubik[17] = rubiktmp[14];
        rubik[18] = rubiktmp[15];
        rubik[45] = rubiktmp[12];
        rubik[44] = rubiktmp[11];
        rubik[43] = rubiktmp[10];
        rubik[54] = rubiktmp[18];
        rubik[53] = rubiktmp[17];
        rubik[52] = rubiktmp[16];
        if (!auto)
        {
            formula += "D' ";
            formula1 += "G";
        }
    }
    void centrverttmp()
    {
        rubiktmp[1] = rubik[2];
        rubiktmp[2] = rubik[5];
        rubiktmp[3] = rubik[8];
        rubiktmp[4] = rubik[11];
        rubiktmp[5] = rubik[14];
        rubiktmp[6] = rubik[17];
        rubiktmp[7] = rubik[20];
        rubiktmp[8] = rubik[23];
        rubiktmp[9] = rubik[26];
        rubiktmp[10] = rubik[29];
        rubiktmp[11] = rubik[32];
        rubiktmp[12] = rubik[35];
    }
    public void centrvertpo()
    {
        centrverttmp();
        rubik[2] = rubiktmp[10];
        rubik[5] = rubiktmp[11];
        rubik[8] = rubiktmp[12];
        rubik[11] = rubiktmp[1];
        rubik[14] = rubiktmp[2];
        rubik[17] = rubiktmp[3];
        rubik[20] = rubiktmp[4];
        rubik[23] = rubiktmp[5];
        rubik[26] = rubiktmp[6];
        rubik[29] = rubiktmp[7];
        rubik[32] = rubiktmp[8];
        rubik[35] = rubiktmp[9];
        if (!auto)
        {
            formula += "M ";
            formula1 += "J";
        }
    }
    public void centrvertprotiv()
    {
        centrverttmp();
        rubik[2] = rubiktmp[4];
        rubik[5] = rubiktmp[5];
        rubik[8] = rubiktmp[6];
        rubik[11] = rubiktmp[7];
        rubik[14] = rubiktmp[8];
        rubik[17] = rubiktmp[9];
        rubik[20] = rubiktmp[10];
        rubik[23] = rubiktmp[11];
        rubik[26] = rubiktmp[12];
        rubik[29] = rubiktmp[1];
        rubik[32] = rubiktmp[2];
        rubik[35] = rubiktmp[3];
        if (!auto)
        {
            formula += "M' ";
            formula1 += "I";
        }
    }
    public void centrvertrpofront()
    {
        upprotiv();
        centrgorpo();
        downpo();
        centrvertprotiv();
        downprotiv();
        centrgorprotiv();
        uppo();
        if (!auto)
        {
            gameObject.GetComponent<Rotation>().m = 15;
            gameObject.GetComponent<Rotation>().prov1 = false;
            gameObject.GetComponent<CubeRotation>().Update();
            formula1 += "P";
        }
    }
    public void centrvertrprotivfront()
    {
        upprotiv();
        centrgorpo();
        downpo();
        centrvertpo();
        downprotiv();
        centrgorprotiv();
        uppo();
        if (!auto)
        {
            gameObject.GetComponent<Rotation>().m = 16;
            gameObject.GetComponent<Rotation>().prov1 = false;
            gameObject.GetComponent<CubeRotation>().Update();
            formula1 += "O"; 
        }
    }
    void centrgortmp()
    {
        rubiktmp[1] = rubik[13];
        rubiktmp[2] = rubik[14];
        rubiktmp[3] = rubik[15];
        rubiktmp[4] = rubik[49];
        rubiktmp[5] = rubik[50];
        rubiktmp[6] = rubik[51];
        rubiktmp[7] = rubik[33];
        rubiktmp[8] = rubik[32];
        rubiktmp[9] = rubik[31];
        rubiktmp[10] = rubik[40];
        rubiktmp[11] = rubik[41];
        rubiktmp[12] = rubik[42];
    }
    public void centrgorpo()
    {
        centrgortmp();
        rubik[13] = rubiktmp[10];
        rubik[14] = rubiktmp[11];
        rubik[15] = rubiktmp[12];
        rubik[49] = rubiktmp[1];
        rubik[50] = rubiktmp[2];
        rubik[51] = rubiktmp[3];
        rubik[33] = rubiktmp[4];
        rubik[32] = rubiktmp[5];
        rubik[31] = rubiktmp[6];
        rubik[40] = rubiktmp[7];
        rubik[41] = rubiktmp[8];
        rubik[42] = rubiktmp[9];
        if (!auto)
        {
            formula += "E ";
            formula1 += "K";
        }
    }
    public void centrgorprotiv()
    {
        centrgortmp();
        rubik[13] = rubiktmp[4];
        rubik[14] = rubiktmp[5];
        rubik[15] = rubiktmp[6];
        rubik[49] = rubiktmp[7];
        rubik[50] = rubiktmp[8];
        rubik[51] = rubiktmp[9];
        rubik[33] = rubiktmp[10];
        rubik[32] = rubiktmp[11];
        rubik[31] = rubiktmp[12];
        rubik[40] = rubiktmp[1];
        rubik[41] = rubiktmp[2];
        rubik[42] = rubiktmp[3];
        if (!auto)
        {
            formula += "E' ";
            formula1 += "L";
        }
    }
    void OnGUI()
    {
        GUIStyle style = GUI.skin.GetStyle("label");
        style.fontSize = (int)(12);
        GUI.Label(new Rect(5, 5, 400, 600), "Формула: " + formula);
    }
}
