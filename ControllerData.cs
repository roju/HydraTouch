using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlimDX;

namespace HydraTouch
{
    public class ControllerData
    {

        public static HydraPlugin plugin = new HydraPlugin();
        //public static HydraPluginGlobal[] controller = new HydraPluginGlobal[2];

        public static List<HydraPluginGlobal> controller = new List<HydraPluginGlobal>(); // 2 controllers are added to the list in Main

        //public static Quaternion[] rotQuat = new Quaternion[2];
        //public static Vector3[] eulerVector = new Vector3[2];
        public static Matrix[] rotMat = new Matrix[2];
        public static Vector3[] posVector = new Vector3[2];


        //change to non-static

        public static void UpdateAllData()
        {
            plugin.Update();

            for (int i = 0; i < controller.Count(); i++)
            {



                rotMat[i].M11 = controller[i].m00;
                rotMat[i].M12 = controller[i].m01;
                rotMat[i].M13 = controller[i].m02;
                rotMat[i].M21 = controller[i].m10;
                rotMat[i].M22 = controller[i].m11;
                rotMat[i].M23 = controller[i].m12;
                rotMat[i].M31 = controller[i].m20;
                rotMat[i].M32 = controller[i].m21;
                rotMat[i].M33 = controller[i].m22;

                posVector[i].X = controller[i].x;
                posVector[i].Y = controller[i].y;
                posVector[i].Z = -controller[i].z; //negative

                //rotMat[i].M11 = 1;
                //rotMat[i].M12 = 0;
                //rotMat[i].M13 = 0;
                //rotMat[i].M21 = 0;
                //rotMat[i].M22 = 1;
                //rotMat[i].M23 = 0;
                //rotMat[i].M31 = 0;
                //rotMat[i].M32 = 0;
                //rotMat[i].M33 = 1;

                //rotQuat[i].X = controller[i].q0;
                //rotQuat[i].Y = controller[i].q1;
                //rotQuat[i].Z = controller[i].q2;
                //rotQuat[i].W = controller[i].q3;

                //eulerVector[i].X = controller[i].yaw;
                //eulerVector[i].Y = controller[i].pitch;
                //eulerVector[i].Z = controller[i].roll;
            }
        }
    }
}
