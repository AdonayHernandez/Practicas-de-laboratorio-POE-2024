using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;

namespace PresentationLayer.Forms
{
    public partial class CareerForm : Form
    {
        private CareerServices _careerServices;

        public CareerForm()
        {
            _careerServices = new CareerServices();
            InitializeComponent();
            LoadCareerData();
        }

        public void LoadCareerData()
        {
            dataGridView1.DataSource = _careerServices.GetAllCareers();
        }

        private void CareerForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
