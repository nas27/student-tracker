/**
 *C# Final Project
 *
 * Note  table must have primary key otherwise we cannot use the automated classes. 
 * 
 * ToDo: look at variable types in database table
 * finish data validation for all keypress events
 * change connection string for your machine's path
 * Add filting/sorting functionality
 * display a report of the data or something?
 * etc.
 * 
 * 
 *  Christopher *Nastasia *Bilal *Paul *Tyshaun
 **/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        private bool insertMode = true; //true for insert mode and false for update/delete
        private char status = 'b';    //field 'complete' sort variable- 'b' for Y & N, 'y' for Y and 'n' for N
        private string courseFilter = "All";   //selected course for filtering purposes
        private int changeCounts = 0;   //keeps the change count (insert, update, delete)
        private DateTime dt;            //date object

        //form load
         private void Form1_Load(object sender, EventArgs e)
        {
             getData();
             dg1.Click +=dg1_Click;
             for (int i = 0; i < dg1.Columns.Count; i++)
             {
                dg1.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
             }

             formatGridView();

             setControlState("i");
             txtCourse.KeyPress += txtCourse_KeyPress;
             txtDateDue.KeyPress += txtDateDue_KeyPress;
             txtDateStart.KeyPress += txtDateStart_KeyPress;
             txtDateStart.GotFocus += txtDateStart_GotFocus;
             txtPriority.KeyPress += txtImportance_KeyPress;
             txtComplete.KeyPress += txtComplete_KeyPress;

             dt = DateTime.Today;
             lblTodayDate.Text = dt.ToString("yyyy/MM/dd"); //set today's date on label

             getComboCourseData();   //populate comboBox
        }

         void formatGridView()
         {
             dg1.Columns[1].HeaderText = "COURSE";
             dg1.Columns[2].HeaderText = "Item Name";
             dg1.Columns[3].HeaderText = "Description";
             dg1.Columns[3].Width = 200;
             dg1.Columns[4].HeaderText = "Completed";
             dg1.Columns[4].Width = 60;
             dg1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dg1.Columns[5].HeaderText = "Priority";
             dg1.Columns[5].Width = 55;
             dg1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dg1.Columns[6].HeaderText = "Start Date";
             dg1.Columns[6].Width = 80;
             dg1.Columns[7].HeaderText = "End Date";
             dg1.Columns[7].Width = 80;
         }


        void dg1_Click(object sender, EventArgs e)
        {
            rowIndex = dg1.CurrentRow.Index;

            //align rowIndex with the index of the selection in DataSet
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (dg1.CurrentRow.Cells[0].Value.ToString().Equals(ds.Tables[0].Rows[i][0].ToString()))
                    {
                        rowIndex = i;
                        break;
                    }
                }
            }
            dg1.CurrentRow.Selected = true;
            txtComplete.Text = dg1.CurrentRow.Cells[4].Value.ToString();
            txtItemName.Text = dg1.CurrentRow.Cells[2].Value.ToString();
            txtCourse.Text = dg1.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dg1.CurrentRow.Cells[3].Value.ToString();
            txtPriority.Text = dg1.CurrentRow.Cells[5].Value.ToString();
            txtDateStart.Text = dg1.CurrentRow.Cells[6].Value.ToString();        
            txtDateDue.Text = dg1.CurrentRow.Cells[7].Value.ToString();            
            
            //lblRowIndex.Text = "rowIndex" + rowIndex;
            //lblRowState.Text = "Row State = " + ds.Tables[0].Rows[rowIndex].RowState;  //can also type table name
            setControlState("u/d"); 

        }

        private void getData()
        {
            //Change this for your machine --CDC
            string connstr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Nastasia\\Documents\\Visual Studio 2013\\Projects\\FinalProject_2\\FinalProject\\FinalProject\\Database1.mdf;Integrated Security=True";
            
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string complete = "";   //sql append for complete filter
                string course = "";     //sql append for course filter
                if (status == 'b')
                {
                    complete = "";
                }
                else if (status == 'y')
                {
                    complete = " where [complete] = 'Y'";
                }
                else if (status == 'n')
                {
                    complete = " where [complete] = 'N'";
                }
                string sql = "SELECT * from [tStudents]" + complete;

                if (status == 'b' && !courseFilter.Equals("All"))
                {
                    course = " where [course] = '" + courseFilter + "'";
                }
                else if (!courseFilter.Equals("All"))
                {
                    course = "AND [course] = '" + courseFilter + "'";
                }
                else
                {
                    course = "";
                }

                sql = sql + course;

                da = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "tStudents");
                conn.Close();
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "tStudents";
                dg1.DataSource = bindingSource1;
                dg1.Columns["Serial#"].Visible = false; //hide column Serial#
                dg1.ClearSelection();
                clearText();
                changeFilterState(true);
                btnUndo.Enabled = false;
                insertMode = true;
                setControlState("i");
                changeCounts = 0;
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error reading data");
            }


        }

        private void getComboCourseData()
        {
            comboCourse.Items.Clear();
            comboCourse.Items.Insert(0, "All");     //inserting the first item
            string val = "";    //course string variable
            int j = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)   //loop through all rows of dataSet
            {
                DataRow dr = ds.Tables[0].Rows[i];      //grab a row
                val = dr["course"].ToString();          //store course string
                if (!comboCourse.Items.Contains(val))   //to avoid multiple identical entries
                {
                    comboCourse.Items.Insert(j + 1, val);   //insert course
                }
            }
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseFilter = comboCourse.Items[comboCourse.SelectedIndex].ToString(); //grab the selected item
            getData();  //get filtered data
        }

        private void setControlState(string state)
        {
            if (state.Equals("i"))
            {
                cmdInsert.Text = "Insert";
                insertMode = true;
                cmdInsert.Enabled = true;
                cmdUpdate.Enabled = false;
                cmdDelete.Enabled = false;
                lblWarning.Text = "";
                clearText();
            }
            else if (state.Equals("u/d"))
            {
                cmdInsert.Text = "<< Insert Mode";
                lblWarning.Text = "Warning: Returning to 'insert mode' will discard changes made in text boxes";
                insertMode = false;
                cmdUpdate.Enabled = true;
                cmdDelete.Enabled = true;
            }
        }


        private void clearText()
        {
            txtComplete.Text = "";
            txtItemName.Text = "";
            txtCourse.Text = "";
            txtPriority.Text = "";
            txtDateStart.Text = "";
            txtDateDue.Text = "";
            txtDescription.Text = "";

            dg1.ClearSelection();
        }



        public Form1()
        {
            InitializeComponent();
            txtCourse.ContextMenuStrip = new ContextMenuStrip();
            txtPriority.ContextMenuStrip = new ContextMenuStrip();
            txtItemName.ContextMenuStrip = new ContextMenuStrip();
            txtDateDue.ContextMenuStrip = new ContextMenuStrip();
            txtComplete.ContextMenuStrip = new ContextMenuStrip();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUndo_Click(object sender, EventArgs e)  //simply reset data from database
        {
            if (MessageBox.Show("Are you sure you want to undo all changes made?", "Confirm Undo Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                getData();
            }
        }

        private void cmdUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int updateRows = da.Update(ds, "tStudents");
                conn.Close();
                //lblUpdatedRows.Text = "Updated rows = " + updateRows;

                courseFilter = "All";   //set courseFilter to default
                getData();

                changeFilterState(true);

                getComboCourseData();   //populate comboBox
            }

            catch (SqlException ex) 
            {
                if(conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error updating database");
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                ds.Tables[0].Rows[rowIndex].Delete();
            }
            setControlState("i");

            changeFilterState(false);   //disabling filter options
            btnUndo.Enabled = true;
            changeCounts++;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {

            if (dataGood()) 
            {
                if (isValidAcount("u"))
                {
                    DataRow dr = ds.Tables[0].Rows[rowIndex];

                    if (!(txtComplete.Text.Length > 0))
                    {
                        dr["complete"] = "N";
                    }
                    else
                    {
                        dr["complete"] = txtComplete.Text;
                    }
                    dr["itemName"] = txtItemName.Text;
                    dr["course"] = txtCourse.Text;
                    dr["description"] = txtDescription.Text;
                    dr["priority"] = txtPriority.Text;
                    dr["dateStart"] = txtDateStart.Text;
                    dr["dateDue"] = txtDateDue.Text;
                }
                setControlState("i");
            }
            changeFilterState(false);
            btnUndo.Enabled = true;
            changeCounts++;
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            
            if (dataGood() && insertMode)
            {
                if (isValidAcount("i"))
                {
                    //REVIEW DATA TYPES --CDC
                    DataRow dr = ds.Tables["tStudents"].NewRow();
                    
                    if (!(txtComplete.Text.Length > 0))
                    {
                        dr["complete"] = "N";
                    }
                    else
                    {
                        dr["complete"] = txtComplete.Text;
                    }
                    dr["itemName"] = txtItemName.Text;
                    dr["course"] = txtCourse.Text;
                    dr["description"] = txtDescription.Text;
                    dr["priority"] = txtPriority.Text;
                    dr["dateStart"] = txtDateStart.Text;
                    dr["dateDue"] = txtDateDue.Text;
                    ds.Tables["tStudents"].Rows.Add(dr);
                    clearText();
                    btnUndo.Enabled = true;
                    changeCounts++;
                }
            }
            else if (!insertMode)    //to return to insert mode
            {
                setControlState("i");
            }

            if (changeCounts > 0)
            {
                changeFilterState(false);
            }
        }

        private bool isValidAcount(string state)
        {
            if (state.Equals("i"))
            {
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    if (txtItemName.Text.Equals(dg1.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("The account exists, enter a new account number.", "Primary Key Violation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            else if (state.Equals("u"))
            {
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    if (i != dg1.CurrentRow.Index)
                    {
                        if (txtItemName.Text.Equals(dg1.Rows[i].Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("The account exists, enter a new account number.", "Primary Key Violation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }


            }
            return true;
        }

        private bool dataGood()
        {
            
            if (txtCourse.Text.Length < 1)
            {
                MessageBox.Show("Course field can not be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return false;
            }
            if (txtItemName.Text.Length < 1)
            {
                MessageBox.Show("Item name can not be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }
            if (txtPriority.Text.Length < 1)
            {
                MessageBox.Show("Priority entry is mandatory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPriority.Focus();
                return false;
            }
            return true;
        }

        // enables/disables filer options
        private void changeFilterState(bool state)
        {
            radBoth.Enabled = state;
            radY.Enabled = state;
            radN.Enabled = state;
            comboCourse.Enabled = state;
            if (!state)
            {
                lblCompStatus.Text = "";
                lblCourseFilter.Text = "Changes must be updated to the database or undo before Filters can be used";
                lblCourseFilter.ForeColor = Color.DarkRed;
            }
            else
            {
                lblCourseFilter.Text = "Course Filter";
                lblCompStatus.Text = "Complete Status";
                lblCourseFilter.ForeColor = Color.Black;
            }
        }

        void txtComplete_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;
            if (c != 8)
            {
                if (c > 96 && c < 123)// bring it to upper case
                {
                    if (c == 110) //only if it is y or n
                    {
                        e.KeyChar = (char)(c - 32);
                    }
                    else if (c == 121)
                    {
                        e.KeyChar = (char)(c - 32);
                    }
                    else
                        e.Handled = true;
                }
                else if (len <= 1 && (c != 78 && c != 89))
                {
                    e.Handled = true;
                }
                if (len >= 1)
                {
                    e.Handled = true;
                }

            }
        }

        void txtImportance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8) //not a backspace
            {
                if (c > 57 || c < 48) //if c is not a number
                {
                    e.Handled = true;
                }
            }

        }

        void txtDateStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //format of YYYY/MM/DD
            char c = e.KeyChar;
            int len = txtDateStart.Text.Length;
            ((TextBox)sender).SelectionStart = len;
            string mydate = txtDateStart.Text.ToString();

            if (c != 8) // not a backspace
            {

                if (c > 57 || c < 48) //if c is not a number
                {
                    e.Handled = true;

                }

                if (len == 4 || len == 7) // if the length is either 4 or 7
                {
                    txtDateStart.AppendText("/");
                }

                if (len == 4 || len == 5)      //  to make sure the date is less than or equal to 12
                {
                    if (c != 48 && c != 49)
                    {
                        e.Handled = true;
                    }
                }
                if (len == 6)
                {
                    if (mydate[5] == '1' && c > 50)        //to make sure month would not go over 12
                    {
                        e.Handled = true;
                    }
                    else if (mydate[5] == '0' && c == 48)  //to make sure '00' can not be entered
                    {
                        e.Handled = true;
                    }
                }

                if ((len == 7 || len == 8) && c > 51) // to make sure the date is less than or equal to 31
                {
                    e.Handled = true;
                }
                if (len == 9)
                {
                    if (mydate[8] == '3' && c > 49)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtDateDue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //format of YYYY/MM/DD
            char c = e.KeyChar;
            int len = txtDateDue.Text.Length;
            ((TextBox)sender).SelectionStart = len;
            string mydate = txtDateDue.Text.ToString();
            if (c != 8) // not a backspace
            {

                if (c > 57 || c < 48) //if c is not a number
                {
                    e.Handled = true;

                }

                if (len == 4 || len == 7) // if the length is either 4 or 7
                {
                    txtDateDue.AppendText("/");

                }

                if (len == 4 || len == 5)      //  to make sure the date is less than or equal to 12
                {
                    if (c != 48 && c != 49)
                    {
                        e.Handled = true;
                    }
                }
                if (len == 6)
                {
                    if (mydate[5] == '1' && c > 50)         //to make sure month would not go over 12
                    {
                        e.Handled = true;
                    }
                    else if (mydate[5] == '0' && c == 48)   //to make sure '00' can not be entered
                    {
                        e.Handled = true;
                    }
                }

                if ((len == 7 || len == 8) && c > 51) // to make sure the date is less than or equal to 31
                {
                    e.Handled = true;
                }
                if (len == 9)
                {
                    if (mydate[8] == '3' && c > 49)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            //first 4 letters  last 5 numbers  ex. PROG33921 
            char c = e.KeyChar;
            int len = txtCourse.Text.Length;
            txtCourse.SelectionStart = len;
            if (c != 8)
            {
                if (len > 9)
                {
                    e.Handled = true;
                }
                else if (len < 4 && (c > 96 && c < 123))
                {
                    //first 4 chars are lower case then it has to be capitalized
                    e.KeyChar = (char)(c - 32);
                }
                else if (len < 4 && (c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    //first 4 chars cant be a number
                    e.Handled = true;
                }

                if (len >= 4 && (c < 48 || c > 57)) //last 5 digits must be numbers
                {
                    e.Handled = true;
                }
            }
        }

        void txtDateStart_GotFocus(object sender, EventArgs e)
        {
            if (insertMode)
            {
                setStartDate();
            }
        }

        private void setStartDate()
        {
            txtDateStart.Text = dt.ToString("yyyy/MM/dd");
        }

        private void radBoth_CheckedChanged(object sender, EventArgs e)
        {
            status = 'b';
            getData();
        }

        private void radY_CheckedChanged(object sender, EventArgs e)
        {
            status = 'y';
            getData();
        }

        private void radN_CheckedChanged(object sender, EventArgs e)
        {
            status = 'n';
            getData();
        }


        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblDateDue_Click(object sender, EventArgs e)
        {

        }

        private void txtPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {

        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void txtDateStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateDue_TextChanged(object sender, EventArgs e)
        {

        }


       
    }
}
