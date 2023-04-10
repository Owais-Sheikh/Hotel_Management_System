using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hotel_System.RoomControl
{
    public partial class Invoice : UserControl
    {
        Classes.Manager manager = new Classes.Manager();
        public Invoice()
        {
            InitializeComponent();
        }
        public void OpenInvoice(object obj)
        {
            Application.Run(new InvoiceForm());
        }
        
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenInvoice);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
