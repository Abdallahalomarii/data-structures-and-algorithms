﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10_stack_and_queue.Stack
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public Node(int data) 
        {
            Data = data;
            Next = null;
        }
    }
}
