using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCD.System.TouchInjection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Drawing;
using System.Windows;

namespace HydraTouch
{
    class TouchActions
    {
        // the number of contacts is the same as the number of controllers
        public static List<TouchContact> contacts = new List<TouchContact>();
        public static PointerTouchInfo[] injector;
        public static List<PointerTouchInfo> injectorList = new List<PointerTouchInfo>();
        public static LaserPointer lp = new LaserPointer();

        //public static List<Controller> c = new List<Controller>();

        public static int numControllers;
        //public static int numContacts; // dont initialize



        public static void InitializeContacts()
        {
            numControllers = ControllerData.controller.Count();
            //numContacts = ControllerData.controller.Count();

            for (int i = 0; i < numControllers; i++)
            {
                contacts.Add(new TouchContact((int)lp.intersectPoint(i).X, (int)lp.intersectPoint(i).Y, i));
                contacts[i].ActiveChanged += new TouchContact.EventHandler(UpdateInjectors);
                //c.Add(new Controller(i, ControllerData.plugin));
                //c[i].DockedChanged += new Controller.EventHandler(TestMethod);

                //injectorList.Add(MakePointerTouchInfo(contacts[i].PosX, contacts[i].PosY, (uint)contacts[i].ID));
            }

            injector = injectorList.ToArray();
        }



        //public static void TestMethod(Controller c, EventArgs e)
        //{
        //    SettingsWindow.debugText[3] = "works";
        //}


        //public static int GetControllerIndex(TouchContact contact)
        //{
        //    for (int i = 0; i < numControllers; i++)
        //    {
        //        if (ControllerData.controller[i].docked == false)
        //        {
        //            contact.ControllerIndex = i;
        //        }
        //    }
        //}



        public static void SetActiveContact(TouchContact contact, int i)
        {
            if (ControllerData.controller[i].docked == false)
            {
                contact.ControllerIndex = i;
                contact.Active = true;
            }
            else
            {
                contact.Active = false;
            }
        }



        public static int numActiveContacts()
        {
            //int count = 0;
            //for (int i = 0; i < numControllers; i++)
            //{
            //    if (contacts[i].Active)
            //        count++;
            //}
            //return count;

            int count = 0;
            for (int i = 0; i < numControllers; i++)
            {
                if (ControllerData.controller[i].docked == false)
                    count++;
            }
            return count;
        }



        public static void UpdateInjectors(TouchContact contact, EventArgs e)
        {
            if (contact.Active)
            {
                //contact.ID = numContacts() - 1;
                injectorList.Add(MakePointerTouchInfo(contact.PosX, contact.PosY, (uint)contact.ControllerIndex)); // (uint)numContacts() - 1

                // pick up right controller: contacts[0].ID = 1
                contacts[injectorList.Count() - 1].ID = contact.ControllerIndex;
                //injector = injectorList.ToArray();
            }
            else
            {
                injectorList.RemoveAt(injectorList.Count() - 1); // remove last injector in the list
                //injectorList.RemoveAt(contact.ID);
                //injectorList.RemoveAt(0);
                //injectorList.RemoveAt(numActiveContacts());
                //injectorList.RemoveAt(contact.ControllerIndex);
                //int r = contacts.LastIndexOf(contact);
                //injectorList.RemoveAt(r);
                //injector = injectorList.ToArray();
            }
            injector = injectorList.ToArray();
        }




