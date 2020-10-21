using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessModel;

namespace FitnessView
{
    /// <summary>
    /// Класс, описывающий форму поиска
    /// </summary>
    public partial class DataSearchForm : Form
    {
        /// <summary>
        /// список основной формы
        /// </summary>
        private BindingList<ActionsBase> _actions;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="actions"></param>
        public DataSearchForm(BindingList<ActionsBase> actions)
        {
            InitializeComponent();

            _actions = actions;
        }

        /// <summary>
        /// Список с результатами поиска
        /// </summary>
        private BindingList<ActionsBase> _actionsSearch =
           new BindingList<ActionsBase>();

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// Метод начала поиска
        /// </summary>
        private void Search()
        {
            _actionsSearch.Clear();

            try
            {
                foreach (var row in _actions)
                {
                    var isTime =
                        radioButton1.Checked
                        && row.Time == Convert.ToDouble(SearchTextBox.Text);
                    var isWeight =
                        radioButton2.Checked
                        && row.WeightPerson == Convert.ToDouble(
                            SearchTextBox.Text);

                    if (isTime || isWeight)
                    {
                        _actionsSearch.Add(row);
                    }

                    dataGridView1.DataSource = _actionsSearch;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message} " +
                     $"\nВведите десятичное число!(Через запятую)");
            }
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Поиск по нажатию клавиши Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataSearchForm_Load(object sender, EventArgs e)
        {
            DataActionsView.Create(_actionsSearch, dataGridView1);
        }
    }
}
