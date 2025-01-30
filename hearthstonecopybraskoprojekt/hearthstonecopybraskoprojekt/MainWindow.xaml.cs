using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace hearthstonecopybraskoprojekt
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private string[] availableImages;  // List of available image files

        public MainWindow()
        {
            InitializeComponent();
            LoadImages(); // Load available images at the start
        }

        private void newdraft_Click(object sender, RoutedEventArgs e)
        {
            SetRandomBackgroundImages();  // Set random images to buttons on new draft
        }

        private void SetRandomBackgroundImages()
        {
            // Get image files from the directory
            string directoryPath = @"H:\sišarp\finals\hearthstonecopybraskoprojekt\hearthstonecopybraskoprojekt\obrazky";

            if (Directory.Exists(directoryPath))
            {
                availableImages = Directory.GetFiles(directoryPath, "*.*")
                    .Where(f => f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                if (availableImages.Length >= 3)
                {
                    // Shuffle and set images when the new draft is clicked
                    SetUniqueImagesToButtons();
                }
                else
                {
                    MessageBox.Show("Not enough unique images in the directory (need at least 3).");
                }
            }
            else
            {
                MessageBox.Show("Directory does not exist.");
            }
        }

        private void SetUniqueImagesToButtons()
        {
            // Shuffle the available images list and pick unique ones for each button
            var shuffledImages = availableImages.OrderBy(x => random.Next()).Take(3).ToArray();

            // Set the button background images using the shuffled images
            SetButtonBackground(karta1, shuffledImages[0]);
            SetButtonBackground(karta2, shuffledImages[1]);
            SetButtonBackground(karta3, shuffledImages[2]);

            // Optionally store these image paths in the button's Tag for easy access
            karta1.Tag = shuffledImages[0];
            karta2.Tag = shuffledImages[1];
            karta3.Tag = shuffledImages[2];
        }

        private void karta_Click(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Get the image path associated with this button (stored in Tag)
                string currentImagePath = clickedButton.Tag?.ToString();

                if (!string.IsNullOrEmpty(currentImagePath))
                {
                    // Remove the current image from the list of available images (optional)
                    availableImages = availableImages.Where(img => img != currentImagePath).ToArray();

                    // Set new random images to buttons after a button click
                    SetUniqueImagesToButtons();
                }
            }
        }

        private void SetButtonBackground(Button button, string imagePath)
        {
            // Set the button's background using ImageBrush
            ImageBrush brush = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute)),
                Stretch = Stretch.UniformToFill // Adjust as needed
            };
            button.Background = brush;
        }

        // Load initial available images at startup
        private void LoadImages()
        {
            string directoryPath = @"H:\sišarp\finals\hearthstonecopybraskoprojekt\hearthstonecopybraskoprojekt\obrazky";

            if (Directory.Exists(directoryPath))
            {
                availableImages = Directory.GetFiles(directoryPath, "*.*")
                    .Where(f => f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                    .ToArray();
            }
        }
        private void showdeck_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Show Deck button clicked!");
        }
    }
}