        public static void Run()
        {

            for (int i = 0; i < numControllers; i++)
            {
                SetActiveContact(contacts[i], i); //determine whether the contact is active (undocked)
            }



            for (int i = 0; i < numControllers; i++)
            {
                int index = (numActiveContacts() - 1) * i;
                //int index = contacts[i].ID;
                //int index = (int)injector[i].PointerInfo.PointerId;
                //int index = contacts[i].ControllerIndex;

                if (contacts[i].Active)
                {
                    if (ControllerData.controller[i].one == true && contacts[i].Holding == false) // pressed
                    {
                        contacts[i].JustPressed = true;
                        contacts[i].Holding = true;
                    }

                    if (ControllerData.controller[i].one == false && contacts[i].Holding == true) // released
                    {
                        contacts[i].JustReleased = true;
                        contacts[i].Holding = false;
                    }


                    if (contacts[i].JustPressed)
                    {
                        contacts[i].JustPressed = false;
                        TouchActions.TouchDown(index);
                    }

                    if (contacts[i].JustReleased)
                    {
                        contacts[i].JustReleased = false;
                        TouchActions.Release(index);
                    }

                    if (contacts[i].Holding == false)
                        TouchActions.SetHover(index);

                    if (ControllerData.controller[i].start == true)
                        LaserPointer.Calibrate(index);

                    injector[index].PointerInfo.PtPixelLocation.X = (int)lp.intersectPoint(i).X;
                    injector[index].PointerInfo.PtPixelLocation.Y = (int)lp.intersectPoint(i).Y;
                }
            }

            bool s = TouchInjector.InjectTouchInput(numActiveContacts(), injector);


            //for (int i = 0; i < numControllers; i++)
            //{
            //    int index = (numActiveContacts() - 1) * i;
            //    //int index = contacts[i].ID;
            //    //int index = (int)injector[i].PointerInfo.PointerId;

            //    if (contacts[i].Active)
            //    {

            //        if (ControllerData.controller[i].one == true && contacts[i].Holding == false) // pressed
            //        {
            //            contacts[i].JustPressed = true;
            //            contacts[i].Holding = true;
            //        }

            //        if (ControllerData.controller[i].one == false && contacts[i].Holding == true) // released
            //        {
            //            contacts[i].JustReleased = true;
            //            contacts[i].Holding = false;
            //        }


            //        if (contacts[i].JustPressed)
            //        {
            //            contacts[i].JustPressed = false;
            //            TouchActions.TouchDown(index);
            //        }

            //        if (contacts[i].JustReleased)
            //        {
            //            contacts[i].JustReleased = false;
            //            TouchActions.Release(index);
            //        }

            //        if (contacts[i].Holding == false)
            //            TouchActions.SetHover(index);

            //        if (ControllerData.controller[i].start == true)
            //            LaserPointer.Calibrate(index);

            //        injector[index].PointerInfo.PtPixelLocation.X = (int)lp.intersectPoint(i).X;
            //        injector[index].PointerInfo.PtPixelLocation.Y = (int)lp.intersectPoint(i).Y;
            //    }
            //}




            SettingsWindow.debugText[2] =
            "\nnumActiveContacts: " + numActiveContacts() +
            "\nc0 active: " + contacts[0].Active +
            "\nc1 active: " + contacts[1].Active +
            "\nc0 ID: " + contacts[0].ID +
            "\nc1 ID: " + contacts[1].ID +
            "\ninjectorlist count: " + injectorList.Count();
            //"\ninjectorArray leng: " + injector.Count();
        }


        public static void SetHover(int index)
        {
            injector[index].PointerInfo.PointerFlags = PointerFlags.INRANGE | PointerFlags.UPDATE; //set to "hover mode"
        }


        public static void TouchDown(int index)
        {
            injector[index].PointerInfo.PointerFlags = PointerFlags.DOWN | PointerFlags.INRANGE | PointerFlags.INCONTACT;
            bool s = TouchInjector.InjectTouchInput(numActiveContacts(), injector);
            injector[index].PointerInfo.PointerFlags = PointerFlags.UPDATE | PointerFlags.INRANGE | PointerFlags.INCONTACT;
        }


        //public static void MoveContacts()
        //{
        //    //set x and y to new coords
        //    for (int i = 0; i < numContacts(); i++)
        //    {
        //        injector[i].PointerInfo.PtPixelLocation.X = (int)lp.intersectPoint(i).X;
        //        injector[i].PointerInfo.PtPixelLocation.Y = (int)lp.intersectPoint(i).Y;
        //    }

        //    bool s = TouchInjector.InjectTouchInput(numContacts(), injector);
        //}


        public static void Release(int index)
        {
            injector[index].PointerInfo.PointerFlags = PointerFlags.UP | PointerFlags.INRANGE;
            bool s1 = TouchInjector.InjectTouchInput(numActiveContacts(), injector);
        }

        //unused currently
        public static void RightClick()
        {
            MouseSimulator.ClickRightMouseButton();
        }

        public static PointerTouchInfo MakePointerTouchInfo(int x, int y, uint id, int radius = 1, uint orientation = 90, uint pressure = 32000) //radius unused
        {
            PointerTouchInfo contact = new PointerTouchInfo();
            contact.PointerInfo.pointerType = PointerInputType.TOUCH;
            contact.TouchFlags = TouchFlags.NONE;
            contact.Orientation = orientation;
            contact.Pressure = pressure;
            contact.TouchMasks = TouchMask.CONTACTAREA | TouchMask.ORIENTATION | TouchMask.PRESSURE;
            contact.PointerInfo.PtPixelLocation.X = x;
            contact.PointerInfo.PtPixelLocation.Y = y;
            contact.PointerInfo.PointerId = id;
            //contact.ContactArea.left = x - radius;
            //contact.ContactArea.right = x + radius;
            //contact.ContactArea.top = y - radius;
            //contact.ContactArea.bottom = y + radius;
            return contact;
        }





        //[StructLayout(LayoutKind.Sequential)]
        //public struct POINT
        //{
        //    public int X;
        //    public int Y;

        //    public static implicit operator Point(POINT point)
        //    {
        //        return new Point(point.X, point.Y);
        //    }
        //}

        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool GetCursorPos(out POINT lpPoint);
        //static POINT mousePos;

        //private static void getCoords()
        //{
        //    bool s = GetCursorPos(out mousePos);
        //    /*
        //    if (GetCursorPos(out mousePos))
        //    {
        //        strCoords = Convert.ToString(mousePos.X) + " : " + Convert.ToString(mousePos.Y);
        //        lblCoords.Text = strCoords;
        //    }
        //     */
        //}
    }
}
