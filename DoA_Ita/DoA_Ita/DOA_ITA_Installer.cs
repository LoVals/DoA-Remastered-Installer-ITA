using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoA_Ita
{
    public partial class DOA_ITA_Installer : Form
    {
        public DOA_ITA_Installer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sei sicuro di voler installare la traduzione per Dark Souls: Prepare to Die Edition?", "Conferma",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FolderBrowserDialog SoulFolderSelect = new FolderBrowserDialog();
                if (SoulFolderSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string PTDEDir = (SoulFolderSelect.SelectedPath);
                    Install_PTDE.Execute(PTDEDir);
                }
                else
                {
                    dr = MessageBox.Show("Non hai selezionato una directory. Il programma si chiuderá");
                }
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Sei sicuro di voler installare la traduzione per Dark Souls Remastered?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FolderBrowserDialog SoulFolderSelect = new FolderBrowserDialog();
                if (SoulFolderSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string RemasterDir = (SoulFolderSelect.SelectedPath);
                    Install_REMASTERED.Execute(RemasterDir);
                }
                else
                {
                    dr = MessageBox.Show("Non hai selezionato una directory. Il programma si chiuderá");
                }
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
