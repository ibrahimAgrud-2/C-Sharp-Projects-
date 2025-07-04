using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_List_with_C_
{
    public partial class frmAddTask : Form
    {
        public frmAddTask()
        {
            InitializeComponent();
        }
        private void frmAddTask_Load(object sender, EventArgs e)
        {
            cbPriority.SelectedIndex = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddTask.Text))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;

            }
        }


        public  void fillTaskInfoForUpdate(Form1.stTaskInfo task)
        {
            txtAddTask.Text = task.taskName;
            dpDate.Value = Convert.ToDateTime(task.taskEndDate);
            dpTime.Value = Convert.ToDateTime(task.taskEndTime);
            cbPriority.Text = task.priority;


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            Form1.currentTask.taskName = txtAddTask.Text;
            Form1.currentTask.taskEndDate = dpDate.Value.ToString("MM/dd/yyyy");
            Form1.currentTask.taskEndTime= dpTime.Value.ToString("HH:mm:ss ");
            Form1.currentTask.priority = cbPriority.SelectedIndex.ToString();

            
            btnAdd.Enabled = false;


            this.Close();
        }

     
    }
}
