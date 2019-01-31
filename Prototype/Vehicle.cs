using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    internal abstract class Vehicle

    {

        internal string VehicleType

        {

            get;

            set;

        }

        internal string Brand

        {

            get;

            set;

        }

        internal string Model

        {

            get;

            set;

        }

        internal abstract void ShowDetails();

        internal abstract Vehicle ShallowCopy();

        internal abstract Vehicle DeepCopy();

        internal ExtraInformation MoreInfo = new ExtraInformation();

    }
}
