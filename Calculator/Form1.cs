using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // GLOBAL VARIABLES THAT ALLOWS US TO KEEP TRACKING WHAT'S GOING ON
        private Stack<List<string>> HST_Operations = new Stack<List<string>>();
        private List<string> Operation = new List<string>();
        private List<string> Postfix = new List<string>();
        private double Answer = 0;
        private uint parenthesis = 0;

        // STARTING THE CALCULATOR
        public Form1()
        {
            InitializeComponent();
        }

        // SOME NEEDED FUNCTIONS FROM A LIST
        private string lastItem()
        {
            if (Operation.Count > 0)
                return Operation[Operation.Count - 1];

            return "";
        }
        private float value(string str)
        {
            if(float.TryParse(str, out float result))
                return result;

            return 0;
        }

        // CHECK FOR SOME DEFINITIONS
        private bool isEmpty()
        {
            return Operation.Count == 0;
        }
        private bool isLastItemNumber()
        {
            if(!isEmpty())
                return float.TryParse(lastItem(), out _);

            return false;
        }
        private bool isLastItemOperator()
        {
            string item;

            if (!isEmpty())
                item = lastItem();
            else
                return false;

            return item == "+" || item == "-" || item == "x" || item == "/" || item == "%" || item == "^";
        }
        private bool isLastItemOpenPar()
        {
            if (!isEmpty())
                return lastItem() == "(";
            return false;
        }
        private bool isLastItemClosePar()
        {
            if (!isEmpty())
                return lastItem() == ")";
            return false;
        }
        private bool isLastItemDot()
        {
            if (!isEmpty())
                return lastItem() == ".";

            return false;
        }

        // Compressed 4 items in one item
        private void updateResult(double Result, byte index)
        {
            Postfix[index - 2] = Result.ToString();

            Postfix.RemoveAt(index);
            Postfix.RemoveAt(index - 1);

        }
        private double CalculateTwoOperands(double left, double right, char Operator)
        {
            switch(Operator)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case 'x':
                    return left * right;
                case '/':
                    return left / right;
                case '%':
                    return left % right;
                case '^':
                    return Math.Pow(left, right);
                default: return 0;
            }
        }
        private void compressToNegativeItem(sbyte start_index)
        {
            // Get only the negative and the number
            string new_item = Operation[start_index + 1] + Operation[start_index + 2];

            // Remove the four items
            for (sbyte i = start_index; i <= start_index + 3; i++)
            { Operation.RemoveAt(start_index); }

            // Add the new_item to the list
            Operation.Insert(start_index, new_item);
        }
        // Check the precedence operators
        private bool higherPrecedence(string current_op, string top_stack)
        {
            if (current_op == "^" && top_stack != "^")
                return true;

            if((current_op == "x" ||  current_op == "/" || current_op == "%") && (top_stack == "+" || top_stack == "-"))
                return true;

            return false;
        }
        private bool isOperator(string op)
        {
            return op == "+" || op == "-" || op == "x" || op == "/" || op == "%" || op == "^";
        }

        // Execute The Equal Sign
        private void replaceNegativeNumbers()
        {
            for(sbyte i = 0; i < Operation.Count; i++)
            {
                if (Operation[i] == "(" && (i + 3) < Operation.Count)
                {
                    if (Operation[i + 1] == "-" && (float.TryParse(Operation[i + 2], out _)) && Operation[i + 3] == ")")
                    {
                        compressToNegativeItem(i);
                        i = -1;
                    }
                }
            }
        }
        private List<string> convertInfixToPostfix()
        {
            Stack<char> operators = new Stack<char>();
            List<string> Postfix = new List<string>();

            for(sbyte i = 0; i < Operation.Count; i++)
            {
                if (Operation[i] == "(")
                {
                    parenthesis++;
                    operators.Push(Convert.ToChar(Operation[i]));
                    continue;
                }

                if(isOperator(Operation[i]) && parenthesis != 0)
                {
                    while(operators.Peek() != '(')
                    {
                        if(!higherPrecedence(Operation[i], Convert.ToString(operators.Peek())))
                        {
                            Postfix.Add(Convert.ToString(operators.Pop()));
                            continue;
                        }

                        break;
                    }

                    operators.Push(Convert.ToChar(Operation[i]));
                    continue;
                }

                if (float.TryParse(Operation[i], out _))
                {
                    Postfix.Add(Operation[i]);
                    continue;
                }

                if (Operation[i] == ")")
                {
                    while (operators.Peek() != '(')
                        Postfix.Add((Convert.ToString(operators.Pop())));

                    operators.Pop();
                    parenthesis--;
                    continue;
                }

                if(!operators.Any() || higherPrecedence(Operation[i], Convert.ToString(operators.Peek())))
                    operators.Push(Convert.ToChar(Operation[i]));
                else
                {
                    while (true)
                    {
                        if (operators.Any())
                            if (!higherPrecedence(Operation[i], Convert.ToString(operators.Peek())))
                            {
                                Postfix.Add(Convert.ToString(operators.Pop()));
                                continue;
                            }

                        operators.Push(Convert.ToChar(Operation[i]));
                        break;
                    }
                }
               
            }

            while (operators.Any())
                Postfix.Add(Convert.ToString(operators.Pop()));

            return Postfix;
        }

        private double calculateResult()
        {
            double result;
            byte index = 0;

            while(index < Postfix.Count)
            {
                if (isOperator(Postfix[index]))
                {
                    result = CalculateTwoOperands(Convert.ToDouble(Postfix[index - 2]), Convert.ToDouble(Postfix[index - 1]), Convert.ToChar(Postfix[index]));
                    updateResult(result, index);
                    index--;
                    continue;
                }

                index++;
            }

            return Convert.ToDouble(Postfix.Last());

        }
        
        // UPDATE THE SCREEN TO THE USER IN EVERY EXECUTION
        private void updateScreen()
        {
            Result.Tag = string.Join(" ", Operation);

            int start_index = Convert.ToString(Result.Tag).Length - 18;

            if ((Convert.ToString(Result.Tag).Length - 18) <= 0)
                start_index = 0;

            Result.Text = Convert.ToString(Result.Tag).Substring(start_index);
        }
        private void updateOperation(string item, bool Single_item = true, bool sqrt = false)
        {
            if (item == "." && lastItem().IndexOf(".") != -1)
                return;

            if (sqrt)
            {
                Operation[Operation.Count - 1] = Convert.ToString(Math.Sqrt(value(item)));
                return;
            }

            if (Single_item)
                Operation.Add(item);
            else
                Operation[Operation.Count - 1] += item;
        }
        private void updateCalculator(string item, bool Single_item = true, bool sqrt = false)
        {
            updateOperation(item, Single_item, sqrt);
            updateScreen();
        }
        
        // EXECUTING WHAT THE USER WANT IN A CORRECT WAY
        private void Add_Number(Button digit)
        {
            if (isEmpty() || isLastItemOpenPar() || isLastItemOperator())
            {
                updateCalculator(Convert.ToString(digit.Tag));
                return;
            }

            if (isLastItemDot() || isLastItemNumber())
            {
                updateCalculator(Convert.ToString(digit.Tag), false);
                return;
            }
        }
        private void Add_Dot()
        {
            if (isLastItemNumber())
                updateCalculator(Convert.ToString(Dot.Tag), false);
            else if (isLastItemDot() || isLastItemClosePar())
                return;
            else
                updateCalculator("0" + Convert.ToString(Dot.Tag));
        }
        private void Add_SquareRoot()
        {
            if (isLastItemOpenPar() || isEmpty() || isLastItemOperator())
                updateCalculator("0");
            else if(isLastItemNumber())
            {
                if(value(lastItem()) >= 0)
                    updateCalculator(lastItem(), true, true);
                else
                    MessageBox.Show("CANNOT SQUARE A NEGATIVE NUMBER", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_Operator(Button op)
        {
            if (isLastItemNumber() || isLastItemClosePar() || (isLastItemOpenPar() && Convert.ToString(op.Tag) == "-"))
                updateCalculator(Convert.ToString(op.Tag));   
        }
        private void Add_OpenParenthesis()
        {
            if (isEmpty() || isLastItemOperator() || isLastItemOpenPar())
            {
                updateCalculator(OpenPar.Tag.ToString());
                parenthesis++;
            }
        }
        private void Add_CloseParenthesis()
        {
            if ((parenthesis != 0) && isLastItemNumber())
            {
                updateCalculator(ClosePar.Tag.ToString());
                parenthesis--;
            }
        }

        // WHEN USER PRESS ON BUTTONS
        private void Number_Click(object sender, EventArgs e)
        {
            Add_Number((Button)sender);
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Result.Tag = string.Empty;

            Operation.Clear();
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            Add_Dot();
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Add_Operator((Button)sender);
        }
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            Add_SquareRoot();
        }
        private void OpenPar_Click(object sender, EventArgs e)
        {
            Add_OpenParenthesis();
        }
        private void ClosePar_Click(object sender, EventArgs e)
        {
            Add_CloseParenthesis();
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                if(isLastItemClosePar())
                    parenthesis++;
                else if(isLastItemOpenPar())
                    parenthesis--;

                Operation.RemoveAt(Operation.Count - 1);
                updateScreen();
            }
        }
        private void History_Click(object sender, EventArgs e)
        {
            if (HST_Operations.Any())
            {
                Operation = HST_Operations.Pop();
                updateScreen();
            }
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            if (parenthesis == 0 && !isLastItemOperator() && !isEmpty())
            {
                // 1- REplace the (, -, number, ) to a single item
                replaceNegativeNumbers();
                // 2- Convert the Operation to another list with Postfix Form
                Postfix = convertInfixToPostfix();
                // 3- Calculate the Postfix form
                Answer = calculateResult();
                // 4- Add this operation to the history operation
                HST_Operations.Push(Operation);
                // 5- Update Screen by the result
                Result.Text = Answer.ToString();
                Result.Tag = Result.Text.ToString();
                Operation = new List<string>();
            }
        }
    }
}
