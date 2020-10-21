using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using FitnessModel;

namespace FitnessView
{
    /// <summary>
    /// Класс создания таблицы
    /// </summary>
    public static class DataActionsView
    {
        /// <summary>
        /// метод создания таблицы
        /// </summary>
        /// <param name="actions">активности</param>
        /// <param name="dataGridView"></param>
        public static void Create(BindingList<ActionsBase> actions,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = actions;

            dataGridView.Columns[0].DataPropertyName = "DistanceOrWeight";
            dataGridView.Columns[1].DataPropertyName = "Time";
            dataGridView.Columns[2].DataPropertyName = "WeightPerson";
            dataGridView.Columns[3].DataPropertyName = "Description";
            dataGridView.Columns[4].DataPropertyName = "KkalCalculation";

            dataGridView.Columns[0].HeaderText = "Дистанция или вес штанги";
            dataGridView.Columns[1].HeaderText = "Время выполнения";
            dataGridView.Columns[2].HeaderText = "Вес человека";
            dataGridView.Columns[3].HeaderText = "Активность";
            dataGridView.Columns[4].HeaderText = "Рассчитанные калории";

            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[1].Width = 90;

            dataGridView.DefaultCellStyle.Format = "0.00";

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
