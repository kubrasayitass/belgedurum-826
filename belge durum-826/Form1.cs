using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belge_durum_826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNotOrtalaması_Click(object sender, EventArgs e)
        {

        }

        private void btnBelgeDurumuGöster_Click(object sender, EventArgs e)
        {
            double notortalama, devamsizlikSayi;
            int zayifSayi;

            notortalama = Convert.ToDouble(txtOrtalama.Text);
            devamsizlikSayi = Convert.ToDouble(txtDevamsızlıksayısı.Text);
            zayifSayi = Convert.ToInt32(txtZayif.Text);

            if (notortalama >= 70 && notortalama < 85 && devamsizlikSayi < 5 && zayifSayi == 0)
            {
                lblDurum.Text = "Teşekkür Belgesi Alacaksınız...";
            }
            else if (notortalama >= 85 && notortalama <= 100 && devamsizlikSayi < 5 && zayifSayi == 0)
            {
                lblDurum.Text = "Takdir Belgesi Alacaksınız";
            }
            else if (devamsizlikSayi > 5)
            {
                lblDurum.Text = "Devamsızlığınız fazla";
            }
            else if (zayifSayi != 0)
            {
                lblDurum.Text = "zayıf var";
            }
            else
            {
                lblDurum.Text = "üzgünüm belge yok";
            }


            
                
        }
    }
}
