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

namespace CSIS1175_003F2019FernandoCasalotiSilvaAS4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nameRbtn.Checked = true;
        }

        //Sort by name button
        private void sortNameBtn_Click(object sender, EventArgs e)
        {
            //Open Files and create arrays
            StreamReader inFile;
            inFile = File.OpenText("MovieRevenue.txt");
            int arraySize = File.ReadLines("MovieRevenue.txt").Count();
            inFile.Close();
            string[] movie = new string[arraySize];
            double[] revenueSorted = new double[arraySize];

            //Read File and write in arrays
            ReadIntoArray(movie, revenueSorted);

            //Selection Sort
            SelectionSortByName(movie, revenueSorted);

            searchTb.Text = "";
            resultsLb.Items.Clear();
            for (int idx = 0; idx < movie.Length; idx++)
            {
                DisplayRevenue(movie, revenueSorted, idx, " >===> ");
            }
        }

        //Sort by Revenue button
        private void sortRevenueBtn_Click(object sender, EventArgs e)
        {
            //Open Files and create arrays
            StreamReader inFile;
            inFile = File.OpenText("MovieRevenue.txt");
            int arraySize = File.ReadLines("MovieRevenue.txt").Count();
            inFile.Close();
            string[] movie = new string[arraySize];
            double[] revenueSorted = new double[arraySize];

            //Read File and write in arrays
            ReadIntoArray(movie, revenueSorted);

            //Selection Sort
            SelectionSortByRevenue(movie, revenueSorted);

            searchTb.Text = "";
            resultsLb.Items.Clear();
            for (int idx = 0; idx < movie.Length; idx++)
            {
                DisplayRevenue(movie, revenueSorted, idx, " <===< ");
            }
        }

        //Read file and write on Arrays
        private void ReadIntoArray(string[] movieArray, double[] revenueArray)
        {

            //Open Files
            StreamReader inFile;
            inFile = File.OpenText("MovieRevenue.txt");

            //Loop to read lines of the file and insert in the arrays
            int idx = 0;
            while (!inFile.EndOfStream)
            {
                //Read each line, trim empty spaces, separate movie and revenue and insert in the arrays
                string dataFile = "";
                dataFile = inFile.ReadLine().Trim();
                char[] delim = { '{', '}', '@', '=', '#' };
                string[] divided = dataFile.Split(delim);

                //Insert the content split into different arrays
                movieArray[idx] = divided[0];
                revenueArray[idx] = double.Parse(divided[1]);

                //Increase idx
                idx += 1;
            }

            //Close File
            inFile.Close();
        }

        //Sort by Name
        private void SelectionSortByName(string[] arr, double[] arr1)
        {
            int smallest, idx, idx1;
            double temp;
            string temp1;
            for (idx = 0; idx < arr.Length - 1; idx++)
            {
                smallest = idx;
                for (idx1 = idx + 1; idx1 < arr.Length; idx1++)
                {
                    if (string.Compare(arr[idx1], arr[smallest], true) < 0)
                    {
                        smallest = idx1;
                    }
                }
                //SelectionSort Movie
                temp1 = arr[smallest];
                arr[smallest] = arr[idx];
                arr[idx] = temp1;

                //Change position Revenue
                temp = arr1[smallest];
                arr1[smallest] = arr1[idx];
                arr1[idx] = temp;
            }
        }

        //Sort by Revenue
        private void SelectionSortByRevenue(string[] arr, double[] arr1)
        {
            int highest, idx, idx1;
            double temp;
            string temp1;
            for (idx = 0; idx < arr1.Length - 1; idx++)
            {
                highest = idx;
                for (idx1 = idx + 1; idx1 < arr1.Length; idx1++)
                {
                    if (arr1[idx1] > arr1[highest])
                    {
                        highest = idx1;
                    }
                }
                //SelectionSort Revenue
                temp = arr1[highest];
                arr1[highest] = arr1[idx];
                arr1[idx] = temp;

                //Change position Movie
                temp1 = arr[highest];
                arr[highest] = arr[idx];
                arr[idx] = temp1;
            }
        }

        // Search button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Open Files and create arrays
            StreamReader inFile;
            inFile = File.OpenText("MovieRevenue.txt");
            int arraySize = File.ReadLines("MovieRevenue.txt").Count();
            inFile.Close();
            string[] movie = new string[arraySize];
            double[] revenueSorted = new double[arraySize];

            searchMovies(movie, revenueSorted);
            revenueSearch(movie, revenueSorted);            
        }

        //Search by movies name
        private void searchMovies(string []arr,double[]arr1)
        {
            //List movies when search is empty
            if (nameRbtn.Checked && searchTb.Text == "")
            {
                //Read File and write in arrays
                ReadIntoArray(arr, arr1);

                //Selection Sort
                SelectionSortByName(arr, arr1);

                //Display results on listbox
                resultsLb.Items.Clear();
                for (int idx = 0; idx < arr.Length; idx++)
                {
                    DisplayRevenue(arr, arr1, idx, " >===> ");
                }
            }

            //Search movies by name
            if (nameRbtn.Checked && searchTb.Text != "")
            {
                string search = searchTb.Text.Trim();

                //Read File and write in arrays
                ReadIntoArray(arr, arr1);

                //Selection Sort
                SelectionSortByName(arr, arr1);

                //Verify name inside array - Name
                if (containsName(arr, arr1, search))
                    containsName(arr, arr1, search);
            }
        }

        //Verify text inside movie's name
        private bool containsName(string[] arr, double[] arr1, string compare)
        {
            bool validation = false;
            resultsLb.Items.Clear();
            for (int idx = 0; idx < arr.Length; idx++)
            {
                if (arr[idx].IndexOf(compare, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    DisplayRevenue(arr, arr1, idx, " >===> ");

                    validation = true;
                }
            }
            if (!(validation))
                resultsLb.Items.Add("No movie titles with those characters");

            return validation;
        }

        //Search by revenue
        private void revenueSearch(string []arr,double[]arr1)

        {

            if (revenueRbtn.Checked && searchTb.Text == "")
            {
                resultsLb.Items.Clear();
                MessageBox.Show("Not numeric - please re-enter");
            }

            if (revenueRbtn.Checked && searchTb.Text != "")
            {
                //Read File and write in arrays
                ReadIntoArray(arr, arr1);

                //Selection Sort
                SelectionSortByRevenue(arr, arr1);

                //Evaluate if it is number inserted in search
                if (double.TryParse(searchTb.Text.Trim(), out double search))
                {
                    BinSrch(arr, arr1, search);
                    int found = BinSrch(arr, arr1, search);
                    resultsLb.Items.Clear();
                    if (search == arr1[found])
                    {
                        for (int idx = found; idx < arr.Length; idx++)
                        {
                            if (idx == found)
                            {
                                DisplayRevenue(arr, arr1, idx, " <===< ", " ***** EXACT");
                            }
                            else
                            {
                                DisplayRevenue(arr, arr1, idx, " <===< ");
                            }
                        }
                    }
                    else
                    {
                        int linearSearch = LinearSrch(arr, arr1, search);
                        resultsLb.Items.Add("No Movie has this EXACT revenue");
                        resultsLb.Items.Add("===============================");

                        for (int idx = linearSearch; idx < arr.Length; idx++)
                        {
                            if (idx == linearSearch)
                            {
                                DisplayRevenue(arr, arr1, idx, " <===< ", " (**closest**)");
                            }
                            else
                            {
                                DisplayRevenue(arr, arr1, idx, " <===< ");
                            }
                        }
                    }
                }
                else
                {
                    resultsLb.Items.Clear();
                    MessageBox.Show("Not numeric - please re-enter");
                }
             }
        }

        //Linear search in Revenue array
        private int LinearSrch(string[] arr, double[] arr1, double num)
        {
            int index = 0;
            for (int idx = 0; idx < arr.Length; idx++)
                if (arr1[idx] > num)
                    index = idx + 1;
            
            return index;
        }

        //Binary search in revenue array
        private int BinSrch(string[] arr, double[]arr1, double num)
        {
            int first = 0;
            int last = arr.Length - 1;
            int mid = -1;

            while (first <= last)
            {
                mid = (first + last) / 2;

                if (arr1[mid] == num)
                {
                    break;
                }
                else
                    if (arr1[mid] > num)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
            return mid;
        }

        //Display on listbox
        private void DisplayRevenue(string[] arr, double[] arr1, int index, string comp1 = "", string comp2 = "")
        {
            resultsLb.Items.Add(arr[index] + comp1 + arr1[index].ToString("c2") + comp2);
        }
    }
}
