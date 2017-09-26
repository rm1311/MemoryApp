using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MemoryApp.Classes;


namespace MemoryApp.Pages
{

    public sealed partial class NewGame : Page
    {
        private TextBlock[] screenButtons;
        public TextBlock[] _sceenButtons { get { return screenButtons; } set { screenButtons = value; } }
        FirstTap ft = new FirstTap();    
        public NewGame()
        {
            this.InitializeComponent();
            GenerateButton();
        }

        public void GenerateButton()
        {
           MemTable mt = new MemTable();
           screenButtons = new TextBlock[16];
           screenButtons[0] = but1;
           screenButtons[1] = but2;
           screenButtons[2] = but3;
           screenButtons[3] = but4;
           screenButtons[4] = but5;
           screenButtons[5] = but6;
           screenButtons[6] = but7;
           screenButtons[7] = but8;
           screenButtons[8] = but9;
           screenButtons[9] = but10;
           screenButtons[10] = but11;
           screenButtons[11] = but12;
           screenButtons[12] = but13;
           screenButtons[13] = but14;
           screenButtons[14] = but15;
           screenButtons[15] = but16;
            for (int i = 0; i < mt._memTable.Length; i++)
                screenButtons[i].Text = mt._memTable[i].ToString();
        }        
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            

        }

        private void but1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but1;
                ft._firstTap = but1.Text;
            }
            else if (ft._firstTap == but1.Text)
            {
                ft._previousButton.Text = "";
                but1.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but2;
                ft._firstTap = but2.Text;
            }
            else if (ft._firstTap == but2.Text)
            {
                ft._previousButton.Text = "";
                but2.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but3;
                ft._firstTap = but3.Text;
            }
            else if (ft._firstTap == but3.Text)
            {
                ft._previousButton.Text = "";
                but3.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but4;
                ft._firstTap = but4.Text;
            }
            else if (ft._firstTap == but4.Text)
            {
                ft._previousButton.Text = "";
                but4.Text = "";
                ft._firstTap = "20";
            }
        }

        private void but5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but5;
                ft._firstTap = but5.Text;
            }
            else if (ft._firstTap == but5.Text)
            {
                ft._previousButton.Text = "";
                but5.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {

                ft._previousButton = but6;
                ft._firstTap = but6.Text;
            }
            else if (ft._firstTap == but6.Text)
            {
                ft._previousButton.Text = "";
                but6.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but7;
                ft._firstTap = but7.Text;
            }
            else if (ft._firstTap == but7.Text)
            {
                ft._previousButton.Text = "";

                but7.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but8;
                ft._firstTap = but8.Text;
            }
            else if (ft._firstTap == but8.Text)
            {
                ft._previousButton.Text = "";

                but8.Text = "";
                ft._firstTap = "20";
            }
        }

        private void but9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but9;
                ft._firstTap = but9.Text;
            }
            else if (ft._firstTap == but9.Text)
            {
                ft._previousButton.Text = "";

                but9.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but10;
                ft._firstTap = but10.Text;
            }
            else if (ft._firstTap == but10.Text)
            {
                ft._previousButton.Text = "";

                but10.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but11;

                ft._firstTap = but11.Text;
            }
            else if (ft._firstTap == but11.Text)
            {
                ft._previousButton.Text = "";

                but11.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but12;

                ft._firstTap = but12.Text;
            }
            else if (ft._firstTap == but12.Text)
            {
                ft._previousButton.Text = "";

                but12.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but13_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but13;

                ft._firstTap = but13.Text;
            }
            else if (ft._firstTap == but13.Text)
            {
                ft._previousButton.Text = "";

                but13.Text = "";
                ft._firstTap = "20";
            }

        }

        private void but14_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but14;

                ft._firstTap = but14.Text;
            }
            else if (ft._firstTap == but1.Text)
            {
                ft._previousButton.Text = "";

                but14.Text = "";
                ft._firstTap = "20";
            }

        }
        private void but15_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but15;

                ft._firstTap = but15.Text;
            }
            else if (ft._firstTap == but15.Text)
            {
                ft._previousButton.Text = "";

                but15.Text = "";
                ft._firstTap = "20";
            }
        }
        private void but16_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._firstTap == "20")
            {
                ft._previousButton = but16;

                ft._firstTap = but16.Text;
            }
            else if (ft._firstTap == but16.Text)
            {
                ft._previousButton.Text = "";

                but16.Text = "";
                ft._firstTap = "20";
            }
        }

    }
    }
