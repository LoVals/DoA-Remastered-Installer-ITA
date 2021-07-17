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
    class Install_REMASTERED
    {
        public static void Execute(string SelectedDir)
        {

            if (Install_REMASTERED.ExeFileExists(SelectedDir) == true)
            {
                CopyFiles(SelectedDir);
            }
            else
            {
                DialogResult ErrorReport = MessageBox.Show("DarkSoulsRemastered.exe non trovato: Hai selezionato la cartella sbagliata", "Errore! Cartella selezionata non valida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("ERROR CODE 1 - EXE FILE NOt FOUND");
                RetryMenu();
            }
        }
        public static bool ExeFileExists(string CheckDir)
        {
            if (File.Exists(CheckDir + @"/DarkSoulsRemastered.exe"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void RetryMenu()
        {

            FolderBrowserDialog SoulFolderSelect = new FolderBrowserDialog();
            if (SoulFolderSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string PTDEDir = (SoulFolderSelect.SelectedPath);
                Install_PTDE.Execute(PTDEDir);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Non hai selezionato una directory. Il programma si chiuderá");
            }
        }
        public static void CopyFiles(string SelectedDir)
        {
            string CurrentDir = Directory.GetCurrentDirectory();
            string DSRDIR = CurrentDir + @"/PatchData/DSR/";
            CopyAndOverWrite(DSRDIR + "item.msgbnd.dcx", SelectedDir + @"/msg/ITALIAN/item.msgbnd.dcx");
            CopyAndOverWrite(DSRDIR + "menu.msgbnd.dcx", SelectedDir + @"/msg/ITALIAN/menu.msgbnd.dcx");
            CopyAndOverWrite(DSRDIR + "menu_local.tpf.dcx", SelectedDir + @"/menu/ITALIAN/menu_local.tpf.dcx");
        }
        public static void CopyAndOverWrite(string sourcefile, string destinationfile)
        {
            //Funzione Custom - controlla l'esistenza dei file vecchi e se esistenti li cancella prima di copiare i nuovi file
            if (File.Exists(destinationfile))
            {
                File.Delete(destinationfile);
            }
            File.Copy(sourcefile, destinationfile);
        }
    }
}
