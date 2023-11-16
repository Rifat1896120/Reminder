using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using MySql.Data;

namespace reminder
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.save_btn, "Save");
            toolTip2.SetToolTip(this.close_btn, "Close Window");
            toolTip3.SetToolTip(this.play_btn, "Start");
            toolTip4.SetToolTip(this.delet_btn, "Delete");
            toolTip5.SetToolTip(this.pause_btn, "Pause");

        }
        public bool isc = false;
        public void notification(string time, string event_)
        {

            kjlf.Text = DateTime.Now.ToString("t").Replace(" ", "") + " " + time.Replace(" ", "");

            if ((DateTime.Now.ToString("t").Replace(" ", "") == time.Replace(" ", "")) || (DateTime.Now.ToString("t").Replace(" ", "").Replace("PM", "pm") == time.Replace(" ", "").Replace("PM", "pm")))
            {



                ToastNotificationManagerCompat.History.Clear();
                ToastContentBuilder toastContentBuilder = new ToastContentBuilder();
                toastContentBuilder.AddText(event_ + "  " + time);

                toastContentBuilder.SetToastDuration(ToastDuration.Long);
                toastContentBuilder.Show();

                Thread.Sleep(30000);

            }



        }
        public void database_add(string event_, string time_)
        {
            string connectionstr = "Server=localhost;Database=reminder;Uid=root;Pwd=root;";
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionstr);

            mySqlConnection.Open();

            string strcomd = "INSERT INTO datas VALUE (@Event_ , @time_)";
            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(strcomd, mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@Event_", event_);
            mySqlCommand.Parameters.AddWithValue("@time_", time_);

            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();

        }
        public void database_delete()
        {
            string connectionstr = "Server=localhost;Database=reminder;Uid=root;Pwd=root;";
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionstr);

            mySqlConnection.Open();

            string strcomd = "DELETE  FROM datas ";
            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(strcomd, mySqlConnection);

            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
        }
        private void pause_btn_Click(object sender, EventArgs e)
        {
            isc = true;
        }
        public void database_delete_event_(string event_)
        {
            string connectionstr = "Server=localhost;Database=reminder;Uid=root;Pwd=root;";
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionstr);

            mySqlConnection.Open();

            string strcomd = $"DELETE  FROM datas WHERE Event_='{event_}' ";
            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(strcomd, mySqlConnection);

            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
        }
        public List<string> database_get_data(bool condi)
        {
            var event_list = new List<string>();
            var time_list = new List<string>();
            var list = new List<string>();

            string connectionstr = "Server=localhost;Database=reminder;Uid=root;Pwd=root;";
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionstr);

            mySqlConnection.Open();

            string strcomd = "SELECT Event_ , time_ FROM datas";
            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(strcomd, mySqlConnection);
            using (var rend = mySqlCommand.ExecuteReader())
            {
                int i = 0;


                comboBox1.Items.Clear();

                event_list.Clear();
                time_list.Clear();
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("All");
                while (rend.Read())
                {
                    if (listView1.Items.Count == 0)
                    {
                        comboBox1.Text = "";
                    }
                    var event_ = rend.GetString(0);
                    var time_ = rend.GetString(1);

                    event_list.Add(event_);
                    time_list.Add(time_);
                    comboBox1.Items.Add(event_);
                    if (condi == true || i == listView1.Items.Count)
                    {


                        ListViewItem listViewItem = new ListViewItem(event_);

                        listViewItem.SubItems.Add(time_);


                        listView1.Items.Add(listViewItem);
                    }
                    i++;
                }
            }

            if (listView1.Items.Count == 0)
            {
                comboBox1.Items.Clear();
            }
            mySqlConnection.Close();
            list.AddRange(event_list);
            list.AddRange(time_list);
            return list;
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            database_get_data(true);
            this.notifyIcon1.Icon = global::reminder.Properties.Resources.icon;



        }

        private void save_btn_Click(object sender, EventArgs e)
        {



            if (!(event_text.Text == "") && !(time_text.Text == ""))
            {

                database_add(event_text.Text, time_text.Text);
                database_get_data(false);
                event_text.Text = "";
                event_text.Text = "Something";
                time_text.Text = "";
                time_text.Text = "10:20pm (hint)";

            }

        }

        private void key_down_event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                time_text.Focus();
            }
        }

        private void combo_key(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void mouse_click_notifyicon(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delet_btn_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "All")
            {
                database_delete();
                listView1.Items.Clear();

                database_get_data(true);
                comboBox1.Text = "";

            }
            else
            {
                database_delete_event_(comboBox1.Text);
                listView1.Items.Clear();
                database_get_data(true);
                comboBox1.Text = "";
            }

        }

        private void run_()
        {

            while (true)
            {



                status.Text = "Runing...";
                var list = database_get_data(false);


                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (isc)
                    {


                        break;
                    }
                   
                    if (listView1.Items.Count > 10)
                    {

                        Thread.Sleep(100);
                    }
                    else if (listView1.Items.Count > 5)
                    {

                        Thread.Sleep(300);
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }



                    notification(list[i + (list.Count / 2)], list[i]);




                }
                if (isc)
                {
                    status.Text = "Stop";
                    isc = false;
                    break;
                }
            }


        }
        private void play_btn_Click(object sender, EventArgs e)
        {
            database_get_data(false);
            Task.Run(() => run_());



        }

        private void time_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_focus(object sender, EventArgs e)
        {
            time_text.Text = "";
        }

        private void event_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void event_focus(object sender, EventArgs e)
        {
            event_text.Text = "";
        }
    }
}
