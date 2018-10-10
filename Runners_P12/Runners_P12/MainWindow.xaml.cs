using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Runners_P12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        namespace runner
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
    //        List<Runner> lsRunners = new List<Runner> { }; // List of Runners

    //        public MainWindow()
    //        {
    //            InitializeComponent();
    //        }

    //        /// <summary>
    //        /// Custom runner class, each runner has name, age, and time values
    //        /// </summary>
    //        public class Runner
    //        {
    //            public string Name;
    //            public int Age;
    //            public TimeSpan Time;
    //            // Create new runner with specified values
    //            public Runner(string strName, string strAge, string strMM, string strSS)
    //            {
    //                Name = strName;
    //                Age = Convert.ToInt32(strAge);
    //                Time = new TimeSpan(0, Convert.ToInt32(strMM), Convert.ToInt32(strSS));
    //            }
    //        }

    //        /// <summary>
    //        /// Add runner to list in order of time
    //        /// </summary>
    //        /// <param name="nwRunner"> Runner to add </param>
    //        /// <returns> Sorted list of runners </returns>
    //        public List<Runner> AddSortedRunners(Runner nwRunner)
    //        {
    //            int len = lsRunners.Count; // Get current number of recorded runners
    //            if (len == 0) { lsRunners.Add(nwRunner); return lsRunners; } // If it is the first element, simply add it
    //            List<Runner> lsSortedRunners = new List<Runner>(); // Create resultant sorted list
    //            int lsi = 0;
    //            while (lsi < len)
    //            // Add the runner with the lowest time (insert new runner in relevant index)
    //            // Only works as each runner is added to an already sorted list
    //            {
    //                if (lsRunners[lsi].Time > nwRunner.Time) { lsSortedRunners.Add(nwRunner); break; }
    //                lsSortedRunners.Add(lsRunners[lsi++]);

    //            }
    //            while (lsi < len) { lsSortedRunners.Add(lsRunners[lsi++]); } // Get remaining runners
    //            return lsSortedRunners;
    //        }

    //        /// <summary>
    //        /// Record new runner
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        public void btnAdd_Click(object sender, RoutedEventArgs e)
    //        {
    //            // Check for invalid inputs
    //            try
    //            {
    //                Runner nwRunner = new Runner(txtName.Text, txtAge.Text, txtMM.Text, txtSS.Text);
    //                lsRunners = AddSortedRunners(nwRunner); // Keep list sorted
    //            }
    //            catch (InvalidCastException ex)
    //            {
    //                MessageBox.Show("Please check the values you have entered are valid" + ex.ToString(), "Value Error");
    //            }
    //            // Reset window
    //            txtName.Clear();
    //            txtAge.Clear();
    //            txtMM.Clear();
    //            txtSS.Clear();
    //            txtName.Focus();
    //        }

    //        /// <summary>
    //        /// Show recorded runners
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnRunners_Click(object sender, RoutedEventArgs e)
    //        {
    //            txtRunners.Clear(); // Reset
    //                                // Check for empty list
    //            try
    //            {
    //                foreach (Runner runner in lsRunners)
    //                {
    //                    txtRunners.Text += runner.Name + ": \n Age: " + runner.Age + "\n Time: " + runner.Time + "\n";
    //                }
    //            }
    //            catch (NullReferenceException ex)
    //            {
    //                MessageBox.Show("Please add runners" + ex.ToString(), "No Recorded Runners Error");
    //            }
    //        }

    //        /// <summary>
    //        /// Analyse runner data
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnAnalyse_Click(object sender, RoutedEventArgs e)
    //        {
    //            txtRunners.Clear(); // Reset textbox
    //            int intSum = 0, c15 = 0, cMid = 0, cOld = 0, len = lsRunners.Count;
    //            TimeSpan tmSum = new TimeSpan();
    //            double avAge = -1;
    //            TimeSpan avTime = TimeSpan.Zero;
    //            // Check for invalid inputs and empty list
    //            try
    //            {
    //                // Add relevant data
    //                foreach (Runner runner in lsRunners)
    //                {
    //                    tmSum.Add(runner.Time);
    //                    intSum += runner.Age; // Get sums of age and time for averages
    //                    if (runner.Age > 15 && runner.Age < 30) { cMid++; }
    //                    else if (runner.Age <= 15) { c15++; }
    //                    else { cOld++; } // Check age ranges
    //                }
    //                // Get averages
    //                avAge = intSum / len;
    //                avTime = TimeSpan.FromMilliseconds(tmSum.TotalMilliseconds / len);
    //            }
    //            catch (DivideByZeroException ex)
    //            {
    //                MessageBox.Show("Please add runners" + ex.ToString(), "No Recorded Runners Error");
    //            }
    //            catch (InvalidCastException ex)
    //            {
    //                MessageBox.Show("Please check the values you have entered are valid" + ex.ToString(), "Value Error");
    //            }

    //            // Display analysis results
    //            txtRunners.Text += string.Format("The winner is: {0} \n", lsRunners[0].Name);
    //            txtRunners.Text += string.Format("The average time is: {0} \n", avTime);
    //            txtRunners.Text += string.Format("The average age is: {0} \n", avAge);
    //            if (c15 == 0) { txtRunners.Text += "15 or younger: None \n"; }
    //            else { txtRunners.Text += string.Format("15 or younger: {0} \n", c15); }
    //            if (cMid == 0) { txtRunners.Text += "16 - 29: None \n"; }
    //            else { txtRunners.Text += string.Format("16 - 29: {0} \n", cMid); }
    //            if (cOld == 0) { txtRunners.Text += "30 or older: None \n"; }
    //            else { txtRunners.Text += string.Format("30 or older: {0} \n", cOld); }
    //        }
    //    }
    //}
}
}
