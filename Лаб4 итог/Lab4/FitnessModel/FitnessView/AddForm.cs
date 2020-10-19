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
        /// Поле для создания расчёта калорий
        /// </summary>
        private ActionsBase _action;

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
            RadioButtonRun.Checked = true;
            numericUpDownWeight.Value = Convert.ToDecimal(
                ActionsBase.MinWeight);
            ComboBoxSwimmingStyles.DataSource = Enum.GetValues(
                typeof(SwimmingEnum));
            ComboBoxSwimmingStyles.SelectedIndex = -1;

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
        /// Ввод данных по нажатию клавиши Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertData();
            }
        }

        /// <summary>
        /// Установка данных в поля активностей
        /// </summary>
        private void InsertData()
        {
            _action.WeightPerson = 
                Convert.ToDouble(numericUpDownWeight.Text);

            _action.Time = Convert.ToDouble(numericUpDownTime.Text);

            if (_action is Run run)
            {
                run.Intensive = 
                    Convert.ToDouble(numericUpDownIntensive.Text);
                run.DistanceOrWeight = 
                    Convert.ToDouble(numericUpDownDistance.Text);
            }

            if (_action is BenchPress benchPress)
            {
                benchPress.DistanceOrWeight = 
                    Convert.ToDouble(numericUpDownGirya.Text);
                benchPress.Iteration = 
                    Convert.ToDouble(numericUpDownPodxody.Text);
            }

            if (_action is Swimming swimming)
            {
                swimming.DistanceOrWeight = 
                    Convert.ToDouble(numericUpDownDistance.Text);

                if (ComboBoxSwimmingStyles.SelectedIndex != -1)
                {
                    swimming.SwimmingEnum = 
                        (SwimmingEnum)ComboBoxSwimmingStyles.SelectedIndex +
                        1;
                }
            }
        }

        /// <summary>
        /// Внесение активности в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            InsertData();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Генерация случайной активности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            _action = RandomAction.CreateAction();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Переключение вида упражнения с бега / на бег
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonRun_CheckedChanged(object sender, 
            EventArgs e)
        {
            if (RadioButtonRun.Checked)
            {
                ChangeEnabledPropertyOfTextBoxes();
                
                _action = new Run();
                InsertData();
                TextBoxResult.Text = _action.KkalCalculation.ToString(
                    "0.00");
            }
        }

        /// <summary>
        /// Переключение вида упражнения с плавания / на плавание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonSwimming_CheckedChanged(object sender,
            EventArgs e)
        {
            if (RadioButtonSwimming.Checked)
            {
                ChangeEnabledPropertyOfTextBoxes();
                
                _action = new Swimming();
                InsertData();
                TextBoxResult.Text = _action.KkalCalculation.ToString(
                    "0.00");
            }
        }

        /// <summary>
        /// Переключение вида упражнения с жима / на жим
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonBenchPress_CheckedChanged(object sender,
            EventArgs e)
        {
            if (RadioButtonBenchPress.Checked)
            {
                ChangeEnabledPropertyOfTextBoxes();

                _action = new BenchPress();
                InsertData();
                TextBoxResult.Text = _action.KkalCalculation.ToString(
                    "0.00");
            }
        }

        /// <summary>
        /// Включение / выключение полей при изменении вида упражнения
        /// </summary>
        private void ChangeEnabledPropertyOfTextBoxes()
        {
            numericUpDownIntensive.Enabled = RadioButtonRun.Checked;
            numericUpDownDistance.Enabled = (RadioButtonRun.Checked ||
                RadioButtonSwimming.Checked);
            numericUpDownPodxody.Enabled = RadioButtonBenchPress.Checked;
            numericUpDownGirya.Enabled = RadioButtonBenchPress.Checked;
            ComboBoxSwimmingStyles.Enabled = RadioButtonSwimming.Checked;
        }

        /// <summary>
        /// Изменение значения веса человека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpAndDownWeight_ValueChanged(object sender,
            EventArgs e)
        {
            _action.WeightPerson = Convert.ToDouble(
                numericUpDownWeight.Value);
            TextBoxResult.Text = _action.KkalCalculation.ToString("0.00");
        }

        /// <summary>
        /// Изменение значения времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownTime_ValueChanged(object sender, 
            EventArgs e)
        {
            _action.Time = Convert.ToDouble(
                numericUpDownTime.Value);
            TextBoxResult.Text = _action.KkalCalculation.ToString("0.00");
        }

        /// <summary>
        /// Изменение значения интенсивности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownIntensive_ValueChanged(object sender, 
            EventArgs e)
        {
            (_action as Run).Intensive = Convert.ToDouble(
                numericUpDownIntensive.Value);
            TextBoxResult.Text = _action.KkalCalculation.ToString("0.00");
        }

        /// <summary>
        /// Изменение значения дистанции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownDistance_ValueChanged(object sender, 
            EventArgs e)
        {
            _action.DistanceOrWeight = Convert.ToDouble(
                numericUpDownDistance.Value);
            TextBoxResult.Text = _action.KkalCalculation.ToString("0.00");
        }

        /// <summary>
        /// Изменение значения количества подходов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownPodxody_ValueChanged(object sender, 
            EventArgs e)
        {
            (_action as BenchPress).Iteration = Convert.ToDouble(
                numericUpDownPodxody.Value);
            TextBoxResult.Text = _action.KkalCalculation.ToString("0.00");
        }

        /// <summary>
        /// Изменение значения веса гири
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownGirya_ValueChanged(object sender, 
            EventArgs e)
        {
            _action.DistanceOrWeight = Convert.ToDouble(
                numericUpDownGirya.Value);
            TextBoxResult.Text = _action.KkalCalculation.ToString("0.00");
        }

        /// <summary>
        /// Изменение значения типа плавания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSwimmingStyles_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (_action is Swimming)
            {
                (_action as Swimming).SwimmingEnum = 
                    (SwimmingEnum)(ComboBoxSwimmingStyles.SelectedIndex + 1);

                TextBoxResult.Text = 
                    _action.KkalCalculation.ToString("0.00");
            }
        }
    }
}
