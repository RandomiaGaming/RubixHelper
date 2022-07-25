using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubixHelper
{

    //Cube state by tile colors:
    //Possible Permutations: 4738381338321616896
    //Bytes per permutation: 192
    public sealed class CubeState
    {
        public static readonly CubeState Default = new CubeState(FaceState.White, FaceState.Yellow, FaceState.Red, FaceState.Orange, FaceState.Green, FaceState.Blue);
        public static readonly CubeState Solved = new CubeState(FaceState.White, FaceState.Yellow, FaceState.Red, FaceState.Orange, FaceState.Green, FaceState.Blue);

        public static readonly CubeState White = new CubeState(FaceState.White, FaceState.White, FaceState.White, FaceState.White, FaceState.White, FaceState.White);
        public static readonly CubeState Yellow = new CubeState(FaceState.Yellow, FaceState.Yellow, FaceState.Yellow, FaceState.Yellow, FaceState.Yellow, FaceState.Yellow);
        public static readonly CubeState Red = new CubeState(FaceState.Red, FaceState.Red, FaceState.Red, FaceState.Red, FaceState.Red, FaceState.Red);
        public static readonly CubeState Orange = new CubeState(FaceState.Orange, FaceState.Orange, FaceState.Orange, FaceState.Orange, FaceState.Orange, FaceState.Orange);
        public static readonly CubeState Green = new CubeState(FaceState.Green, FaceState.Green, FaceState.Green, FaceState.Green, FaceState.Green, FaceState.Green);
        public static readonly CubeState Blue = new CubeState(FaceState.Blue, FaceState.Blue, FaceState.Blue, FaceState.Blue, FaceState.Blue, FaceState.Blue);

        public static CubeState IllegalScrable
        {
            get
            {
                return default(CubeState);
            }
        }

        public FaceState Top = FaceState.White;
        public FaceState Bottom = FaceState.Yellow;
        public FaceState Front = FaceState.Red;
        public FaceState Back = FaceState.Orange;
        public FaceState Left = FaceState.Green;
        public FaceState Right = FaceState.Blue;

        public CubeState()
        {
            Top = FaceState.White;
            Bottom = FaceState.Yellow;
            Front = FaceState.Red;
            Back = FaceState.Orange;
            Left = FaceState.Green;
            Right = FaceState.Blue;
        }
        public CubeState(FaceState faceState)
        {
            Top = faceState;
            Bottom = faceState;
            Front = faceState;
            Back = faceState;
            Left = faceState;
            Right = faceState;
        }
        public CubeState(CubeColor cubeColor)
        {
            Top = new FaceState(cubeColor, cubeColor, cubeColor, cubeColor);
            Bottom = new FaceState(cubeColor, cubeColor, cubeColor, cubeColor);
            Front = new FaceState(cubeColor, cubeColor, cubeColor, cubeColor);
            Back = new FaceState(cubeColor, cubeColor, cubeColor, cubeColor);
            Left = new FaceState(cubeColor, cubeColor, cubeColor, cubeColor);
            Right = new FaceState(cubeColor, cubeColor, cubeColor, cubeColor);
        }
        public CubeState(FaceState top, FaceState bottom, FaceState front, FaceState back, FaceState left, FaceState right)
        {
            Top = top;
            Bottom = bottom;
            Front = front;
            Back = back;
            Left = left;
            Right = right;
        }
    }
}
