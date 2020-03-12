using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeReply2020.Models
{
    public class Map
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private char[,] MapContent { get; set; }


        public Map(int width,int height)
        {
            Width = width;
            Height = height;

            MapContent = new char[Width, Height];
        }


        public void addLinha(int x,int y,char data)
        {
            MapContent[x, y] = data;
        }
    }
}
