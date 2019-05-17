using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Capturer
{
    public partial class ProcessListForm : Form
    {
        MyProcess myprocess = new MyProcess();

        public ProcessListForm()
        {
            InitializeComponent();


            for (int i = 0; i < myprocess.process.Length; i++)
            {
                if (myprocess.process[i].MainWindowTitle.Length > 0 ||
                    myprocess.process[i].ProcessName == "explorer")
                {
                    //라벨에 리스트 표현
                    /* this.label1.Text += myprocess.process[i].ProcessName + "   "
                         + myprocess.process[i].Id + "   "
                         + myprocess.process[i].MainWindowTitle + "\n";*/
                    this.listView1.Items.Add(myprocess.process[i].ProcessName);

                }
            }
            /* int indexnum;
             indexnum = listView1.FocusedItem.Index;
             string test = listView1.Items[indexnum].SubItems[0].Text;
             this.listView1.Items.Add(myprocess.process[1].ProcessName, indexnum);*/





        }

        public class MyProcess
        {
            public Process[] process;
            public MyProcess()
            {
                process = Process.GetProcesses();

            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   //listview 아이템 목록 한줄씩 보이게 하는 코드
            listView1.View = View.List;

            //listView1.HeaderStyle = ColumnHeaderStyle.None;

            // ColumnHeader h = new ColumnHeader();

            // h.Width = listView1.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

            // listView1.Columns.Add(h);




            //선택한 리스트 인덱스 반환

            /* ListView lv = sender as ListView;
             lv.FullRowSelect = true;
             SelectRow = lv.SelectedItems[0].Index;*/
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvitem = items[0];
                MessageBox.Show(lvitem.SubItems[0].Text);
            }









        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
