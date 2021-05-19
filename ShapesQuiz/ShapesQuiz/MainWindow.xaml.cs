using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ShapesQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Shape> Shapes { get; } = new();

        public MainWindow()
        {
            InitializeComponent();
            Shapes.Clear();
            DataContext = this;
        }

       
        private void Rectangle_Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(TextBoxA.Text, out double a);
            double.TryParse(TextBoxB.Text, out double b);

            var shape = new Shape() { FigureName = "Rectangle", A = a, B = b, Area = Math.Round(a * b, 2) };

            Shapes.Add(shape);
            var sumCount = Convert.ToSingle(TextBlockSum.Text);
            sumCount += (float)shape.Area.Value;
            textBlockSpace.Text = $"{shape.Area.Value}";
            TextBlockSum.Text = $"{ sumCount }";

        }
        private void Triangle_Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(TextBoxA.Text, out double a);
            double.TryParse(TextBoxB.Text, out double b);
            double.TryParse(TextBoxHeight.Text, out double height);

            var shape = new Shape() { FigureName = "Triangle", A = a, B = b, Height = height, Area = Math.Round(((a * height) / 2.0), 2) };

            Shapes.Add(shape);
            var sumCount = Convert.ToSingle(TextBlockSum.Text);
            sumCount += (float)shape.Area.Value;
            textBlockSpace.Text = $"{shape.Area.Value}";
            TextBlockSum.Text = $"{ sumCount }";
        }

        public void Circle_Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(TextBoxRadius.Text, out double radius);

            var shape = new Shape() { FigureName = "Circle", Radius = radius, Area = Math.Round(Math.PI * Math.Pow(radius, 2), 2) };

            Shapes.Add(shape);
            var sumCount = Convert.ToSingle(TextBlockSum.Text);
            sumCount += (float)shape.Area.Value;
            textBlockSpace.Text = $"{shape.Area.Value}";
            TextBlockSum.Text = $"{ sumCount }";
        }
    }
}
