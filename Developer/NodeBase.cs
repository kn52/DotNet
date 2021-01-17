using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        AbsoluteValue
    }
    public abstract class NodeBase
    {
    }

    public class NumberNode : NodeBase
    {
        public int Value;
    }
    public class BinaryOperatorNode : NodeBase
    {
        public NodeBase Left;
        public NodeBase Right;
        public Operator Operator;
    }

    public class NodeBaseRoot : NodeBase
    {
        NodeBase node;
        NumberNode value;
        BinaryOperatorNode op;
        BinaryOperatorNode binaryOperatorNode = new BinaryOperatorNode();
        NumberNode numberNode = new NumberNode();

        public NodeBaseRoot(NumberNode value, BinaryOperatorNode op)
        {
            this.value = value;
            this.op = op;
        }

        public void CalExpressionTree()
        {
            eval(new NodeBaseRoot(numberNode, binaryOperatorNode));
        }

        public static int eval(NodeBaseRoot root)
        { 
            if (root == null)
                return 0;
            if (root.binaryOperatorNode.Left != null && root.binaryOperatorNode.Right != null)
                return root.numberNode.Value;

            int leftRoot = eval((NodeBaseRoot) root.binaryOperatorNode.Left);
            int rightRoot = eval((NodeBaseRoot) root.binaryOperatorNode.Right);

            if (root.binaryOperatorNode.Operator == Operator.Add)
                return leftRoot + rightRoot;
            if (root.binaryOperatorNode.Operator == Operator.Subtract)
                return leftRoot - rightRoot;
            if (root.binaryOperatorNode.Operator == Operator.Multiply)
                return leftRoot * rightRoot;

            return leftRoot / rightRoot;
        }
    }
}
