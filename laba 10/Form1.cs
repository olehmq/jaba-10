using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_10
{
    public partial class Form1 : Form
    {
        private readonly IWordGame _wordGame;
        public Form1()
        {
            InitializeComponent();
            var wordGame = new WordGame("чай", new[] { "Напій", "Чорний або зелений", "П'єш с бутербродами" });

            _wordGame = new WordGameProxy(wordGame);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var guess = textBox1.Text;

            

            if (_wordGame.GuessWord(guess))
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                label1.Text = $"Hint: {_wordGame.GetHint()}";
            }
        }
    }
}
