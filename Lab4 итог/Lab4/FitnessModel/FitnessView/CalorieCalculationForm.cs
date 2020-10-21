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
using System.Runtime.Serialization.Formatters.Binary;
using FitnessModel;
using System.Threading;
using System.Net.Http.Headers;


namespace FitnessView
{
    public partial class CalorieCalculationForm : Form
    {
        /// <summary>
        /// лист параметров 
        /// </summary>
        private BindingList<ActionsBase> _actions = 
            new BindingList<ActionsBase>();

        /// <summary>
        /// загрузка формы
        /// </summary>
        public CalorieCalculationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// открытие формы расчёта параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddActions_Click(object sender, EventArgs e)
        {
            var action = new AddForm();

            if (action.ShowDialog() == DialogResult.OK)
            {
                _actions.Add(action.ActionsDone);
            }
        }

        /// <summary>
        /// Удаление элементов списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var deleteCount = DataActionView.SelectedRows.Count;

            for (int i = 0; i < deleteCount; i++)
            {
                _actions.RemoveAt(DataActionView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// закрытие форма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = new DataSearchForm(_actions);
            search.Show();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalorieCalculationForm_Load(object sender, EventArgs e)
        {
            DataActionsView.Create(_actions, DataActionView);
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string path = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);
                saveFileDialog.InitialDirectory = path;
                saveFileDialog.Filter = "Actions files " +
                    "(*.fit)|*.fit|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var actions = new List<ActionsBase>(_actions);
                    var formatter = new BinaryFormatter();
                    var fileSave = saveFileDialog.FileName;
                    using (var fileStream = new FileStream(
                        fileSave, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fileStream, actions);
                        MessageBox.Show("Файл сохранен");
                    }
                }
            }
        }

        /// <summary>
        /// загрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Actions files (*.fit)|*.fit";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                        {
                            var newActions = 
                                (List<ActionsBase>)formatter.
                                Deserialize(fileStream);

                            foreach (var action in newActions)
                            {
                                _actions.Add(action);
                            }
                        }

                        DataActionView.DataSource = _actions;
                    }
                    catch
                    {
                        MessageBox.Show("Файл поврежден, " +
                            "невозможно загрузить!");
                    }
                }
            }
        }
    }
}
