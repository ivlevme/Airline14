using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline14
{
    public partial class ManagerMainForm : BaseForm
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            ManagerAddFlightForm managerAddFlight = new ManagerAddFlightForm();
            managerAddFlight.Show();
            this.Hide();
        }

        private void AllFlightBtn_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
            this.Hide();
        }
    }
}
