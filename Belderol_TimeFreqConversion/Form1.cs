namespace Belderol_ConversionAct6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_freq.Enabled = !rdbtn_perfreq.Checked;
            txt_time.Enabled = rdbtn_perfreq.Checked;
        }

        private void rdbtn_freqper_CheckedChanged(object sender, EventArgs e)
        {
            txt_time.Enabled = !rdbtn_freqper.Checked;
            txt_freq.Enabled = rdbtn_freqper.Checked;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected.
            if (rdbtn_perfreq.Checked)
            {
                // Conversion from period to frequency.
                double periodValue;
                if (double.TryParse(txt_time.Text, out periodValue))
                {
                    // Get the selected time unit from the combo box.
                    string selectedTimeUnit = cmb_timeunit.SelectedItem.ToString();

                    // Implement the conversion logic based on the selected time unit.
                    double frequencyValue = ConvertToFrequency(periodValue, selectedTimeUnit);

                    // Display the result in the txt_freq textbox.
                    txt_freq.Text = frequencyValue.ToString();
                }
            }
            else if (rdbtn_freqper.Checked)
            {
                // Conversion from frequency to period.
                double frequencyValue;
                if (double.TryParse(txt_freq.Text, out frequencyValue))
                {
                    // Get the selected frequency unit from the combo box.
                    string selectedFreqUnit = cmb_frequnit.SelectedItem.ToString();

                    // Implement the conversion logic based on the selected frequency unit.
                    double periodValue = ConvertToPeriod(frequencyValue, selectedFreqUnit);

                    // Display the result in the txt_time textbox.
                    txt_time.Text = periodValue.ToString();
                }
            }
        }

        public double ConvertToFrequency(double period, string timeUnit)
        {
            Dictionary<string, double> unitFactors = new Dictionary<string, double>
            {
                { "Seconds", 1 },
                { "Milliseconds", 1e-3 },
                { "Microseconds", 1e-6 },
                { "Nanoseconds", 1e-9 },
                { "Picoseconds", 1e-12 }
            };

            double periodInSeconds;

            periodInSeconds = period * unitFactors[timeUnit];

            double frequency = 1.0 / periodInSeconds;
            return frequency;
        }

        public double ConvertToPeriod(double frequency, string freqUnit)
        {
            double frequencyInHertz;

            Dictionary<string, double> unitFactors = new Dictionary<string, double>
            {
                { "hertz", 1 },
                { "kilohertz", 1e3 },
                { "megahertz", 1e6 },
                { "gigahertz", 1e9 },
                { "terahertz", 1e12 }
            };

            frequencyInHertz = frequency * unitFactors[freqUnit];

            double period = 1.0 / frequencyInHertz;
            return period;
        }

    }
}