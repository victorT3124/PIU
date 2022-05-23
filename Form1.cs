using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace PIU
{
    //Prima clasa(lab2)
    public partial class Form1 : Form
    {
        SoundPlayer soundLeu = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\leu.wav");
        SoundPlayer soundPisica = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\pisica.wav");
        SoundPlayer soundCorrect = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\correct.wav");
        SoundPlayer soundWrong = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\wrong.wav");
        SoundPlayer soundCaine = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\caine.wav");
        SoundPlayer soundBuhnita = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\buhnita.wav");
        SoundPlayer soundVultur = new SoundPlayer(soundLocation: @"C:\Users\Professional\source\repos\PIU\sounds\vultur.wav");


        int correctAnswer;
        int questionNumber = 1;
        int score;
        int procente;
        int totalQuestions;


        public Form1()
        {

            InitializeComponent();

            DialogResult = MessageBox.Show("Apasa OK pentru a incepe jocul", "START GAME");
            if (DialogResult == DialogResult.OK)
            {
               Hide();
                FormName Name = new FormName();
                Name.ShowDialog();
            }   
            else
            {
                Close();
            }
            


            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;


            }



            if (questionNumber == totalQuestions)
            {
                //procentajul
                procente = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Jocul a luat sfarșit!" + Environment.NewLine +
                    "Ai raspuns la " + score + " întrebari corect." + Environment.NewLine +
                    "Procentajul tău total este " + procente + "%" + Environment.NewLine +
                    "Apasa OK pentru a juca din nou ", "GAME OVER"
                    );


                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
                Close();


            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    soundPisica.Play();
                    pictureBox1.Image = Properties.Resources.tigru;
                    pictureBox2.Image = Properties.Resources.leu;
                    pictureBox3.Image = Properties.Resources.pisica;

                    button1.Text = "Tigru";
                    button2.Text = "Leu";
                    button3.Text = "Pisica";

                    correctAnswer = 3;
                    break;


                case 2:
                    soundCaine.Play();
                    pictureBox1.Image = Properties.Resources.lup;
                    pictureBox2.Image = Properties.Resources.leu;
                    pictureBox3.Image = Properties.Resources.caine;

                    button1.Text = "Lup";
                    button2.Text = "Leu";
                    button3.Text = "Caine";

                    correctAnswer = 3;
                    break;

                case 3:
                    soundBuhnita.Play();
                    pictureBox1.Image = Properties.Resources.gasca;
                    pictureBox2.Image = Properties.Resources.buhnita;
                    pictureBox3.Image = Properties.Resources.paun;

                    button1.Text = "Gasca";
                    button2.Text = "Buhnita";
                    button3.Text = "Paun";

                    correctAnswer = 2;
                    break;
                case 4:
                    soundLeu.Play();
                    pictureBox1.Image = Properties.Resources.leu;
                    pictureBox2.Image = Properties.Resources.cal;
                    pictureBox3.Image = Properties.Resources.tigru;

                    button1.Text = "Leu";
                    button2.Text = "Cal";
                    button3.Text = "Tigru";

                    correctAnswer = 1;
                    break;

                case 5:
                    soundVultur.Play();
                    pictureBox1.Image = Properties.Resources.gasca;
                    pictureBox2.Image = Properties.Resources.cioara;
                    pictureBox3.Image = Properties.Resources.vultur;

                    button1.Text = "Gasca";
                    button2.Text = "Cioara";
                    button3.Text = "Vultur";

                    correctAnswer = 3;
                    break;


            }
        }


    }


}