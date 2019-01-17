using System;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Game game;
        private fEnter fEnter;

        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            btnStart.PerformClick();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new Game();
            lblHelp.Text = "Угадайте число, что я загадал";
            tbHistory.Text = string.Empty;
            btnStart.Visible = false;
            fEnter = new fEnter(game);
            fEnter.UpdateEvent += UpdateFromAnotherForm;
            fEnter.ClosingEvent += CloseFormTextBox;
            fEnter.Show();
        }

        private void CloseFormTextBox()
        {
            lblHelp.Text = "Угадайте число, что я загадал";
            btnStart.Text = "Начать";
            btnStart.Visible = true;
            tbHistory.Text = string.Empty;
        }

        private void UpdateFromAnotherForm(Game.CheckSate state)
        {
            switch (state)
            {
                case Game.CheckSate.Greate:
                    Update("Слишком много");
                    break;
                case Game.CheckSate.Less:
                    Update("Слишком мало");
                    break;
                case Game.CheckSate.Equal:
                    Update("Верно!");
                    MessageBox.Show($@"Вы победили!
Времени заняло: {game.Stopwatch.Elapsed:g}
Число попыток: {game.NumbersHistoryCount}", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    fEnter.Close();
                    break;
                default:
                    MessageBox.Show("Произошла ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Update(string message)
        {
            tbHistory.Text = $@"{tbHistory.Text}{game.LastNumber}
";
            lblHelp.Text = message;
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            const string about = @"Данная программа является решением задачи:
Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
a) Для ввода данных от человека используется элемент TextBox;
б) **Реализовать отдельную форму c TextBox для ввода числа.

Автор: Илья Горшков";

            MessageBox.Show(about, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string rules = @"Игра в ""Угадай число"":

Компьютер загадывает число от 1 до 100 включительно.
Задача игрока угадать число за минимально возможный промежуток времени и минимальное число попыток.";

            MessageBox.Show(rules, "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}