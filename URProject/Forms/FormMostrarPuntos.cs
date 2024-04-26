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

namespace URProject.Forms
{
    public partial class FormMostrarPuntos : Form
    {
        ClassXml classxml;

        public FormMostrarPuntos(ClassXml xml)
        {
            InitializeComponent();
            classxml = xml;
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
    }
}
