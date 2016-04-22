using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HydraTouch
{
    class ProgramActions
    {

        //public static bool[] justPressed = { false, false };
        //public static bool[] justReleased = { false, false };
        //public static bool[] holding = { false, false };
        //public static bool[] active = { false, false };

        //private const int LEFT = 0;
        //private const int RIGHT = 1;















            //        for (int i = 0; i <=1; i++)
            //{

            //    if (ControllerData.controller[i].one == true && holding[i] == false) // pressed right
            //    {
            //        justPressed[i] = true;
            //        holding[i] = true;
            //    }

            //    if (ControllerData.controller[i].one == false && holding[i] == true) // released right
            //    {
            //        justReleased[i] = true;
            //        holding[i] = false;
            //    }


            //    if (justPressed[i])
            //    {
            //        justPressed[i] = false;
            //        TouchActions.TouchDown(i);
            //    }

            //    if (justReleased[i])
            //    {
            //        justReleased[i] = false;
            //        TouchActions.Release(i);
            //    }

            //    if (!holding[i])
            //        TouchActions.SetHover(i);

            //    if (ControllerData.controller[i].start == true)
            //        LaserPointer.Calibrate(i);
            //}

















        //for (int i = 0; i < contacts.Count(); i++) // always from 0 to 1 currently
        //{

        //    if (contacts[i].active == false) // the contact is inactive
        //    {
        //        if (ControllerData.controller[i].docked == false) // becomes active
        //        {
        //            contacts[i] = new TouchContact(i, ContactType.New, new Point(0, 0));
        //            contacts[i].active = true;
        //            TouchActions.AddContact(i);
        //        }
        //    }
        //    else // the contact is active
        //    {
        //        if (ControllerData.controller[i].one == true && contacts[i].holding == false) // pressed
        //        {
        //            contacts[i].justPressed = true;
        //            contacts[i].holding = true;
        //        }

        //        if (ControllerData.controller[i].one == false && contacts[i].holding == true) // released
        //        {
        //            contacts[i].justReleased = true;
        //            contacts[i].holding = false;
        //        }


        //        if (contacts[i].justPressed)
        //        {
        //            contacts[i].justPressed = false;
        //            TouchActions.TouchDown(i);
        //        }

        //        if (contacts[i].justReleased)
        //        {
        //            contacts[i].justReleased = false;
        //            TouchActions.Release(i);
        //        }

        //        if (!contacts[i].holding)
        //            TouchActions.SetHover(i);

        //        if (ControllerData.controller[i].start == true)
        //            LaserPointer.Calibrate(i);


        //        if (ControllerData.controller[i].docked == true) // becomes inactive
        //        {
        //            contacts[i].active = false;
        //            TouchActions.RemoveContact(i);
        //        }
        //    }
        //}

        ////todo: reset contacts with "new" type?

        //if (TouchActions.injectorList.Count() > 0)
        //    TouchActions.MoveContacts();

    }
}
