using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Lab_02_Ex_03
{
    //Exception Handling Done

    public partial class CourseExplorer : Form
    {
        public CourseExplorer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void courseListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (courseTreeView.SelectedNode.Text == "SETechnician")
                {
                    courseListView.Items.Clear();
                    //
                    ListViewItem listViewItem = new ListViewItem("Semester-1");
                    listViewItem.SubItems.Add("COMP100");
                    listViewItem.SubItems.Add("COMP120");
                    listViewItem.SubItems.Add("COMP122");
                    listViewItem.SubItems.Add("COMP219");
                    listViewItem.SubItems.Add("MATH175");
                    listViewItem.SubItems.Add("COMM170");
                    courseListView.Items.Add(listViewItem);
                    //
                    ListViewItem listViewItem2 = new ListViewItem("Semester-2");
                    listViewItem2.SubItems.Add("COMP123");
                    listViewItem2.SubItems.Add("COMP213");
                    listViewItem2.SubItems.Add("COMP301");
                    listViewItem2.SubItems.Add("COMP225");
                    listViewItem2.SubItems.Add("GNED135");
                    listViewItem2.SubItems.Add("MATH175");
                    courseListView.Items.Add(listViewItem2);
                    //
                    ListViewItem listViewItem3 = new ListViewItem("Semester-3");
                    listViewItem3.SubItems.Add("COMP214");
                    listViewItem3.SubItems.Add("COMP228");
                    listViewItem3.SubItems.Add("COMP229");
                    listViewItem3.SubItems.Add("COMP246");
                    listViewItem3.SubItems.Add("ENGL253");
                    listViewItem3.SubItems.Add("GNED500");
                    courseListView.Items.Add(listViewItem3);
                    //
                    ListViewItem listViewItem4 = new ListViewItem("Semester-4");
                    listViewItem4.SubItems.Add("CNET124");
                    listViewItem4.SubItems.Add("CNET329");
                    listViewItem4.SubItems.Add("COMP212");
                    listViewItem4.SubItems.Add("COMP311");
                    listViewItem4.SubItems.Add("CNET307");
                    listViewItem4.SubItems.Add("MATH210");
                    courseListView.Items.Add(listViewItem4);
                }
                else if (courseTreeView.SelectedNode.Text == "SET")
                {
                    courseListView.Items.Clear();
                    //
                    ListViewItem listViewItem = new ListViewItem("Semester-1");
                    listViewItem.SubItems.Add("CNET125");
                    listViewItem.SubItems.Add("CNET330");
                    listViewItem.SubItems.Add("COMP213");
                    listViewItem.SubItems.Add("COMP312");
                    listViewItem.SubItems.Add("COMP122");
                    listViewItem.SubItems.Add("MATH213");
                    courseListView.Items.Add(listViewItem);
                    //
                    ListViewItem listViewItem2 = new ListViewItem("Semester-2");
                    listViewItem2.SubItems.Add("CNET126");
                    listViewItem2.SubItems.Add("CNET331");
                    listViewItem2.SubItems.Add("COMP214");
                    listViewItem2.SubItems.Add("COMP313");
                    listViewItem2.SubItems.Add("COMP256");
                    listViewItem2.SubItems.Add("MATH214");
                    courseListView.Items.Add(listViewItem2);
                    //
                    ListViewItem listViewItem3 = new ListViewItem("Semester-3");
                    listViewItem3.SubItems.Add("CNET126");
                    listViewItem3.SubItems.Add("CNET331");
                    listViewItem3.SubItems.Add("COMP214");
                    listViewItem3.SubItems.Add("COMP313");
                    listViewItem3.SubItems.Add("COMP219");
                    listViewItem3.SubItems.Add("MATH214");
                    courseListView.Items.Add(listViewItem3);
                    //
                    ListViewItem listViewItem4 = new ListViewItem("Semester-4");
                    listViewItem4.SubItems.Add("CNET126");
                    listViewItem4.SubItems.Add("CNET331");
                    listViewItem4.SubItems.Add("COMP214");
                    listViewItem4.SubItems.Add("COMP313");
                    listViewItem4.SubItems.Add("COMP316");
                    listViewItem4.SubItems.Add("MATH214");
                    courseListView.Items.Add(listViewItem4);
                }
                else if (courseTreeView.SelectedNode.Text == "SET-IG")
                {

                    courseListView.Items.Clear();
                    //
                    ListViewItem listViewItem = new ListViewItem("Semester-1");
                    listViewItem.SubItems.Add("CNET127");
                    listViewItem.SubItems.Add("CNET332");
                    listViewItem.SubItems.Add("COMP215");
                    listViewItem.SubItems.Add("COMP314");
                    listViewItem.SubItems.Add("COMP316");
                    listViewItem.SubItems.Add("MATH215");
                    courseListView.Items.Add(listViewItem);
                    //
                    ListViewItem listViewItem2 = new ListViewItem("Semester-2");
                    listViewItem2.SubItems.Add("CNET127");
                    listViewItem2.SubItems.Add("CNET332");
                    listViewItem2.SubItems.Add("COMP215");
                    listViewItem2.SubItems.Add("COMP314");
                    listViewItem2.SubItems.Add("TechElec");
                    listViewItem2.SubItems.Add("MATH215");
                    courseListView.Items.Add(listViewItem2);
                    //
                    ListViewItem listViewItem3 = new ListViewItem("Semester-3");
                    listViewItem3.SubItems.Add("CNET127");
                    listViewItem3.SubItems.Add("CNET332");
                    listViewItem3.SubItems.Add("COMP215");
                    listViewItem3.SubItems.Add("COMP314");
                    listViewItem3.SubItems.Add("COMP316");
                    listViewItem3.SubItems.Add("MATH215");
                    courseListView.Items.Add(listViewItem3);
                    //
                    ListViewItem listViewItem4 = new ListViewItem("Semester-4");
                    listViewItem4.SubItems.Add("CNET129");
                    listViewItem4.SubItems.Add("CNET334");
                    listViewItem4.SubItems.Add("COMP217");
                    listViewItem4.SubItems.Add("COMP316");
                    listViewItem4.SubItems.Add("COMP316");
                    listViewItem4.SubItems.Add("MATH216");
                    courseListView.Items.Add(listViewItem4);
                }
                else if (courseTreeView.SelectedNode.Text == "HIT")
                {

                    courseListView.Items.Clear();
                    //
                    ListViewItem listViewItem = new ListViewItem("Semester-1");
                    listViewItem.SubItems.Add("COMP129");
                    listViewItem.SubItems.Add("COMP334");
                    listViewItem.SubItems.Add("COMP217");
                    listViewItem.SubItems.Add("COMP316");
                    listViewItem.SubItems.Add("COMP253");
                    listViewItem.SubItems.Add("COMP216");
                    courseListView.Items.Add(listViewItem);
                    //
                    ListViewItem listViewItem2 = new ListViewItem("Semester-2");
                    listViewItem2.SubItems.Add("COMP130");
                    listViewItem2.SubItems.Add("COMP335");
                    listViewItem2.SubItems.Add("COMP218");
                    listViewItem2.SubItems.Add("COMP317");
                    listViewItem2.SubItems.Add("GNED139");
                    listViewItem2.SubItems.Add("COMP217");
                    courseListView.Items.Add(listViewItem2);
                    //
                    ListViewItem listViewItem3 = new ListViewItem("Semester-3");
                    listViewItem3.SubItems.Add("COMP131");
                    listViewItem3.SubItems.Add("COMP336");
                    listViewItem3.SubItems.Add("COMP219");
                    listViewItem3.SubItems.Add("COMP318");
                    listViewItem3.SubItems.Add("COMP146");
                    listViewItem3.SubItems.Add("COMP218");
                    courseListView.Items.Add(listViewItem3);
                    //
                    ListViewItem listViewItem4 = new ListViewItem("Semester-4");
                    listViewItem4.SubItems.Add("COMP132");
                    listViewItem4.SubItems.Add("COMP337");
                    listViewItem4.SubItems.Add("COMP220");
                    listViewItem4.SubItems.Add("COMP319");
                    listViewItem4.SubItems.Add("EMPS-I");
                    listViewItem4.SubItems.Add("GNED219");
                    courseListView.Items.Add(listViewItem4);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
        }
    }

