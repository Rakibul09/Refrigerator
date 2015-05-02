using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedType4
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Refrigerator aRefrigerator;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator = new Refrigerator();
            aRefrigerator.maximumWeight = Convert.ToDouble(maximumWeightTextBox.Text);
            maximumWeightTextBox.Clear();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            aRefrigerator.numberOfItems = Convert.ToInt32(itemsTextBox.Text);
            aRefrigerator.weightPerItem = Convert.ToDouble(weightTextBox.Text);
            itemsTextBox.Clear();
            weightTextBox.Clear();

            currentWeightTextBox.Text = aRefrigerator.GetCurrentWeight().ToString();
            remainingWeightTextBox.Text = aRefrigerator.GetRemainingWeight().ToString();
        }
    }
}
