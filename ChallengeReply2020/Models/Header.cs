using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeReply2020.Models
{
    public class Header
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int CustomerNumber { get; set; }
        public int MaximumReplyOffices { get; set; }
        public Header(string data)
        {
            var bla = data.Split(' ');

            Width = int.Parse(bla[0]);
            Height = int.Parse(bla[1]);
            CustomerNumber = int.Parse(bla[2]);
            MaximumReplyOffices = int.Parse(bla[3]);
        }
    }
}
