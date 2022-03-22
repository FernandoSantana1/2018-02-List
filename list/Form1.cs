using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> nums = new List<int>(); //declarar a lista
            MessageBox.Show("Capacidade: " + " " + nums.Capacity + "Tamanho: " + " " + nums.Count);
            nums.Add(1); //adicionar os valores 
            MessageBox.Show("Capacidade: " + " " + nums.Capacity + "Tamanho: " + " " + nums.Count);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            MessageBox.Show("Capacidade: " + " " + nums.Capacity + "Tamanho: " + " " + nums.Count);
            Random r = new Random(); //"Random" = numeros aleatorios 
            for(int i = 0; i < 1000000; i++)
            {
                nums.Add(r.Next()); // adiciona numeros aleatorios na lista
                
            }
            nums.Sort(); //ordenar
            nums[10] = 10; //pegar a posição indicada
            nums.First(); //procurar o primeiro
            nums.Last(); //procurar  o ultimo
            richTextBox1.AppendText("Capacidade: " + " " + nums.Capacity + "Tamanho: " + " " + nums.Count);
        }
    }
}
