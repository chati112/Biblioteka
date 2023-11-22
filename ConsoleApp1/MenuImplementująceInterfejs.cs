using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class MenuImplementująceInterfejs : IFileService
    {
        public void SaveDataToFile()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fileStream, Ksiazka.ksiazki);
                binaryFormatter.Serialize(fileStream, Czasopismo.czasopisma);
                binaryFormatter.Serialize(fileStream, CzytelnikImplementującyInterfejs.czytelnicy);
                binaryFormatter.Serialize(fileStream, WypożyczeniaImplementująceInterfejs.wypożyczenia);

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych.\n" + ex.Message);
            }
        }

        public void LoadDataFromFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                Ksiazka.ksiazki = (List<Ksiazka>)binaryFormatter.Deserialize(fileStream);
                Czasopismo.czasopisma = (List<Czasopismo>)binaryFormatter.Deserialize(fileStream);
                CzytelnikImplementującyInterfejs.czytelnicy = (List<Czytelnik>)binaryFormatter.Deserialize(fileStream);
                WypożyczeniaImplementująceInterfejs.wypożyczenia = (List<Wypożyczenie>)binaryFormatter.Deserialize(fileStream);

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych.\n" + ex.Message);
            }
        }
    }
}
