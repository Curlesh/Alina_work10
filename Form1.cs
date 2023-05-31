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

namespace Alina_work10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string вывод()
        {
            using (StreamWriter file = new StreamWriter("file2.txt"))
            {
                file.WriteLine(textBox2.Text);
            }
            return "";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int Index = listBox1.SelectedIndex + 1;
            // label3.Text = Convert.ToString(Index);
            string line = textBox1.Text;
            string[] str_arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (Index)
            {
                case 1:
                    int max = 0,number=0;
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].Length>max)
                        {
                            max = str_arr[i].Length;
                            number = i;
                        }
                    }
                    textBox2.Text = "";
                    textBox2.Text = str_arr[number];
                    вывод();
                    break;
                 
                case 2:
                    textBox2.Text = "";
                    max = 0;
                    number = 0;
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].Length >= max)
                        {
                            max = str_arr[i].Length;
                            number = i;
                           
                        }
                    }
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].Length == max)
                        {
                            textBox2.Text += str_arr[i] + " ";
                        }
                    }
                    вывод();
                    break;
                case 3:
                    textBox2.Text = "";
                    int min = 65000;
                    number = 0;
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].Length < min)
                        {
                            min = str_arr[i].Length;
                            number = i;
                          
                        }
                    }
                    textBox2.Text += str_arr[number] + " ";
                    вывод();
                    break;
                case 4:
                    textBox2.Text = "";
                    min = 65000;
                    number = 0;
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].Length < min)
                        {
                            min = str_arr[i].Length;
                            number = i;
                            
                        }
                    }
                    for (int i = 0; i <str_arr.Length; i++)
                    {
                        if (str_arr[i].Length==min)
                        {
                            textBox2.Text += str_arr[i] + " ";
                        }
                    }
                    вывод();
                    break;
                case 5:
                    
                    textBox2.Text = "";
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        for (int j = 0; j < str_arr[i].Length; j++)
                        {
                            bool flag5 = false;
                            string word = str_arr[i];
                            for ( j = 0; j < word.Length; j++)
                            {
                                if (word[j]==word[word.Length-1-j])
                                {
                                    flag5 = true;
                                }
                            }
                            if (flag5)
                            {
                                textBox2.Text += word + " ";
                            }
                            
                        }
                    }
                    вывод();
                    break;

                case 6:
                    textBox2.Text = "";
                    Array.Sort(str_arr);
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        textBox2.Text += str_arr[i]+" ";
                    }
                    вывод();
                    break;
                case 7:
                    textBox2.Text = "";
                    int schet = 0;
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        schet++;
                    }
                    int[] mas = new int[schet];
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        mas[i] = str_arr[i].Length;
                    }
                    Array.Sort(mas, str_arr);
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        textBox2.Text += str_arr[i]+" ";
                    }
                    вывод();
                    break;
                case 8:
                    textBox2.Text = "";

                    textBox3.Visible = true;
                    label2.Visible = true;
                    if (textBox3.Text!="")
                    {
                        
                        string l = textBox3.Text;
                        for (int i = 0; i < str_arr.Length; i++)
                        {

                            if (str_arr[i].IndexOf(l) == 0)
                            {
                                textBox2.Text += str_arr[i] + " ";
                            }
                        }
                        вывод();
                    }
                   
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("file.txt"))
            {
                textBox1.Text = file.ReadToEnd();
                file.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string line = textBox1.Text;
            string[] str_arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox2.Text = "";

            if (textBox3.Text != "")
            {
                textBox2.Text = "";

                textBox3.Visible = true;
                label2.Visible = true;
                string l = textBox3.Text;
                for (int i = 0; i < str_arr.Length; i++)
                {

                    if (str_arr[i].IndexOf(l) == 0)
                    {
                        textBox2.Text += str_arr[i] + " ";
                    }
                }
                вывод();
            }

        }
    }
}
