using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;
using System.Xml;
using System.Reflection;
using System.IO;

namespace URProject.Forms
{
    public partial class FormMostrarPuntos : Form
    {
        ClassXml classxml;
        ClassRTDE classrtde;


        public FormMostrarPuntos(ClassXml xml, ClassRTDE rtde)
        {
            InitializeComponent();
            classxml = xml;
            classrtde = rtde;
            InitializeDataGrid();

        }

        public void InitializeDataGrid()
        {
            XmlReader data  = this.classxml.readTrajectory();

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(data);
            DataSet copyDataset = new DataSet();
            copyDataset = dataSet.Clone();

            grid.DataSource = dataSet.Tables["Pose"];
            gridTrajectory.DataSource = copyDataset.Tables["Pose"];

        }

        private void buttonAddToTrajectory_Click(object sender, EventArgs e)
        {
            DataTable dt = gridTrajectory.DataSource as DataTable;
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                DataRow rowBuena = (row.DataBoundItem as DataRowView).Row;
                dt.ImportRow(rowBuena);
            }
        }
        
        private void buttonExecTrajectory_Click(object sender, EventArgs e)
        {
           
            DataTable dt = gridTrajectory.DataSource as DataTable;
            if (File.Exists(ClassData.trajectoryPath))
            {
                File.Delete(ClassData.trajectoryPath);
            }
            foreach (DataGridViewRow row in gridTrajectory.Rows)
            {
                if (row.Index != gridTrajectory.RowCount - 1)
                {
                    classxml.addPose(row.Cells[0].Value.ToString(), double.Parse(row.Cells[1].Value.ToString()), double.Parse(row.Cells[2].Value.ToString()), double.Parse(row.Cells[3].Value.ToString()), double.Parse(row.Cells[4].Value.ToString()), double.Parse(row.Cells[5].Value.ToString()), double.Parse(row.Cells[6].Value.ToString()), "Trajectory");

                }
            }

        }

        private void buttonSavePose_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Are you sure?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Added pose");
                    //classRTDE.getRobotPos();
                    classxml.addPose(textBox1.Text, 25, 30, 20, 10, 25, 22, "Poses");
                }
                else
                {
                    MessageBox.Show("Declined");
                }

            }
            else
            {
                MessageBox.Show("Please enter pose name");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridTrajectory.RowCount >= 2)
            {
                gridTrajectory.Rows.RemoveAt(gridTrajectory.RowCount - 2);
            }

        }
    }
}
