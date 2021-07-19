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
                CopyFiles(SelectedDir);
            }
            else
            {
                DialogResult ErrorReport = MessageBox.Show("DARKSOULS.exe non trovato: Hai selezionato la cartella sbagliata", "Errore! Cartella selezionata non valida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("ERROR CODE 1 - EXE FILE NOt FOUND");
                RetryMenu();
                //Cippirimerlo Boia!
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
            string PTDEDIR = CurrentDir + @"/PatchData/PTDE/";
            CopyAndOverWrite(PTDEDIR + "item.msgbnd", SelectedDir+ @"/DATA/msg/ITALIAN/item.msgbnd");
            CopyAndOverWrite(PTDEDIR + "menu.msgbnd", SelectedDir + @"/DATA/msg/ITALIAN/menu.msgbnd");
            CopyAndOverWrite(PTDEDIR + "menu_local.tpf", SelectedDir + @"/DATA/menu/ITALIAN/menu_local.tpf");
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
