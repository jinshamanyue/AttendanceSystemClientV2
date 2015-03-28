using System;
using System.Windows.Forms;
using System.Linq;
using RemObjects.DataAbstract.Linq;
using Telerik.WinControls.UI;

namespace AttendanceSystemClientV2
{
    public partial class MainForm : RadForm
    {
        #region Private fields
        private DataModule fDataModule;
        #endregion

        public MainForm()
        {
            this.InitializeComponent();

            this.fDataModule = new DataModule();
        }

        private void panel1_default_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
