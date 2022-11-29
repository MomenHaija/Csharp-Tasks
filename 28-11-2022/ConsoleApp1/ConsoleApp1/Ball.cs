using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ball
    {
       private float x; 
       public float X { get; set; } 

       private float y;
       public float Y { get; set; }
       
       private float z;
       public float Z { get; set; }

       public Ball()
        {

        }
       public Ball(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }

       public void SetXYZ(float x,float y,float z)
       {
            this.x = x;
            this.y = y;
            this.z = z;
       }
       public string ToString() {
            return $"X:{x}\nY:{y} \nZ:{z}"; 
       }

    }
    internal class Player : Ball
    {
        private int number;
        public int Number
        {

            get { return number; }
            set { number = value; }
        }

        private float x = 0;
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        private float y = 0;
        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        private float z;
        public float Z
        {
            get { return z; }
            set
            {
                z = value;
            }
        }
        public Player(int number,float x,float y,float z):base(x,y,z) 
        {
            this.Number= number;    
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Move()
        {
            Console.WriteLine($"Location at X={x} and Y:{y}");
        }
        public void Jump() {
            Console.WriteLine("Jump to Point:"+z); 
        }
        private float dis;
        public bool Near()
        {
            dis = y - x;
           return ((y - x) < 8) ?  true : false;
        }
        public void Ball()
        {
            Console.WriteLine("Ball");
        }



    }

}