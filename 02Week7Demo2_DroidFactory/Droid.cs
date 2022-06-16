/* Name: Clint MacDonald
 * Date: June 13, 2022
 * Title: Droid Class
 * Purpose: NETD2202 Week 7 Class Demo
 */

#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion

namespace W7_Demo_Classes1
{
    class Droid
    {
        #region Global Variables
        //protected vs private vs public
        public const int MinDesignationLength = 3;
        public const int MaxDesignationLength = 8;
        public const int MinOwnerLength = 4;

        public static List<Droid> droids = new List<Droid>();
        #endregion

        #region Properties
        // long way - commented out as it will be a duplicate
        //private string designation;
        //public string Designation
        //{
        //    get { return designation; }
        //    set { designation = value; }
        //}

        public string Designation { get; set; }
        public string Owner { get; set; }
        public bool IsInService { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Droid() 
        {
            SetDefaults();
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="designation"></param>
        /// <param name="owner"></param>
        /// <param name="isInService"></param>
        /// <param name="primaryColor"></param>
        /// <param name="secondaryColor"></param>
        public Droid(string designation, string owner, bool isInService, Color primaryColor, Color secondaryColor)
        {
            Designation = designation;
            Owner = owner;
            IsInService = isInService;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion

        #region Custom Methods
        private void SetDefaults()
        {
            Designation = string.Empty;
            Owner = string.Empty;
            IsInService = false;
            PrimaryColor = Color.Gray;
            SecondaryColor = Color.Gray;
        }

        public void SellDroid(string owner, bool isInService)
        {
            Owner = owner;
            IsInService = isInService;
        }
        #endregion

        #region Static Methods
        public static Droid FindDroid(string designation)
        {
            Droid returnDroid = new Droid();
            // search for droid
            foreach (Droid d in droids)
            {
                if (d.Designation == designation)
                {
                    return d;
                }
            }

            return returnDroid;
        }

        public static void CreateTestDroids()
        {
            droids.Add(new Droid("C3P0", "Anakin Skywalker", true, Color.Gold, Color.Black));
            droids.Add(new Droid("R2D2", "Obi-One Kinobi", true, Color.LightGray, Color.Blue));
            droids.Add(new Droid("BB8", "Po Damarin", true, Color.White, Color.Orange));
        }
        #endregion
    }
}
