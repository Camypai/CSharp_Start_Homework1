using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Homework8.Models;

namespace Homework8
{
    public partial class Task4 : Form
    {
        private readonly DbContext _db = new DbContext();
        private readonly BindingSource _bindingSourceBirth = new BindingSource();
        private readonly BindingSource _bindingSourceNote = new BindingSource();
        private List<BirthdayModel> _birthdayModels;
        private List<NoteModel> _noteModels;

        public Task4()
        {
            InitializeComponent();
        }

        private void tsmiCreateBD_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                Filter = "*.json|*.json",
                Title = "Создать базу данных дней рождений"
            };
            if (saveFile.ShowDialog() != DialogResult.OK) return;
            _db.BirthdayRepository = new JsonRepository<BirthdayModel>(saveFile.FileName);
            _bindingSourceBirth.DataSource = _db.BirthdayRepository.Get();
            _birthdayModels = _db.BirthdayRepository.Get();
            bnBirthday.BindingSource = _bindingSourceBirth;
            dgvBirthday.DataSource = _bindingSourceBirth;
        }

        private void tsmiCreateNotes_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                Filter = "*.json|*.json",
                Title = "Создать базу данных заметок"
            };
            if (saveFile.ShowDialog() != DialogResult.OK) return;
            _db.NoteRepository = new JsonRepository<NoteModel>(saveFile.FileName);
            _bindingSourceNote.DataSource = _db.NoteRepository.Get();
            _noteModels = _db.NoteRepository.Get();
            bnNotes.BindingSource = _bindingSourceNote;
            dgvNotes.DataSource = _bindingSourceNote;
        }

        private void tsmiSaveBD_Click(object sender, EventArgs e)
        {
            _db.BirthdayRepository.Create((List<BirthdayModel>) _bindingSourceBirth.DataSource);
        }

        private void bnAddBD_Click(object sender, EventArgs e)
        {
            _birthdayModels.Add(new BirthdayModel());
        }

        private void tsmiOpenBD_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Filter = "*.json|*.json",
                Title = "Открыть базу данных дней рождений"
            };

            if (openFile.ShowDialog() != DialogResult.OK) return;
            _db.BirthdayRepository = new JsonRepository<BirthdayModel>(openFile.FileName, true);
            _bindingSourceBirth.DataSource = _db.BirthdayRepository.Get();
            _birthdayModels = _db.BirthdayRepository.Get();
            bnBirthday.BindingSource = _bindingSourceBirth;
            dgvBirthday.DataSource = _bindingSourceBirth;
        }

        private void tsmiOpenNotes_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Filter = "*.json|*.json",
                Title = "Открыть базу данных заметок"
            };
            if (openFile.ShowDialog() != DialogResult.OK) return;
            _db.NoteRepository = new JsonRepository<NoteModel>(openFile.FileName, true);
            _bindingSourceNote.DataSource = _db.NoteRepository.Get();
            _noteModels = _db.NoteRepository.Get();
            bnNotes.BindingSource = _bindingSourceNote;
            dgvNotes.DataSource = _bindingSourceNote;
        }

        private void tsmiSaveNotes_Click(object sender, EventArgs e)
        {
            _db.NoteRepository.Create((List<NoteModel>) _bindingSourceNote.DataSource);
        }

        private void bnAddNotes_Click(object sender, EventArgs e)
        {
            _noteModels.Add(new NoteModel());
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckExit()
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return false;

            result = MessageBox.Show("Сохранить изменения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tsmiSaveBD.PerformClick();
                tsmiSaveNotes.PerformClick();
            }

            return true;
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных

Автор: Илья Горшков",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Task4_FormClosed(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CheckExit();
        }
    }
}