using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class scores : Form
    {
        /// <summary>
        /// Array for all student names
        /// </summary>
        String[] studentNames;

        /// <summary>
        /// Array for all assignments and scores
        /// </summary>
        int[,] assignments;

        /// <summary>
        /// Variable for the number of students
        /// </summary>
        int numberStudents;

        /// <summary>
        /// Variable for number of assignments
        /// </summary>
        int numberAssignments;

        /// <summary>
        /// Variable to keep track of which student is currently being altered
        /// </summary>
        int index = 0;

        /// <summary>
        /// Create form and clear the richTextBox if there is anything there
        /// </summary>
        public scores()
        {
            InitializeComponent();
            richTextBox.Clear();
        }

        /// <summary>
        /// The method fills the richTextBox with all of the information of each student and the grades for all the assignments
        /// </summary>
        private void richBox()
        {
            // Clear the previous information from the rich text box
            richTextBox.Clear();

            String tab = "\t";

            // Fill in the header for the rich text box
            richTextBox.Text += String.Format("\tStudent\t\t");
            for (int i = 0; i < numberAssignments; i++)
            {
                richTextBox.Text += String.Format("#" + (i+1).ToString() + "\t");
            }
            richTextBox.Text += String.Format("AVG\t");
            richTextBox.Text += String.Format("Grade");
            // Go to the next line
            richTextBox.Text += Environment.NewLine;
            // Go through for all the students
            for (int i = 0; i < numberStudents; i++)
            {
                // Compute the average
                int assignmentTotal = 0;
                for (int k = 0; k < numberAssignments; k++)
                {
                    assignmentTotal += assignments[i,k];
                }
                double average = Math.Round((assignmentTotal / (double)numberAssignments), 2);
                // Print the name with the spacing depending on how long the name is
                if (studentNames[i].Length <= 7)
                    richTextBox.Text += String.Format(studentNames[i] + tab + tab + tab);
                else if (studentNames[i].Length <= 15)
                    richTextBox.Text += String.Format(studentNames[i] + tab + tab);
                else if (studentNames[i].Length <= 23)
                    richTextBox.Text += String.Format(studentNames[i] + tab);
                else
                    richTextBox.Text += String.Format(studentNames[i]);

                // Print the grade for each assignment
                for (int j = 0; j < numberAssignments; j++)
                {
                    richTextBox.Text += String.Format(assignments[i,j] + tab);
                }
                // Print the average percentage
                richTextBox.Text += String.Format(average + "%" + tab);
                // Call the getGrade method and print the results
                richTextBox.Text += String.Format(getGrade(average));
                // Go to the next line
                richTextBox.Text += Environment.NewLine;
            }
        }

        /// <summary>
        /// Returns the letter grade for the average percent given
        /// </summary>
        /// <param name="average"></param>
        /// <returns></returns>
        public String getGrade(double average)
        {
            // Return the letter grade for the average percent given
            if (average >= 93)
                return "A";
            else if (average >= 90)
                return "A-";
            else if (average >= 87)
                return "B+";
            else if (average >= 83)
                return "B";
            else if (average >= 80)
                return "B-";
            else if (average >= 77)
                return "C+";
            else if (average >= 73)
                return "C";
            else if (average >= 70)
                return "C-";
            else if (average >= 67)
                return "D+";
            else if (average >= 63)
                return "D";
            else if (average >= 60)
                return "D-";
            else
                return "E";
        }

        /// <summary>
        /// Displays the name on the label next to the name text box
        /// </summary>
        public void displayName()
        {
            // Change the label to display the new name
            stuNumLabel.Text = studentNames[index] + ": ";
        }

        /// <summary>
        /// Takes in the counts entered for the amount of assignment and students, verifies that they are valid inputs, and sets the arrays accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitCounts_Click(object sender, EventArgs e)
        {
            // Create temporary variables and read in the input
            String numStu = numStuText.Text;
            String numAssign = numAssignText.Text;

            // Verify the input is good
            if (int.TryParse(numStu, out numberStudents) && numberStudents >= 1 && numberStudents <= 10)
            {
                // Create the array to fit the amount of students
                studentNames = new string[numberStudents];

                // Set the default name for all the students
                for (int i = 0; i < numberStudents; i++)
                {
                    studentNames[i] = "Student #" + (i+1).ToString();
                }

            }else
            {
                // If it's bad input, ask the user to try again
                MessageBox.Show("Please enter a number of students from 1-10", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Clear the textbox
            numStuText.Text = "";
            
            // Check if the input for the number of assignments is good
            if (int.TryParse(numAssign, out numberAssignments) && numberAssignments >= 1 && numberAssignments <= 99)
            {
                // Create the 2d array for the number of assignments/students
                assignments = new int[numberStudents, numberAssignments];

                // Set all assignment grades to 0
                for (int i = 0; i < numberStudents; i++)
                {
                    for (int j = 0; j < numberAssignments; j++)
                    {
                        assignments[i, j] = 0;
                    }
                }
                // Update label to reflect how many assignments there are
                assignNumLabel.Text = "Enter Assignment Number (1-" + numberAssignments.ToString() + "):";
            }
            else
            {
                // Display if the input was bad and ask the user to try again
                MessageBox.Show("Please enter a number of assignments from 1-100", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Clear the textbox
            numAssignText.Text = "";
        }
        
        /// <summary>
        /// Goes to the first student in the list if button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstStuButton_Click(object sender, EventArgs e)
        {
            // Go to first student
            index = 0;
            // Display the name
            displayName();
        }

        /// <summary>
        /// Goes back one student in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevStuButton_Click(object sender, EventArgs e)
        {
            // Make sure it isnt the first student in the list
            if (index > 0)
            {
                index--;
            }
            // Display the name
            displayName();
        }

        /// <summary>
        /// Goes to next student in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextStuButton_Click(object sender, EventArgs e)
        {
            // Make sure it isn't the last student in the list
            if ((index + 1) < numberStudents)
            {
                index++;
            }
            // Display the name
            displayName();
        }

        /// <summary>
        /// Go to the last student in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastStuButton_Click(object sender, EventArgs e)
        {
            // Set index to the last student
            index = numberStudents - 1;
            // Display name
            displayName();
        }

        /// <summary>
        /// Updates the name of the student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveNameButton_Click(object sender, EventArgs e)
        {
            // Take in the name of the student
            studentNames[index] = stuNameText.Text;
            // Display the name
            displayName();
            // Clear the textbox
            stuNameText.Text = "";
        }

        /// <summary>
        /// Saves the score of the assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            // Take in the input
            String tempAssignNum = assignNumText.Text;
            String tempScore = assignScoreText.Text;
            int assignNumber;
            int assignScore;

            // Verify the input is good
            if (int.TryParse(tempAssignNum, out assignNumber) && assignNumber >=1 && assignNumber <= numberAssignments)
            {
                if (int.TryParse(tempScore, out assignScore) && assignScore >= 0 && assignScore <= 100)
                {
                    // Assign the score to the array
                    assignments[(index), assignNumber-1] = assignScore;
                }else
                    // Ask the user to try a different input for the score if it was invalid
                    MessageBox.Show("Please enter a score of 0-100", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
                // Ask the user to try a different input for the assignment number if it was invalide
                MessageBox.Show("Please enter an assignment number from 1-" + numberAssignments.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Clear the textboxes
            assignNumText.Text = "";
            assignScoreText.Text = "";
        }

        /// <summary>
        /// Calls the richbox method to display the information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayScoreButton_Click(object sender, EventArgs e)
        {
            richBox();
        }

        /// <summary>
        /// Resets everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetScores_Click(object sender, EventArgs e)
        {
            // Reset all the variables and clear the richTexBox
            studentNames = new string[0];
            assignments = new int[0,0];
            richTextBox.Clear();
            numberStudents = 0;
            numberAssignments = 0;
            index = 0;
        }
    }
}
