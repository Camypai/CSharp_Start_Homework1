using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Homework8.Models;

namespace Homework8
{
    public partial class Task4 : Form
    {
        private readonly DbContext _db = new DbContext();
        private readonly BindingSource _bindingSource = new BindingSource();
        private List<BirthdayModel> _birthdayModels;

        public Task4()
        {
            InitializeComponent();
        }

        private void tsmiCreateBD_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                Filter = "*.json|*.json",
                Title = "Создать базу данных"
            };
            if (saveFile.ShowDialog() != DialogResult.OK) return;
            _db.BirthdayRepository = new JsonRepository<BirthdayModel>(saveFile.FileName);
            _bindingSource.DataSource = _db.BirthdayRepository.Get();
            _birthdayModels = _db.BirthdayRepository.Get();
            bnBirthday.BindingSource = _bindingSource;
            dgvBirthday.DataSource = _bindingSource;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            _db.BirthdayRepository.Create((List<BirthdayModel>) _bindingSource.DataSource);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _birthdayModels.Add(new BirthdayModel());
        }

        private void дниРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Filter = "*.json|*.json",
                Title = "Открыть базу данных"
            };

            if (openFile.ShowDialog() != DialogResult.OK) return;
            _db.BirthdayRepository = new JsonRepository<BirthdayModel>(openFile.FileName, true);
            _bindingSource.DataSource = _db.BirthdayRepository.Get();
            _birthdayModels = _db.BirthdayRepository.Get();
            bnBirthday.BindingSource = _bindingSource;
            dgvBirthday.DataSource = _bindingSource;
        }
    }
}