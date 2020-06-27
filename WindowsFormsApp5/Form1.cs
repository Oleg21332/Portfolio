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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public int b = 35;
        int[] mas = new int[35];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//закрытие программы
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение действия", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();//Диалоговое окно с подтверждением закрытия программы
        }

        private void Random_Click(object sender, EventArgs e)//рандомное заполнение массива
            {
            dataGridView1.ColumnCount = 35;//количество столбцов
            Random rnd = new Random();//рандом
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-100, 100);//заполнение массива рандомными числами
                dataGridView1.Rows[0].Cells[i].Value = mas[i];//заполнение ячеек
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//очистка
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Rows[0].Cells[i].Value = "";
            label2.Text = "";
            label1.Text = ""; 
        }

        private void vvod_Click(object sender, EventArgs e)//файловый ввод
        {
            try
            {
                StreamReader f = new StreamReader(@"C:\\vvod.txt");//объявление стримридера
                string[] a = f.ReadToEnd().Split('\n');//чтение из файла
                for (int i = 0; i < 36; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = a[i];//заполнение ячеек 
                    mas[i] = Convert.ToInt32(a[i]);//заполнение массива
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ошибка! Не удалось найти файл.!");//исключение при отсутствии файлов
            }
        }

        private void perehod_Click(object sender, EventArgs e)//переход на 2 форму
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();

        }

        private void zadanie_Click(object sender, EventArgs e)//задание
        {
             int min = mas[0],
             index = 0;
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] <= 0)
                {
                    min = mas[i];
                    index = i+1;//индекс
                    break;
                }
            //метка
            label1.Text = $"Первое минимальное число:{min} \nИндекс первого минимального числа: {index}";//вывод на метку

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grafic_Click(object sender, EventArgs e)//работа с графиком
        {
            int[] x = mas;//координаты по оси Х
            int[] y = new int[35];//координаты по Y
            for (int i = 0; i < 35; i++)
            {
                y[i] = mas[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1;//интервал оси Y
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 2;//интервал оси X
                chart1.Series[0].Points.DataBindXY(x, y);// построение графика
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Array.Sort(mas); //сортировка методом Sort
            for (int i = 0; i < mas.Length; i++)
                dataGridView1.Rows[0].Cells[i].Value = mas[i]; // заполнение ячеек dataGridViev
        }
    }
}


