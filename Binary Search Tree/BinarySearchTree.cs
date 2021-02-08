using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinarySearchTree
    {
        //Member Variables
        public Node rootNode;

        //Constructor

        //Member Methods
        public void AddNode(Node nodeToAdd)
        {
            if(rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node focusNode = rootNode;
                while (true)
                {
                    if(nodeToAdd.data < focusNode.data)
                    {
                        if(focusNode.leftNode == null)
                        {
                            focusNode.leftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.leftNode;
                        }
                    }
                    else
                    {
                        if(nodeToAdd.data > focusNode.data)
                        {
                            if(focusNode.rightNode == null)
                            {
                                focusNode.rightNode = nodeToAdd;
                                break;
                            }
                            else
                            {
                                focusNode = focusNode.rightNode;
                            }
                        }
                    }
                }
            }

        }

        public void Search()
        {

        }
    }
}
