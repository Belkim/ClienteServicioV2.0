using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Newtonsoft.Json;
using ClienteServicioV2._0.Models;
using ClienteServicioV2._0.Services;
using System.Net.Http;

namespace ClienteServicioV2._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        circleReference.Service1Client Client = new circleReference.Service1Client("BasicHttpsBinding_IService1");
        circleReference.RingDTO circulo = new circleReference.RingDTO();
        public Square squareG;
        public Triangle triangleG;
        public readonly HttpClient client = new HttpClient();
        public static SquaresServices sqService;
        public static TrianglesServices trService;

        public async void ListSquares()
        {
            dynamic result = await sqService.ListSquares();
            Object myObject = result;
            if (myObject.GetType().Name == "String")
            {
                dgCuad.ItemsSource= myObject.ToString();
                MessageBox.Show(myObject.ToString());
            }
            else
            {
                Console.WriteLine("Elementos listados.");
            }
        }

        public async void ListTriangles()
        {
            dynamic result = await trService.ListTriangles();
            Object myObject = result;
            if (myObject.GetType().Name == "String")
            {
                dgCirc.ItemsSource=result;
                MessageBox.Show(result);
            }
            else
            {
                Console.WriteLine("Triangulos listados.");
            }
        }

        public async Task<dynamic> CreateSquare(Cuadrado sq)
        {
            dynamic result = await sqService.CreateSquares(sq);
            Object myObject = result;
            if (myObject.GetType().Name == "String")
            {
                MessageBox.Show(result);
                return null;
            }
            else
            {
                MessageBox.Show("Elemento creado con el id: " + result.Id);
                squareG = result;
                return result;
            }
        }

        public async Task<dynamic> CreateTriangle(Triangle tr)
        {
            dynamic result = await trService.CreateTriangle(tr);
            Object myObject = result;
            if (myObject.GetType().Name == "String")
            {
                MessageBox.Show(result);
                return null;
            }
            else
            {
                MessageBox.Show("Elemento creado con el id: " + result.Id);
                triangleG = result;
                return result;
            }
        }

        public MainWindow()
        {
            sqService = new SquaresServices(client);
            trService = new TrianglesServices(client);
            InitializeComponent();
        }

        private void rectangle6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void rectangle7_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void rectangle8_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void rectangle9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void rectangle1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }




        private void txtCuadrado_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        //CIRCULO
        private void btnCalcularCirc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                circulo.Radius = double.Parse(txtCirc.Text);
                var temp = Client.CreateRing(circulo);
                txtAreaCirc.Text = temp.Area.ToString();
                txtPerCirc.Text = temp.Perimeter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var lista = Client.ListRings();
            try
            {
                dgCirc.ItemsSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //CUADRADO
        private async void btnCalcularCuad_Click(object sender, RoutedEventArgs e)
        {
            Cuadrado square = new Cuadrado();
            square.lado = float.Parse(txtCuadrado.Text);
            dynamic result = await CreateSquare(square);
            Object myObject = result;
            txtAreaCuad.Text = squareG.Area.ToString();
            txtPerCuad.Text = squareG.Perimeter.ToString();
        }

        private void btnMostrarCuad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Entra");
                ListSquares();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Triangulo

        private async void btnCalcularTriang_Click(object sender, RoutedEventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.Width = long.Parse(txtLadoA.Text);
            triangle.Height = long.Parse(txtLadoB.Text);
            dynamic result = await CreateTriangle(triangle);
            txtAreaTriang.Text = triangleG.Area.ToString();
            txtPerTriang.Text = triangleG.Perimeter.ToString();

        }

        private void btnMostrarTriang_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Entra");
                ListTriangles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
