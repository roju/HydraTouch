using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlimDX; //remove

namespace HydraTouch
{
    class LaserPointer
    {   
        static Vector3 N = new Vector3(0, 0, -1); //plane normal
        //static Vector3 D = new Vector3(); //empty direction vector
        static Vector3 forward = new Vector3(0,0,1); //facing forward

        public static float d = 220; // distance of the plane/monitor from the base/origin
        public static float t;

        public static float topLeftX = 200;
        public static float topLeftY = 340;
        public static float screenZ = -220;

        private const int TOP_LEFT_X = 0;
        private const int TOP_LEFT_Y = 1;
        private const int BOTTOM_RIGHT_X = 2;
        private const int BOTTOM_RIGHT_Y = 3;

        public static float[] screenCoords = {200,330,718,120};




        public Vector2 intersectPoint(int index)
        {
            float X, Y; //Z;
            d = -screenZ;

            Vector3 D = Vector3.TransformNormal(forward, ControllerData.rotMat[index]);
            D.Normalize();

            t = (Vector3.Dot(N, ControllerData.posVector[index]) + d) / (Vector3.Dot(N, D)); //todo: calc without slimdx

            X = ((ControllerData.posVector[index].X + (t * D.X)));
            Y = ((ControllerData.posVector[index].Y + (t * D.Y)));
            //Z = ((ControllerData.posVector[index].Z + (t * D.Z)));

            // screen calibration
            X -= screenCoords[TOP_LEFT_X]; //200
            X *= 4;
            Y -= screenCoords[TOP_LEFT_Y]; //330
            Y *= 4;
            Y = -Y;

            //SettingsWindow.debugText[2] =
            //    "t: " + t +
            //    "\n\niX: " + X +
            //    "\niY: " + Y +
            //    //"\niZ: " + Z +
            //    "\n\niDx: " + D.X +
            //    "\nDy: " + D.Y +
            //    "\nDz: " + D.Z;

            return new Vector2(X,Y);
        }


        public static void Calibrate(int i)
        {
                screenCoords[0] = ControllerData.controller[i].x;
                screenCoords[1] = ControllerData.controller[i].y;
                screenZ = ControllerData.controller[i].z;
        }
    }
}
