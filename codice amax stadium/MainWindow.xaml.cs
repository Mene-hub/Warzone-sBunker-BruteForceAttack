using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using WindowsInput;

namespace codice_amax_stadium
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    /*  
        ci sono 8 cifre
        ne so 3 o 4
        i rimantenti possono essere riempiti da numeri tra 0 e 9
        trova tutte le combinazioni
    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            char[] key1;
            //int[] n = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int cont = 0;
            int T = 0;
            int H = 0;
            int C = 0;
            InputSimulator input = new InputSimulator();
            Thread.Sleep(500);
            input.Mouse.LeftButtonClick();

            for (int k = 0; k < 10; k++)
            {
                T = k;
                for (int i = 0; i < 10; i++)
                {
                    H = i;
                    for (int j = 0; j < 10; j++)
                    {
                        C = j;
                        /*if (C % 5 == 0)
                            Thread.Sleep(2000);*/
                        key1 = id.Text.ToString().ToArray();
                        Write(key1, T, H, C);
                        if (cont == 5)
                        {
                            cont = 0;
                            Thread.Sleep(5000);
                        }
                        else
                            cont++;
                    }
                    C = 0;
                }
                H = 0;
            }
        }

        public void Write( char[] key1, int T, int H, int C )
        {
            for (int g = 0; g < key1.Length; g++)
            {
                switch (key1[g])
                {
                    case 't':
                    case 'T':
                        key1[g] = (char)T;
                        break;
                    case 'h':
                    case 'H':
                        key1[g] = (char)H;
                        break;
                    case 'c':
                    case 'C':
                        key1[g] = (char)C;
                        break;
                }
            }
            //key1[0] = (char)2;
            InputSimulator input = new InputSimulator();

            for (int i = 0; i < key1.Length; i++)
            {
                switch (key1[i])
                {            //x: y: 

                    case '0'://961 644
                    case '\0'://961 644
                        //input.Mouse.MoveMouseTo(961, 644);
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(32800, 39000);
                        break;
                    case '1'://863 349
                    case '\u0001'://863 349
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(29500, 21000);
                        break;
                    case '2':
                    case '\u0002'://961 349
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(32800, 21000);
                        break;
                    case '3':
                    case '\u0003'://1070 349
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(36100, 21000);
                        break;
                    case '4':
                    case '\u0004'://863 446
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(29500, 27000);
                        break;
                    case '5':
                    case '\u0005'://961 446
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(32800, 27000);
                        break;
                    case '6':
                    case '\u0006'://1070 446 
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(36100, 27000);
                        break;
                    case '7':
                    case '\u0007'://863 544
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(29500, 33000);
                        break;
                    case '8':
                    case '\u0008'://961 544
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(32800, 33000);
                        break;
                    case '9':
                    case '\u0009'://1070 544
                        input.Mouse.MoveMouseToPositionOnVirtualDesktop(36100, 33000);
                        break;
                }
                Thread.Sleep(50);
                input.Mouse.LeftButtonClick();
                Thread.Sleep(50);
            }
            Thread.Sleep(2100);
        }
    }
}