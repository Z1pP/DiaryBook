using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Example
    
{
    
    public partial class GeneralWindow : Form
    {       
        public GeneralWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if(lineForEnterTask.Text == string.Empty || listTime.Text == string.Empty)
            {
                MessageBox.Show("Вы не указали время или задание");
                return;
            }

            string time = DateTime.Now.ToString("dd:MM:yyyy");
            if (lineForEnterTask.Text.Length >=50)
            {
                MessageBox.Show("Вы привысили количество вводимых символов");
                lineForEnterTask.Clear();
                return;
            }

            //Изменение формата времени
            string currectTimeFormat = string.Empty;
            char[] formatTime = listTime.Text.ToCharArray();
            for (int i = 0; i < formatTime.Length; i++)
            {
                if (formatTime[i] == '.' || formatTime[i] == ',')
                    formatTime[i] = ':';
                if ((formatTime[i] >= 32 && formatTime[i] <= 47) || formatTime[i] >= 59 && formatTime[i] <= 127) // ASCII
                {
                    MessageBox.Show("Введены недопустимые символы");
                    listTime.Clear();
                    return;
                }
                currectTimeFormat += formatTime[i].ToString();                
            }
            if (int.Parse((currectTimeFormat[0].ToString() + currectTimeFormat[1].ToString()).ToString()) >= 24)
            {
                MessageBox.Show("Не верно указан формат минут");
                listTime.Clear();
                return;
            }
            else if(int.Parse((currectTimeFormat[3].ToString() + currectTimeFormat[4].ToString()).ToString()) > 59)
            {
                MessageBox.Show("Не верно указан формат секунд");
                listTime.Clear();
                return;
            }    
            if (currectTimeFormat.Length > 5)
            {
                 MessageBox.Show("Не верно указан формат времени");
                 listTime.Clear();
                 return;        
            }

            //Заполения строки таблицы
            dataGridView1.Rows.Add(dataGridView1.CurrentRow.Cells[0].Value, lineForEnterTask.Text, currectTimeFormat, time);
            //Очистка полей вода времени и задания
            lineForEnterTask.Clear();
            listTime.Clear();
        }


        private void deleteTask_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\1.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);
            try
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + "     ");
                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }
    }
}
