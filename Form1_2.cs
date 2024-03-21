using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private static String[] Items = {"Earrings","Ring,Necklace", "Bangle", "Cufflinks", "Watch" , "Anklet", "Belly Button Piercing", "Nose Piercing" , "Bracelet", "Hairband", "Belly Chain"};
        private static String[] Colours = { "Gold", "Silver", "Rose Gold", "Mixed Metal", "Purple", "Blue"};

        private int[,] Stock = new int[Items.Length, Colours.Length];
        private int[,] OpeningStock = new int[Items.Length, Colours.Length];

        private decimal[,] Prices =
        {
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m },
            {10m,11m,12m,13m,14m,15m }
        };
         private int [,] ItemsAvailable = 
         {{9,8,5,4,3,5},
          {2,6,9,6,7,14},
          {15,20,17,10,11,19},
          {19,7,16,12,14,10},
          {13,12,20,5,7,16},
          {6,17,19,4,3,18},
          {5,10,14,15,9,18},
          {4,7,9,12,15,16},
          {15,5,8,4,5,9},
          {2,5,3,16,18,3},
          {3,8,19,15,2,9},
          {5,19,14,17,20,5}};
          

    
        

      
    }
}
