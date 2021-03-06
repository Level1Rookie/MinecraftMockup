﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attempt1
{
    public static class CubeMeshData
    {
        static Vector3[] cubeVertices = new Vector3[]
        {
        new Vector3( 1,-1, 1),
        new Vector3( 1, 1, 1),
        new Vector3(-1, 1, 1),
        new Vector3(-1,-1, 1),
        new Vector3(-1,-1,-1),
        new Vector3(-1, 1,-1),
        new Vector3( 1, 1,-1),
        new Vector3( 1,-1,-1)
        };

        static int[][] cubeFaces = new int[][]
        {
        new int[]{0,1,2,3},
        new int[]{7,6,1,0},
        new int[]{4,5,6,7},
        new int[]{3,2,5,4},
        new int[]{5,2,1,6},
        new int[]{3,4,7,0}
        };

        public static Vector3[] GetFaceVertices(int dir, Vector3 pos, float scale)
        {
            Vector3[] faceVertices = new Vector3[4];
            for (int i = 0; i < faceVertices.Length; i++)
            {
                faceVertices[i] = pos + cubeVertices[cubeFaces[dir][i]] * scale;
            }
            return faceVertices;
        }

        public static Vector3[] GetFaceVertices(Direction dir, Vector3 pos, float scale)
        {
            return GetFaceVertices((int)dir, pos, scale);
        }
    }

    public enum Direction
    {
        North,
        East,
        South,
        West,
        Up,
        Down
    }

}