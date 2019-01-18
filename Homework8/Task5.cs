using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Homework8.Models;
using HomeworkFileLibrary;

namespace Homework8
{
    public partial class Task5 : Form
    {
        private IEnumerable<StudentModel> students;

        public Task5()
        {
            InitializeComponent();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Filter = "*.csv|*.csv",
                Title = "Открыть"
            };
            if (openFile.ShowDialog() != DialogResult.OK) return;

            var csv = FileHelper.ParseCsvFile(openFile.FileName);
            students = csv.Select(q => new StudentModel(q));
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var xmlSer = new XmlSerializer(typeof(List<StudentModel>));

            var saveFile = new SaveFileDialog
            {
                Filter = "*.xml|*.xml",
                Title = "Сохранить"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;

            using (var fs = new FileStream(saveFile.FileName, FileMode.Create))
            {
                xmlSer.Serialize(fs, students.ToList());
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок)

Автор: Илья Горшков",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
                Close();
        }

        private bool CheckExit()
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private void Task5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CheckExit();
        }
    }
}
