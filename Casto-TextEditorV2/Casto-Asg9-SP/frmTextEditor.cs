using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_Asg9_SP
{
    public partial class frmTextEditor : Form
    {
        public frmTextEditor()
        {
            InitializeComponent();
        }
        //declaring my stacks
        Stack<String> redoStack = new Stack<string>();
        Stack<String> undoStack = new Stack<string>();

        //method for getting the strings from the file and converting 
        //it into an array
        private String[] getStringArrayFromData()
        {
            String[] arrayString;
            String temp = textBoxData.Text;
            temp = temp.Replace("\r\n", "\n");
            arrayString = temp.Split('\n');
            return arrayString;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            getStringArrayFromData();
            buttonRedo.Enabled = false;
            buttonUndo.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            String originalText = textBoxData.Text;
            if (originalText != "")
                pushToUndoStack(originalText);

            textBoxData.Clear();
            
        }

        private void buttonAddText_Click(object sender, EventArgs e)
        {
            //string to hold original text to later be compared to the 
            //updated text. If the text is the same, we will not
            //be updating the undo stack
            String originalText = textBoxData.Text;
            //declaring my array and strings to add to the lines
            //in the array
            String[] arrayString = getStringArrayFromData();
            String prefix = textBoxInputBeginning.Text + "";
            String postfix = textBoxInputEnd.Text + "";
            String tempString = "";

            //looping through the array and adding each "fix" to it
            foreach (String line in arrayString)
            {
                tempString = tempString + prefix + line + postfix + Environment.NewLine;
            }
            //remving the CRLF
            if (tempString.EndsWith(Environment.NewLine))
            {
                tempString = tempString.Substring(0, tempString.Length - 2);
            }
            textBoxData.Text = tempString;
            if (tempString != originalText)
                pushToUndoStack(originalText);

        }

        private void buttonAsc_Click(object sender, EventArgs e)
        {

            //loading the array into a list, search the list, and then load the 
            //list back into the textbox
            String[] arrayString = getStringArrayFromData();
            Array.Sort(arrayString, StringComparer.InvariantCulture);
            String temp = "";//to hold the list until it's back in the box

            //checking for duplicates if the box is checked
            if (checkBoxNoDupes.Checked)
            {
                arrayString = arrayString.Distinct().ToArray();
            }

            foreach (String line in arrayString)
            {
                temp += line + Environment.NewLine;
            }
            //removing the last CRLF
            if (temp.EndsWith(Environment.NewLine))
            {
                temp = temp.Substring(0, temp.Length - 2);
            }
            textBoxData.Text = temp;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            String originalText = textBoxData.Text;
            //variables for holding the temp string, the search string,
            //and the replace string that holds the changed values
            String[] arrayString = getStringArrayFromData();

            String temp = textBoxData.Text + "";
            String find = textBoxSearch.Text + ""; ;
            String replace = textBoxReplace.Text + ""; ;

            //  FIND:  Look for special chars
            if (find.IndexOf("[CRLF]") > -1)
                find = find.Replace("[CRLF]", Environment.NewLine);

            if (find.IndexOf("[TAB]") > -1)
                find = find.Replace("[TAB]", "\t");

            // REPLACE:  Look for special chars
            if (replace.IndexOf("[CRLF]") > -1)
                replace = replace.Replace("[CRLF]", Environment.NewLine);

            if (replace.IndexOf("[TAB]") > -1)
                replace = replace.Replace("[TAB]", "\t");




            // Prevent crash if find = ""
            if (find.Length > 0)
            {
                temp = temp.Replace(find, replace);
                textBoxData.Text = temp;
            }
            else
            {
                MessageBox.Show("Please enter something to search");
            }
            if (temp != originalText)
                pushToUndoStack(originalText);
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            //same as before. load the data into a list, reorder it,
            //and then put it back into the text box
            String[] arrayString = getStringArrayFromData();
            Array.Sort(arrayString, StringComparer.InvariantCulture);
            Array.Reverse(arrayString);

            //checking for duplicates if the box is checked
            if (checkBoxNoDupes.Checked)
            {
                arrayString = arrayString.Distinct().ToArray();
            }

            String temp = "";
            foreach (String line in arrayString)
            {
                temp += line + Environment.NewLine;
            }
            //removing the last CRLF
            if (temp.EndsWith(Environment.NewLine))
            {
                temp = temp.Substring(0, temp.Length - 2);
            }
            textBoxData.Text = temp;
        }

        private void buttonTab_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[TAB]");
        }

        private void buttonCLRF_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[CRLF]");
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxData.Text);
        }

        private void buttonSQLQuotes_Click(object sender, EventArgs e)
        {
            //getting our data and declaring variables
            String[] arrayString = getStringArrayFromData();
            String tempString = "";
            //formatting each line for the quotation marks for sql
            foreach (String line in arrayString)
            {
                tempString += "'" + line + "',";
            }
            //removing the last comma
            tempString = tempString.Remove(tempString.LastIndexOf(','));
            //final formatting that is incorrect I think
            textBoxData.Text = "in(" + tempString + ")";
        }

        private void buttonSQLNoQuotes_Click(object sender, EventArgs e)
        {
            //getting our data and declaring variables
            String[] arrayString = getStringArrayFromData();
            String tempString = "";
            //formatting each line for no quotation marks for sql
            foreach (String line in arrayString)
            {
                tempString += line + ",";
            }
            //removing the last comma
            tempString = tempString.Remove(tempString.LastIndexOf(','));
            //final formatting that is incorrect I think. Unless it is
            //and I'm overthinking this, but pressing either SQL
            //button bricks the editor so to speak
            textBoxData.Text = "in(" + tempString + ")";
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            String originalText = textBoxData.Text;
            String[] arrayString = getStringArrayFromData();
            String tempString = "";
            String find = textBoxFind.Text + "";
            foreach (String line in arrayString)
            {
                if (checkBoxNotMatching.Checked)
                {
                    if (!line.Contains(find))
                    {
                        tempString += line + Environment.NewLine;
                    }
                    
                }
                else
                {
                    if (line.Contains(find))
                    {
                        tempString += line + Environment.NewLine;
                    }
                    
                }
            }
            textBoxData.Text = tempString;
            if (tempString != originalText)
                pushToUndoStack(originalText);
        }
        //pushing and popping stack methods for our undo/redo buttons
        private void pushToUndoStack(String dataToBeAdded)
        {
            buttonUndo.Enabled = false;

            String lastItem = "";
            if (undoStack.Count > 0)
            {
                lastItem = undoStack.Peek();
                buttonUndo.Enabled = true;
            }
            //only adding to the stack if the data is different
            if (lastItem != dataToBeAdded)
            {
                undoStack.Push(dataToBeAdded);
                buttonUndo.Enabled = true;
            }
                
        }
        private void pushToRedoStack()
        {
            String lastItem = "";
            if (redoStack.Count > 0)
            {
                lastItem = redoStack.Peek();
            }
            if (lastItem != textBoxData.Text)
            {
                redoStack.Push(textBoxData.Text);
                buttonRedo.Enabled = true;
            }
        }
        private void loadLastUndoData()
        {
            String lastItem = "";
            if (undoStack.Count > 0)
            {
                lastItem = undoStack.Pop();
                textBoxData.Text = lastItem;
            }
            if (undoStack.Count == 0)
                buttonUndo.Enabled = false;
        }
        private void loadLastRedoData()
        {
            String lastItem = "";
            if(redoStack.Count > 0)
            {
                lastItem = redoStack.Pop();
                textBoxData.Text = lastItem;
            }
            if (redoStack.Count == 0)
                buttonRedo.Enabled = false;
        }
        private void buttonRedo_Click(object sender, EventArgs e)
        {
            pushToUndoStack(textBoxData.Text);
            loadLastRedoData();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            pushToRedoStack();
            loadLastUndoData();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            String originalList = textBoxData.Text;
            String[] arrayString = getStringArrayFromData();
            String find = textBoxInputRemove.Text;

            String tempString = "";
            String tempLine = "";
            int index = 0;


            if (checkBoxRemoveAfter.Checked)
            {
                foreach (String line in arrayString)
                {
                    if (line.Contains(find))
                    {
                        //this part of the code is removing the text AFTER
                        //the character we find so we only need the code leading 
                        //to the character
                        index = line.LastIndexOf(find);
                        tempLine = line.Substring(0, index);
                        //piece the monstrocity back together
                        tempString = tempString + tempLine + Environment.NewLine;

                           
                    }
                    else
                    {
                        //this is a nonmatching line so we need to add it unchanged
                        tempString = tempString + line + Environment.NewLine;
                    }
                }//end of the foreach statement
            }
            else//else statement for checkboxremove not being checked
            {
                foreach (String line in arrayString)
                {
                    if (line.Contains(find))
                    {
                        //we are removing the text before the find character
                        //in the line in this part of the code
                        index = line.LastIndexOf(find);
                        tempLine = line.Substring(index + 1);

                        tempString = tempString + tempLine + Environment.NewLine;
                    }
                    else
                    {
                        tempString = tempString +  line + Environment.NewLine;
                    }
                }//end of foreach statement 
            }//end of the else statement for checkbox remove after not being checked
            if (tempString.Contains(Environment.NewLine))
            {
                tempString = tempString.Substring(0, tempString.Length - 2);
                textBoxData.Text = tempString;
            }

            //textBoxData.Text = tempString;
            if (tempString != originalList)
                pushToUndoStack(originalList);
        }
    }
}
