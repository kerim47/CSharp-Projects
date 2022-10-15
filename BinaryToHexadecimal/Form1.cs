using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BinaryToHexadecimal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
         
            InitializeComponent();
        }

        /// Değişken tanımlamaları
        public string data = "";
        public string input = "";
        public string variable = "";
        public ArrayList arrayList = new ArrayList(); 
        public ArrayList compare = new ArrayList();
        public byte[] ikilik = new byte[8]; 
        public bool isButtonClick = false;

        private void richTextBoxAdd(DateTime dateTime)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;


            string zaman = dateTime.ToString("dd/MM/yyyy   hh:mm:ss:fff", ci);
            if (listBox1.Items.Count != 0)
            {
                richTextBox1.AppendText(zaman + "\t\t");
            }
            foreach (string item in compare)
            {
                richTextBox1.AppendText(item + " ");
            }
            richTextBox1.AppendText("\n");
        }
        private string ToSingleDigit(string str)
        {
            if (str.Length == 1)
            {
                string modified = str.Insert(0, "0");
                return modified;
            }
            return str;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            CheckFalse();
        }
        public void labelClear(int indexOfNumber)
        {
            if (indexOfNumber != -1)
            {
                switch (indexOfNumber)
                {
                    case 0:
                        label1.Text = ""; // hexadecimal veriler label.text' lere yazildi
                        break;
                    case 1:
                        label2.Text = "";
                        break;
                    case 2:
                        label3.Text = "";
                        break;
                    case 3:
                        label4.Text = "";
                        break;
                    case 4:
                        label5.Text = "";
                        break;
                    case 5:
                        label6.Text = "";
                        break;
                    case 6:
                        label7.Text = "";
                        break;
                    case 7:
                        label8.Text = "";
                        break;
                    case 8:
                        label9.Text = "";
                        break;
                }
            }

        }       
        public void  listBoxUpdate()
        {
            arrayList.Clear();
            richTextBox1.Clear();
            DateTime dateTime = DateTime.Now;
            if (listBox1.Items.Count == 9)
            {
                if (isButtonClick == true)
                {
                    richTextBoxAdd(dateTime);
                }
                else
                {
                    richTextBox1.Clear();
                }
            }
            foreach (string item in listBox1.Items)
            {
                int value = Convert.ToInt32(item, 16);
                arrayList.Add(value);
            }
            
            arrayList.Sort();
            labelEdit();
        }
        public void labelEdit()
        {
            if (listBox1.Items.Count == 8)
            {
                button2.Enabled = true;
            }
            compare.Clear();
            int sayac = 0;
            foreach (int item in arrayList) // Array listteki veriler label.text' lere eklendi
            {
                switch (sayac)
                {
                    case 0:
                        input = Convert.ToInt32(item).ToString("X"); // array listeki veriler hexadecimal e dönüştürüldü
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label1.Text = input.ToString(); // hexadecimal veriler label.text' lere yazildi
                        break;
                    case 1:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label2.Text = input.ToString();
                        break;
                    case 2:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label3.Text = input.ToString();
                        break;
                    case 3:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label4.Text = input.ToString();
                        break;
                    case 4:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label5.Text = input.ToString();
                        break;
                    case 5:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label6.Text = input.ToString();
                        break;
                    case 6:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label7.Text = input.ToString();
                        break;
                    case 7:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label8.Text = input.ToString();
                        break;
                    case 8:
                        input = Convert.ToInt32(item).ToString("X");
                        input = ToSingleDigit(input);
                        compare.Add((string)input);
                        label9.Text = input.ToString();
                        break;
                }

                sayac++;
            }
        }    
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox1.Text = "1";
            else
                checkBox1.Text = "0";
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox2.Text = "1";
            else
                checkBox2.Text = "0";
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                checkBox3.Text = "1";
            else
                checkBox3.Text = "0";

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                checkBox4.Text = "1";
            else
                checkBox4.Text = "0";

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                checkBox5.Text = "1";
            else
                checkBox5.Text = "0";

        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                checkBox6.Text = "1";
            else
                checkBox6.Text = "0";
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                checkBox7.Text = "1";
            else
                checkBox7.Text = "0";
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                checkBox8.Text = "1";
            else
                checkBox8.Text = "0";
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            if (arrayList.Count >= 9)
            {
                MessageBox.Show("Maksimum veri adeti girildi.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                ButtonAdd.Enabled = false;
                button2.Enabled = true;
                
            }
            else
            {
                //Checbox true ise  1 false 0 bit girdiği anlamını taşır.
                if (checkBox8.Checked == true)
                    ikilik[7] = 1; 
                else
                    ikilik[7] = 0;

                if (checkBox7.Checked == true)
                    ikilik[6] = 1;
                else
                    ikilik[6] = 0;

                if (checkBox6.Checked == true)
                    ikilik[5] = 1;
                else
                    ikilik[5] = 0;

                if (checkBox5.Checked == true)
                    ikilik[4] = 1;
                else
                    ikilik[4] = 0;

                if (checkBox4.Checked == true)
                    ikilik[3] = 1;
                else
                    ikilik[3] = 0;

                if (checkBox3.Checked == true)
                    ikilik[2] = 1;
                else
                    ikilik[2] = 0;

                if (checkBox2.Checked == true)
                    ikilik[1] = 1;
                else
                    ikilik[1] = 0;

                if (checkBox1.Checked == true)
                    ikilik[0] = 1;
                else
                    ikilik[0] = 0;

                foreach (var item in ikilik)
                {
                    data += item.ToString(); // Ayrı ayrı dizide saklanan veriler toplu olarak bir stringe aktarildi
                }
                //MessageBox.Show(data);
                // string veriler hexadecimale cevrildi


                byte ata;
                ata = (byte)Convert.ToInt32(data, 2); // Data dizininden gelen bitlik veriler ata byte veri tipi değişkenine atildi

                arrayList.Add((int)ata); // Gelen veriler listbox1 e eklenmek için array liste atandi
                arrayList.Sort(); // Array list sıralandı
                labelEdit();


                input = Convert.ToInt32(data, 2).ToString("X"); // data stringi int' e daha sonra hexadecimal' e dönüştürüldü


                label10.Text = data; // Girilen bitler sonuc ekranına yazdirir
                data = ""; // Tum degerleri aynı diziye aktarmaması için diziye boş deger atandi

                

                if (input.Length == 1)
                {
                   string modified =  input.Insert(0, "0");
                    listBox1.Items.Add(modified); // Veriler listbox kutusuna eklendi
                } 
                else
                {
                    listBox1.Items.Add(input); // Veriler listbox kutusuna eklendi
                }

                

                

            }

            // Checkbox durumları aynı kalmaması için tum değerler false yapildi
            CheckFalse();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            isButtonClick = true;

            if (listBox1.Items.Count == 9)
            {
                button2.Enabled = true;
                DateTime dateTime = DateTime.Now;
                richTextBoxAdd(dateTime);
            }
            else
            {
                button2.Enabled = false;
                ButtonAdd.Enabled = true;
            }
            if (listBox1.Items.Count == 8)
            {
                listBoxUpdate();
            }
            ButtonAdd.Enabled = false;
            button2.Enabled = false; // kaydet butonuna bastıysa kapat
            button3.Enabled = true; // Kaydet butonuna bastığı zaman DosyayaGonder butonu aktif olacak
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter("bilgiler.txt");
            int i = -1;
            foreach (var yazi in compare) // listboxtaki öğeleri dosyaya gonderme
            {
                if (i == -1)
                {
                    variable += "\t";
                    yaz.WriteLine(variable);
                    i++;
                }
                yaz.WriteLine((string)yazi);
            }
            yaz.WriteLine("");
            
            yaz.Close();
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // değişkenlerde saklı tutulan eski veriler boşaltıldı
            // Varsayılan değerler olarak atandı
            Form1_Load(null, null);
            arrayList.Clear();
            listBox1.Items.Clear();
            richTextBox1.Clear();
            compare.Clear();
            
            for (int i = 0; i < ikilik.Length; i++)
            {
                ikilik[i] = 0;
            }
            ButtonAdd.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                labelClear(i);
            }
            label10.Text = "    Result : ";
            Form1_Load(null, null);

        }
        public void CheckFalse()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2.Enabled = false;
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                
                ButtonAdd.Enabled = true;
                arrayList.RemoveAt(secim);
                listBox1.Items.RemoveAt(secim);

                for (int i = 0; i <= arrayList.Count; i++)
                {
                    labelClear(i);
                }
                listBoxUpdate();
                if (listBox1.Items.Count < 9)
                {
                    button2.Enabled = false;
                }

            }
        }
        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
