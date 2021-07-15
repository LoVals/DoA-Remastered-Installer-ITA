using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoA_Ita
{
    class Install_PTDE
    {
        public static void Execute(string SelectedDir)
        {

            if (Install_REMASTERED.ExeFileExists(SelectedDir) == true)
            {
                //INSTALLCODE GOES HERE
            }
            else
            {
                DialogResult ErrorReport = MessageBox.Show("DARKSOULS.exe non trovato: Hai selezionato la cartella sbagliata", "Errore! Cartella selezionata non valida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("ERROR CODE 1 - EXE FILE NOt FOUND");
            }
        }

        public static bool ExeFileExists(string CheckDir)
            {
                if (File.Exists(CheckDir + @"/DATA/DARKSOULS.exe"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
