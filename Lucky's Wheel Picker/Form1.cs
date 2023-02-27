using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Security;

namespace Lucky_s_Wheel_Picker
{
    // TO DO (FUTURE)
    // "Encadenar" ruedas, es decir, opcion de que el primer tiro sea una rueda que lo que seleccione sea la segunda rueda que usar
    //      Es decir, 1era rueda "Game Genre" -> Pick RPG -> Load RPG data -> Spin RPG Wheel -> Pick RPG Game
    // Para pesos, Max Peso = 20, Max cantidad de rebanadas = 18, para que sea al menos 1 grado en la rueda para cada wea

    using Charting = System.Windows.Forms.DataVisualization.Charting;


    public partial class Form1 : Form
    {
        // Easy Tweak
        readonly int ticksPerSecond = 60;
        readonly int impulseMult = 60;
        readonly string selectBString = "Select List File";
        readonly string spnString = "SPINNING";

        // Internal Values
        Double currentImpulse = 0, sumWeights = 0, angleStep = 0;
        int timeDelta = 0, totalPoints = 0;
        float[] reverseOrderArray;

        // Random Number gen
        private Random rand;

        // Timer para Ticks
        Timer myTimer;

        // For sound
        /*
        SoundPlayer[] soundTickArray    = { new SoundPlayer(@"c:\Windows\Media\Windows Startup.wav"),
                                            new SoundPlayer(@"c:\Windows\Media\Windows Information Bar.wav"),
                                            new SoundPlayer(@"c:\Windows\Media\Windows Menu Command.wav") };
        */

        // El "Main" por asi decirlo, en este caso
        public Form1()
        {
            //Required
            InitializeComponent();

            rand = new Random();

            // Calcula el intervalo para X ticks por segundo
            timeDelta = 1000 / ticksPerSecond;

            // Launch function that reads CSV

            // Test Data Points
            //TestChartPoints();

            // First Chart
            DefaultChart();

            // Get the Variables started
            InitializeChartVariables();

            // Pone lindo el grafo
            InitializeChartGraphics(0);

            // Valores Prueba
            currentImpulse = 900;

            // Las cosas del Timer/Ticker
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = timeDelta;

        }


        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            // Pa detenerlo si uno quiere supongo
            // myTimer.Stop();

            // La 'fuerza' con la que se mueve
            double fraction = currentImpulse / 1000;

            currentImpulse *= .97;

            if (currentImpulse < 1)
                Stop_Spin();


            // Hace 'girar' al Pie Chart, Clamp de valor a 360, por que circulo
            chart1.Series["s1"]["PieStartAngle"] = ((float.Parse(chart1.Series["s1"]["PieStartAngle"]) + impulseMult * fraction)
                                                    % 360).ToString();

            int i = 0;
            
            // Mueve los angulos de los labels
            // For normal no funciono tan bien, creo que tenia que instanciar un Datapoint temporal, ah bueno
            foreach (Charting.DataPoint dp in chart1.Series["s1"].Points)
            {
                // Evalua si toca o no un sonido de Tick (cuando pase por uno de los angulos)
                
                // Valor temporal para evaluar y rotar cuando necesario
                // AnguloActualChart (para ser actual y no perder sincronizacion) + los angulos entre rebanadas
                int tempInt = (int)(double.Parse(chart1.Series["s1"]["PieStartAngle"])
                                    + (i * angleStep) + (angleStep / 2) * dp.YValues[0]) % 180;

                i += (int)dp.YValues[0];

                if (tempInt > 90)
                    tempInt -= 180;

                dp.LabelAngle = tempInt;
            };
            
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void chart1_Click(object sender, EventArgs e)
        {
            Initiate_Spin();
        }

        // Starts the 'Wheel' Spin, initializes the impulse
        private void Initiate_Spin()
        {
            // Doble factor aleatoreo, la posicion inicial y la fuerza inicial
            chart1.Series["s1"]["PieStartAngle"] = (rand.NextDouble() * 1080 % 360).ToString();

            currentImpulse = 900 + rand.NextDouble() * 200;

            // Inicializa el Timer
            myTimer.Start();

            // Crear lista de int, orden invertido al de la rueda, para los angulos en que hacer ruido
            // Ticked even, ticked odd, bools para "alternar" en la lista
            reverseOrderArray = new float[chart1.Series["s1"].Points.Count];

            int i = 0;

            // Llena el arreglo con con los angulos que marcan el inicio
            foreach (Charting.DataPoint dp in chart1.Series["s1"].Points)
            {
                reverseOrderArray[i] = float.Parse((chart1.Series["s1"]["PieStartAngle"]) 
                    + (i * angleStep) * dp.YValues[0]) %360;
            }

            selectButton.Text = spnString;
            resultLabel.Text = spnString;
        }

        private void Stop_Spin()
        {
            // Stops Timer
            myTimer.Stop();

            int currStepWeight = 0;
            float stoppedAngle = Math.Abs( (float.Parse(chart1.Series["s1"]["PieStartAngle"])) - 360 ) % 360;

            // Find on which 'Spoke' the wheel 'Stopped'
            // For normal no funciono tan bien, creo que tenia que instanciar un Datapoint temporal, ah bueno
            foreach (Charting.DataPoint dp in chart1.Series["s1"].Points)
            {
                double sliceAngleStart, sliceAngleEnd;
                // Beggining of Slice (Angle)
                sliceAngleStart = currStepWeight * angleStep;

                currStepWeight += (int)dp.YValues[0];

                // End of slice
                sliceAngleEnd = currStepWeight * angleStep;

                // Para ajustar a elemento grafico que sea la "Flecha"
                // = ( Absolute ( stoppedAngle +- ADJUSTMENT ) ) % 360

                // Evaluates if stoppedAngle is between the sliceStart and sliceEnd
                if (sliceAngleStart <= stoppedAngle && stoppedAngle < sliceAngleEnd)
                {
                    //Console.WriteLine("sliceStart: " + sliceAngleStart + " stoppedAngle: " + stoppedAngle + " sliceEnd: " + sliceAngleEnd);
                    //Console.WriteLine("You got: " + dp.Label);

                    resultLabel.Text = dp.Label;

                }
            };

            selectButton.Text = selectBString;

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            Initiate_Spin();
        }

