﻿using DOAN._Class;
using DOAN._controllManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Guest_Form : Form
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\anhuynh1905\\DOAN\\_data\\hotel_db.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        List<Guest> guests = new List<Guest>();
        string command;
        string insert;
        SqlDataReader reader;
        public Guest_Form()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guest_Form_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter();
            command = "SELECT * FROM Room_Info WHERE RoomStatus = '"+"EMPTY"+"'";
            adapter.SelectCommand = new SqlCommand(command, conn);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            datagridview.DataSource = bSource;
            conn.Close();
            feedBack1.Visible = false;
        }

        private void Book_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(CheckIn.Value < now)
            {
                Statuslable.Text = "Please re-enter check in date or check out date";
                return;
            }
            if(fNameBox.Text == "" || lNameBox.Text == "" || pNumberBox.Text == "" || RoomBox.Text == "" || pNumberBox.Text.Length < 10)
            {
                Statuslable.Text = "Please enter more information";
                return;
            }
            
            conn.Open();
            command = String.Format("SELECT RoomStatus FROM Room_Info WHERE RoomID = '" + "{0}" + "'", Int32.Parse(RoomBox.Text));
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if (Convert.ToString(reader["RoomStatus"]).Trim() == "OCCUPIED")
                {
                    Statuslable.Text = "Room is already been occupied, please choose another room";
                    reader.Close();
                    conn.Close();
                    cmd.Dispose();
                    return;
                }
            }
            reader.Close();
            guests.Add(new Guest(fNameBox.Text, lNameBox.Text, pNumberBox.Text));
            insert = guests.Last().MakeReservation(fNameBox.Text, lNameBox.Text, pNumberBox.Text, CheckIn, CheckOut, RoomBox.Text);
            cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();

            Statuslable.Text = "Success Booking !";
            conn.Close();
            cmd.Dispose();
            Guest_Form_Load(sender, e);
        }

        private void btfeed_Click(object sender, EventArgs e)
        {
            feedBack1.Visible = true;
            feedBack1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string h = "";
            try
            {
                h += guests.Last().PrintDetails() + Environment.NewLine;
            }
            catch
            {
                Statuslable.Text = "You have not enter booking details yet!!!";
                return;
            }
            conn.Open();
            command = guests.Last().FindRoom();
            cmd = new SqlCommand(command,conn);
            reader = cmd.ExecuteReader();
            while(reader.Read())        //34689 10
            {
                h += "Check in date: "+reader[3].ToString() + ", check out date: " + reader[4].ToString() + ", Room ID: " + reader[6].ToString() + ", Room Type: " + reader[8].ToString() +", Room Price: "+ reader[9].ToString() + ", Room Bed " + reader[10].ToString();
            }
            MessageBox.Show(h, "Booking Details");
        }
    }
}
