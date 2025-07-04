using System;
using System.Drawing;
using System.Windows.Forms;
using static TO_DO_List_with_C_.Form1;

namespace TO_DO_List_with_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //===================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag.ToString() == "1")
            {
                button1.Text = "v Completed";
                lvCompletedTasks.Visible = true;
                button1.Tag = 0;
            }
            else
            {
                button1.Text = "> Completed";
                lvCompletedTasks.Visible = false;
                button1.Tag = 1;

            }
        }

        //===================================================================






        //===========================GLOBAL VARIABLE======================================
        public struct stTaskInfo
        {
            public  string taskName;
            public string  priority;
            public string taskEndDate;
            public string taskEndTime;
        }

        public static stTaskInfo currentTask=new stTaskInfo();

        enum taskPriority {normal=0,important=1,urgent=2 };
        //===================================================================

        Color setColorPriority(taskPriority priority)
        {
            switch (priority)
            {
                case taskPriority.normal:
                    return Color.Transparent;
                case taskPriority.important:
                    return Color.Orange;
                case taskPriority.urgent:
                    return Color.Red;
                default:
                    return Color.White;
            }
        }

      

        //=================Add new task===========================================


        private void addDataToList(ListView addDataTo,stTaskInfo taskInfo)
        {



            if (string.IsNullOrEmpty(currentTask.taskName))
            {
                return;

            }
            ListViewItem newItem=new ListViewItem();

            newItem.Text=taskInfo.taskName;
            newItem.SubItems.Add(taskInfo.taskEndDate);
            newItem.SubItems.Add(taskInfo.taskEndTime);
          

            if (addDataTo == lvNewTasks)
            {
               
                int index = Convert.ToInt32(taskInfo.priority);
                newItem.BackColor = setColorPriority((taskPriority)index);
              
                newItem.SubItems.Add(((taskPriority)index).ToString());
                lvNewTasks.Items.Add(newItem);
            }
            else if (addDataTo == lvCompletedTasks)
            {
                newItem.BackColor = Color.GreenYellow;
                lvCompletedTasks.Items.Add(newItem);
               

            }
    
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Form addTaskForm = new frmAddTask();
            addTaskForm.ShowDialog();
           
            addDataToList(lvNewTasks, currentTask);
        }

        //===================================================================

        private void lvNewTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (lvNewTasks.CheckedItems.Count <= 0)
            {
                return;
            }
            ListViewItem item = lvNewTasks.CheckedItems[0];

            if (item.Checked)
            {
                stTaskInfo test = new stTaskInfo();

                test.taskName = item.Text;
                test.taskEndDate = item.SubItems[1].Text;
                test.taskEndTime = item.SubItems[2].Text;
                test.priority = item.SubItems[3].Text;
                addDataToList(lvCompletedTasks, test);

                removeITemFormList(lvNewTasks, item);
            }
        }

        void removeITemFormList(ListView list,ListViewItem item)
        {
            if (!list.Items.Contains(item)) { return; }
          
            list.Items.Remove(item);
        
        }



        //=====================Context menu strips============================

        private void unCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvCompletedTasks.SelectedItems.Count<=0)
            {
                return;
            }
            stTaskInfo task=new stTaskInfo();

     
            ListViewItem selectedItem= lvCompletedTasks.SelectedItems[0];
            task.taskName = selectedItem.Text;
            task.taskEndDate=selectedItem.SubItems[1].Text;
            task.taskEndTime = selectedItem.SubItems[2].Text;
            task.priority = selectedItem.SubItems[3].Text;

            addDataToList(lvNewTasks, task);

            removeITemFormList(lvCompletedTasks, selectedItem);
            



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            ContextMenuStrip csm = (ContextMenuStrip)tsm.Owner;

            Control ctrl = csm.SourceControl;

            ListView listView = lvNewTasks;

            if (ctrl == lvNewTasks)
            {
                listView = lvNewTasks;
            }
            else
            {
                listView = lvCompletedTasks;
            }


            if (listView.SelectedItems.Count <= 0)
            {
                return;
            }
            ListViewItem selectedItem = listView.SelectedItems[0];

            removeITemFormList(listView, selectedItem);


        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvNewTasks.SelectedItems.Count<=0)
            {
                return;
            }
          ListViewItem item=lvNewTasks.SelectedItems[0];
            item.Checked = true;
        }
        //===================================================================


        //==========================UPDATE==============================
        stTaskInfo convertItemToTaskStruct(ListViewItem item)
        {
            stTaskInfo taskInfo = new stTaskInfo();
            if (string.IsNullOrEmpty(item.Text))
            {
                return taskInfo;
            }

            taskInfo.taskName = item.Text;
            taskInfo.taskEndDate = item.SubItems[1].Text;
            taskInfo.taskEndTime= item.SubItems[2].Text;
            taskInfo.priority = item.SubItems[3].Text;

            return taskInfo;

        }
     
        private void updateTaskToolStrip(object sender, EventArgs e)
        {

            if (lvNewTasks.SelectedItems.Count <= 0)
            {
                return;
            }
            ListViewItem item = lvNewTasks.SelectedItems[0];

            Form addTaskForm = new frmAddTask();
            addTaskForm.ShowDialog();
            item.Text = currentTask.taskName;
            item.SubItems[1].Text= currentTask.taskEndDate;
            item.SubItems[2].Text = currentTask.taskEndTime;
            int index = Convert.ToInt32(currentTask.priority);
            item.SubItems[3].Text = ((taskPriority)index).ToString();
            
            item.BackColor = setColorPriority((taskPriority)index);

         
        }

        //===================================================================

    }
}
