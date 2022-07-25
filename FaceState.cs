namespace RubixHelper
{
    public sealed class FaceState
    {
        public static readonly FaceState Default = new FaceState(CubeColor.White, CubeColor.White, CubeColor.White, CubeColor.White);
        public static readonly FaceState White = new FaceState(CubeColor.White, CubeColor.White, CubeColor.White, CubeColor.White);
        public static readonly FaceState Yellow = new FaceState(CubeColor.Yellow, CubeColor.Yellow, CubeColor.Yellow, CubeColor.Yellow);
        public static readonly FaceState Red = new FaceState(CubeColor.Red, CubeColor.Red, CubeColor.Red, CubeColor.Red);
        public static readonly FaceState Orange = new FaceState(CubeColor.Orange, CubeColor.Orange, CubeColor.Orange, CubeColor.Orange);
        public static readonly FaceState Green = new FaceState(CubeColor.Green, CubeColor.Green, CubeColor.Green, CubeColor.Green);
        public static readonly FaceState Blue = new FaceState(CubeColor.Blue, CubeColor.Blue, CubeColor.Blue, CubeColor.Blue);

        public static FaceState IllegalScramble
        {
            get
            {
                return default(FaceState);
            }
        }

        public CubeColor Color1 = CubeColor.White;
        public CubeColor Color2 = CubeColor.White;
        public CubeColor Color3 = CubeColor.White;
        public CubeColor Color4 = CubeColor.White;

        public FaceState()
        {
            Color1 = CubeColor.White;
            Color2 = CubeColor.White;
            Color3 = CubeColor.White;
            Color4 = CubeColor.White;
        }
        public FaceState(CubeColor cubeColor)
        {
            Color1 = cubeColor;
            Color2 = cubeColor;
            Color3 = cubeColor;
            Color4 = cubeColor;
        }
        public FaceState(CubeColor color1, CubeColor color2, CubeColor color3, CubeColor color4)
        {
            Color1 = color1;
            Color2 = color2;
            Color3 = color3;
            Color4 = color4;
        }
    }
}
