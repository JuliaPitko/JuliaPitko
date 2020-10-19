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
    /// добавление активности
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Поле для создния расчёта калорий
        /// </summary>
        private ActionsBase _action;

        /// <summary>
        /// Флаг корректности
        /// </summary>
        private bool _isCorrect;

        /// <summary>
        /// Свойство 
        /// </summary>
        public ActionsBase ActionsDone
        {
            get
            {
                return _action;
            }
        }

        /// <summary>
        /// Метод, инициализирующий форму
        /// </summary>
        public AddForm()
        {
            InitializeComponent();

            #if !DEBUG
            RandomButton.Visible = false;
            #endif
        }


        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Вывод данных
        /// </summary>
        private void DisplayData()
        {
            textBoxWeight.Text =
                _action.WeightPerson.ToString();
            textBoxTime.Text = _action.Time.ToString();
            TextBoxResult.Text =
                _action.KkalCalculation.ToString();

            if (_action is Run run)
            {
                textBoxIntensive.Text =
                    run.Intensive.ToString();
                textBoxDistance.Text =
                    run.DistanceOrWeight.ToString();
            }

            if(_action is BenchPress benchPress)
            {
                textBoxGirya.Text =
                    benchPress.DistanceOrWeight.ToString();
                textBoxPodxody.Text =
                    benchPress.Iteration.ToString();
            }

            if(_action is Swimming swimming)
            {
                textBoxDistance.Text =
                    swimming.DistanceOrWeight.ToString();
            }
        }

        private void Visible(ActionsBase actions)
        {
            if (actions is Run)
            {
                textBoxPodxody.Visible = false;
                textBoxGirya.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label1.Visible = false;
                comboBox1.Visible = false;
            }

            if (actions is BenchPress)
            {
                textBoxIntensive.Visible = false;
                textBoxDistance.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label1.Visible = false;
                comboBox1.Visible = false;
            }

            if (actions is Swimming)
            {
                textBoxPodxody.Visible = false;
                textBoxGirya.Visible = false;
                textBoxIntensive.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertData();
            }
        }

        private void InsertData()
        {
            _isCorrect = false;

            try
            {
                _action.WeightPerson = 
                    Convert.ToDouble(textBoxWeight.Text);

                _action.Time = Convert.ToDouble(textBoxTime.Text);

                if (_action is Run run)
                {
                    run.Intensive = 
                        Convert.ToDouble(textBoxIntensive.Text);
                    run.DistanceOrWeight = 
                        Convert.ToDouble(textBoxDistance.Text);
                }

                if (_action is BenchPress benchPress)
                {
                    benchPress.DistanceOrWeight = 
                        Convert.ToDouble(textBoxGirya.Text);
                    benchPress.Iteration = 
                        Convert.ToDouble(textBoxPodxody.Text);
                }

                if (_action is Swimming swimming)
                {
                    swimming.DistanceOrWeight = 
                        Convert.ToDouble(textBoxDistance.Text);
                }

                DisplayData();

                _isCorrect = true;
            }

            catch (Exception exception)
            {
                _isCorrect = false;

                MessageBox.Show($"{exception.Message} "
                    + $"\nВведите десятичное число через запятую");
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            InsertData();

            if (_isCorrect)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            _action = RandomAction.CreateAction();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