        private void InitializeChartVariables()
        {
            sumWeights = 0;
            totalPoints = 0;

            // Suma todos los "Pesos" para calcular bien lo que sigue
            foreach (Charting.DataPoint dp in chart1.Series["s1"].Points)
            {
                sumWeights += dp.YValues[0];
                totalPoints++;
            };

            // "Paso" de incremento del angulo de acuerdo a sumWeight
            angleStep = 360 / sumWeights;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            List<string> strContent = new List<string>();
            
            if(myTimer.Enabled == false)
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {

                    try
                    {
                        sr = new StreamReader(openFileDialog1.FileName);

                        List<itemData> itemList = new List<itemData>();

                        while (!sr.EndOfStream)
                        {
                            strContent.Add(sr.ReadLine());
                        }


                        // Lo que hace con lo que lee
                        foreach(string readLine in strContent)
                        {
                            string[] splitString = readLine.Split(',');

                            // Si no hay separacion con coma
                            if (splitString.Length == 1)
                            {
                                // Mete la linea entera como nombre
                                itemData tA = new itemData(splitString[0] , 1);
                                itemList.Add(tA);
                            }
                            else
                            {
                                // Mete la primera parte como nombre, lo otro como peso
                                itemData tA = new itemData(splitString[0], int.Parse(splitString[1]) );
                                itemList.Add(tA);
                            }

                        }

                        // Una vez que termine de interpretar el archivo
                        // Tiene que agregar lo que leyó en la lista, pero si no esta vacio

                        if (itemList.Count != 0)
                        {
                            // Limpia el Chart
                            chart1.Series["s1"].Points.Clear();

                            int k = 0;
                            foreach (itemData tempD in itemList)
                            {
                                chart1.Series["s1"].Points.AddXY(0, tempD.getWeight());
                                chart1.Series["s1"].Points[k++].Label = tempD.getName();
                            }

                        }



                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                }


            // Resets Chart Position
            chart1.Series["s1"]["PieStartAngle"] = "0";

            InitializeChartVariables();

            // 90 to correct offset when loading a new chart, and not from the beginning
            InitializeChartGraphics(90);

        }




        private void TestChartPoints()
        {
            

            List<itemData> itemList = new List<itemData>();

            itemData tA = new itemData("Heads", 1);
            itemList.Add(tA);

            itemData tB = new itemData("Tails", 1);
            itemList.Add(tB);

            for (int i = 0; i < 40; i++)
            {
                itemData temp = new itemData("kek0"+i, 1);
                itemList.Add(temp);
            }

            int k = 0;

            foreach (itemData tempD in itemList){
                chart1.Series["s1"].Points.AddXY(0, tempD.getWeight());
                chart1.Series["s1"].Points[k++].Label = tempD.getName();
            }

        }

        private void DefaultChart()
        {
            List<itemData> itemList = new List<itemData>();

            itemData tA = new itemData("Heads", 1);
            itemList.Add(tA);

            itemData tB = new itemData("Tails", 1);
            itemList.Add(tB);


            int k = 0;

            foreach (itemData tempD in itemList)
            {
                chart1.Series["s1"].Points.AddXY(0, tempD.getWeight());
                chart1.Series["s1"].Points[k++].Label = tempD.getName();
            }
        }

        private void InitializeChartGraphics(int angleAdjust)
        {
            // Initial Angle
            int i = 0;

            //Setup de los angulos
            foreach (Charting.DataPoint dp in chart1.Series["s1"].Points)
            {
                dp.LabelAngle = (int)( ( (i * angleStep) + (angleStep / 2) * dp.YValues[0]) + angleAdjust ) % 180 - 90;

                i += (int)dp.YValues[0];
            };
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            Initiate_Spin();
        }

        private void playWheelTick(int selector)
        {
            // Options -> Windows Information Bar, Windows Menu Command
            // SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Startup.wav");
            //simpleSound.Play();

            //soundTickArray[selector].Play();
        }

        private void playWheelWinner()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Startup.wav");
            simpleSound.Play();
        }

        // IDEA DE IMPLEMENTACION
        /*
         * Crear Pie Chart
         * Rotar Pie Chart de acuerdo a un 'Impulso' inicial aleatoreo
         * Cuando termine de 'Girar', detectar el angulo de rotacion del elemento
         * De acuerdo al angulo, y ya sabiendo en cuanto está dividido el grafo
         * se puede determinar en que 'Rebanada' 'Cayó' la rueda
         * Asimismo se puede hacer sonar un sonido cada vez que pase por una de las 'Areas'
         * 
         * Para implementar, se tendra que guardar el nombre en label
         * 
        */

        private class itemData{
            private string itemName = "ERROR";
            private int itemWeight = 0;

            public itemData(string inputName, int inputWeight)
            {
                itemName = inputName;
                itemWeight = inputWeight;
            }

            public string getName()
            {
                return itemName;
            }

            public int getWeight()
            {
                return itemWeight;
            }


        }

    }
}
