﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik13_2
{
    class Matrissa
    {
        public int n;
        public int m;
        public int[,] A;
        public int[,] B;
        Random rand = new Random();
        public Matrissa(int n,int m)
        {
            this.n = n;
            this.m = m;
            A = new int[n, m];      
            B = new int[n, m];
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int[,] A_Matrissa()
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    A[i, j] = rand.Next() % 10;
                }
            }
            return A;
        }
        public int[,] B_Matrissa()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    B[i, j] = rand.Next() % 10;
                }
            }
            return B;
        }
    }
    class ARIFM_MATRITSA:Matrissa
    {
        public int[,] C;
        public ARIFM_MATRITSA(int n, int m)
            : base(n, m)
        {
            C = new int[n, m];
        }
        public int[,] Yig_Matrissa()
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    C[i, j] =this.A[i,j]+this.B[i,j];
                }
            }
            return C;
        }
        public int[,] Ayirma_Matrissa()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
            return C;
        }
        public int[,] Kopaytma_Matrissa()
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        s += A[i, k] * B[k, j];                        
                    }
                    C[i, j] = s;
                    s = 0;
                }               
            }
            return C;
        }

    }
}
