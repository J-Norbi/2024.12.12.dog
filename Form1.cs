using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2024._12._12.gyakorlas
{
    public partial class Form1 : Form
    {
        List<Dog> dogs = new List<Dog>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            AddEvent();
        }
        void AddEvent()
        {
            button1.Click += Button1Event;
            button2.Click += Button2Event;
            button3.Click += Button3Event;
        }
        void Button1Event(Object s, EventArgs e)
        {
            square oneSquare = new square();
            groupBox1.Controls.Add(oneSquare);
            oneSquare.Top = 14;
        }
        void Button2Event(Object s, EventArgs e)
        {
           /* Dog oneDog = new Dog("Zsömi");
            oneDog.age = 5;
            listBox1.Items.Add($"A kutya neve: {oneDog.name}, kora: {oneDog.age} éves");
            oneDog.Bark();*/
           foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
        void Button3Event(Object s, EventArgs e)
        {
            try     //  ellenőrzi, hogy megfelelő-e a formátuma a beírt szövegnek, és csak a helyeset írja ki.
                    //  a ry-catch, csak a program hibát figyeli, a logikai hibát nem. A logikai hibát if-el tudod kivédeni.
            {
                Dog oneDog = new Dog(textBox1.Text, int.Parse(textBox2.Text));
                //oneDog.age = int.Parse(textBox2.Text);
                ShowDog oneShowDog = new ShowDog(oneDog);
                groupBox4.Controls.Add(oneShowDog);
                oneShowDog.Top = oneShowDog.Height * dogs.Count;
                dogs.Add(oneDog);
                listBox1.Items.Add($"A kutya neve: {oneDog.name}, kora: {oneDog.age} éves");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Text = "";
                textBox2.Focus();
            }
        }
    }
}
