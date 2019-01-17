using System;
using System.Windows.Forms;

namespace Homework7
{
    public partial class fEnter : Form
    {
        public new delegate void Update(Game.CheckSate state);

        public new delegate void Closing();

        public event Update UpdateEvent;
        public event Closing ClosingEvent;
        private readonly Game game;

        public fEnter(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbInput.Text, out var userNumber))
            {
                var state =  game.CheckUserInput(userNumber);
                UpdateEvent?.Invoke(state);
            }
            else
            {
                MessageBox.Show("Введите целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbInput.Text = string.Empty;
        }

        private void fEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingEvent?.Invoke();
        }
    }
}
