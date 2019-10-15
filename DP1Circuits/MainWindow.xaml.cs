using DP1Circuits.circuit;
using DP1Circuits.circuit.exception;
using DP1Circuits.input;
using DP1Circuits.node;
using DP1Circuits.node.operators;
using DP1Circuits.util;
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

namespace DP1Circuits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create objects
        //private CircuitReader circuitReader;
        //private CircuitBuilder circuitBuilder;
        //private CircuitParser parser;

        public MainWindow()
        {
            InitializeComponent();
            InitializeApplication();
        }

        public void InitializeApplication()
        {
            Console.WriteLine("Initializing application");

            string fullAdderPath = "files/Circuit1_FullAdder.txt";
            string decoderPath = "files/Circuit2_Decoder.txt";
            string encoderPath = "files/Circuit3_Encoder.txt";
            string infiniteLoopPath = "files/Circuit4_InfiniteLoop.txt";
            string notConnectedPath = "files/Circuit5_NotConnected.txt";

            //Read circuit
            CircuitReader circuitReader = new CircuitReader();
            List<string> fileInput = circuitReader.ReadFile(encoderPath);

            //Parse input
            CircuitParser parser = new CircuitParser(fileInput);
            Dictionary<string, string> parsedNodes = parser.ParseNodes();
            Dictionary<string, List<string>> parsedEdges = parser.ParseEdges();

            //Build circuit
            CircuitBuilder circuitBuilder = new CircuitBuilder();
            Circuit circuit = circuitBuilder.BuildCircuit(parsedNodes, parsedEdges);

            //Validate circuit
            CircuitValidator circuitValidator = new CircuitValidator();
            circuitValidator.ValidateCircuit(circuit);

            //Initialize input checkboxes
            InitializeInputs(circuit);

            //Simulate
            Mediator mediator = Singleton<Mediator>.Instance;
            mediator.Circuit = circuit;
            mediator.SimulateCircuit();
        }

        private void InitializeInputs(Circuit circuit)
        {
            int index = 0;
            foreach (var inputNode in circuit.Nodes.Where(t => t is InputNode))
            {
                CheckBox inputCheckBox = new CheckBox()
                {
                    Name = inputNode.Name,
                    IsChecked = Convert.ToBoolean((int)inputNode.Output),
                    Margin = new Thickness(20, 20 * index, 0, 0),
                    Content = inputNode.Name
                };
                inputCheckBox.Click += ChangeInput;
                inputCheckBox.Tag = circuit;
                InputGrid.Children.Add(inputCheckBox);
                index++;
            }
        }

        private void ChangeInput(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            var mediator = Singleton<Mediator>.Instance;
            mediator.ResetCircuit();
            InputNode node = mediator.Circuit.Nodes.Where(n => n.Name.Equals(checkBox.Name)).SingleOrDefault() as InputNode;
            if ((bool)checkBox.IsChecked)
            {
                node.State = new HighInputState();
            }
            else
            {
                node.State = new LowInputState();
            }
            node.Request();
            mediator.SimulateCircuit();
        }
    }
}
