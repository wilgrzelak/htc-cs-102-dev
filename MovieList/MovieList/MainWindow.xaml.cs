﻿using System;
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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Movie> Movies = new List<Movie>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                MessageBox.Show("The movie is" + movie.Title + "\r\n" + "the movie was released in" + movie.ReleaseYear + "The movies director is" + Director);
            }

         }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            String title = titleInput.Text;
            int ReleaseYear = Convert.ToInt32(ReleaseYearInput.Text);
            string Director = DirectorInput.Text;
            int Length = Convert.ToInt32(DirectorInput.Text);
            string Genre = DirectorInput.Text;
            Movie movie = new Movie(title, ReleaseYear, Director, Length);
            Movies.Add(movie);
            MessageBox.Show("Your movie was added!");
        }
    }

}
