using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using MemoryApp.Classes;
using Windows.UI;
using Windows.UI.Xaml.Media;
using System.Threading;
using Windows.UI.Xaml;
using System;
namespace MemoryApp.Pages
{

    public sealed partial class NewGame : Page
    {
        
        Person person = new Person();
        DispatcherTimer timer = new DispatcherTimer();
        private TextBlock[] screenButtons;
        public TextBlock[] _sceenButtons { get { return screenButtons; } set { screenButtons = value; } }
        FirstTap ft = new FirstTap();
        int count = 0;
        int countIfEnded = 8;
        public void GenTimer()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, object e)
        {
            timerTextBlock.Text = count++.ToString();
        }
        public NewGame()
        {
            person._Name = "";
            person._Score = "";
            this.InitializeComponent();
            GenerateButton();
            GenTimer();
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
            ft._previousButton = null;
            for (int i = 0; i < mt._memTable.Length; i++)
                screenButtons[i].Text = mt._memTable[i].ToString();
        }        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            person._Name = (string)e.Parameter;
        }
        private void but1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord1.BorderBrush = BorderBrush;
                ft._previousBorder = bord1;
                ft._previousButton = but1;
                ft._firstTap = but1.Text;
            }
            else if (ft._previousButton == but1)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but1 && ft._firstTap != but1.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but1.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord1.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but1.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but1.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }

        }
        private void but2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord2.BorderBrush = BorderBrush;
                ft._previousBorder = bord2;
                ft._previousButton = but2;
                ft._firstTap = but2.Text;
            }
            else if (ft._previousButton == but2)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but2 && ft._firstTap != but2.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but2.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord2.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but2.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but2.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord3.BorderBrush = BorderBrush;
                ft._previousBorder = bord3;
                ft._previousButton = but3;
                ft._firstTap = but3.Text;
            }
            else if (ft._previousButton == but3)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but3 && ft._firstTap != but3.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but3.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord3.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but3.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but3.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord4.BorderBrush = BorderBrush;
                ft._previousBorder = bord4;
                ft._previousButton = but4;
                ft._firstTap = but4.Text ;
            }
            else if (ft._previousButton == but4)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but4 && ft._firstTap != but4.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but4.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord4.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but4.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but4.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord5.BorderBrush = BorderBrush;
                ft._previousBorder = bord5;
                ft._previousButton = but5;
                ft._firstTap = but5.Text;
            }
            else if (ft._previousButton == but5)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but5 && ft._firstTap != but5.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but5.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord5.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but5.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but5.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord6.BorderBrush = BorderBrush;
                ft._previousBorder = bord6;
                ft._previousButton = but6;
                ft._firstTap = but6.Text;
            }
            else if (ft._previousButton == but6)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but6 && ft._firstTap != but6.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but6.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord6.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but6.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but6.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }

        }
        private void but7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord7.BorderBrush = BorderBrush;
                ft._previousBorder = bord7;
                ft._previousButton = but7;
                ft._firstTap = but7.Text;
            }
            else if (ft._previousButton == but7)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but7 && ft._firstTap != but7.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but7.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord7.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but7.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but7.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }

        }
        private void but8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord8.BorderBrush = BorderBrush;
                ft._previousBorder = bord8;
                ft._previousButton = but8;
                ft._firstTap = but8.Text;
            }
            else if (ft._previousButton == but8)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but8 && ft._firstTap != but8.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but8.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord8.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but8.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but8.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord9.BorderBrush = BorderBrush;
                ft._previousBorder = bord9;
                ft._previousButton = but9;
                ft._firstTap = but9.Text;
            }
            else if (ft._previousButton == but9)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but9 && ft._firstTap != but9.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but9.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord9.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but9.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but9.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord10.BorderBrush = BorderBrush;
                ft._previousBorder = bord10;
                ft._previousButton = but10;
                ft._firstTap = but10.Text;
            }
            else if (ft._previousButton == but10)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but10 && ft._firstTap != but10.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but10.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord10.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but10.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but10.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord11.BorderBrush = BorderBrush;
                ft._previousBorder = bord11;
                ft._previousButton = but11;
                ft._firstTap = but11.Text;
            }
            else if (ft._previousButton == but11)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but11 && ft._firstTap != but11.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but11.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord11.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but11.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but11.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }

        }
        private void but12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord12.BorderBrush = BorderBrush;
                ft._previousBorder = bord12;
                ft._previousButton = but12;
                ft._firstTap = but12.Text;
            }
            else if (ft._previousButton == but12)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but12 && ft._firstTap != but12.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but12.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord12.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but12.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but12.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but13_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord13.BorderBrush = BorderBrush;
                ft._previousBorder = bord13;
                ft._previousButton = but13;
                ft._firstTap = but13.Text;
            }
            else if (ft._previousButton == but13)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but13 && ft._firstTap != but13.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but13.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord13.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but13.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but13.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but14_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord14.BorderBrush = BorderBrush;
                ft._previousBorder = bord14;
                ft._previousButton = but14;
                ft._firstTap = but14.Text;
            }
            else if (ft._previousButton == but14)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but14 && ft._firstTap != but14.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but14.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord14.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but14.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but14.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but15_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord15.BorderBrush = BorderBrush;
                ft._previousBorder = bord15;
                ft._previousButton = but15;
                ft._firstTap = but15.Text;
            }
            else if (ft._previousButton == but15)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but15 && ft._firstTap != but15.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but15.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord15.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but15.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but15.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }
        }
        private void but16_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ft._previousButton == null && ft._firstTap == "20")
            {
                //when you hit card first time
                BorderBrush = new SolidColorBrush(Colors.Blue);
                bord16.BorderBrush = BorderBrush;
                ft._previousBorder = bord16;
                ft._previousButton = but16;
                ft._firstTap = but16.Text;
            }
            else if (ft._previousButton == but16)
            {
                //when you hit the same card
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
                ft._firstTap = "20";
                ft._previousButton = null;
            }
            else if (ft._previousButton != but16 && ft._firstTap != but16.Text)
            {
                //when you hit card with different number
                ft._firstTap = "20";
                ft._previousButton = null;
                BorderBrush = new SolidColorBrush(Colors.White);
                ft._previousBorder.BorderBrush = BorderBrush;
            }
            else if (ft._firstTap == but16.Text)
            {
                //when you hit card with the same naumber
                BorderBrush = new SolidColorBrush(Colors.Black);
                ft._previousBorder.BorderBrush = BorderBrush;
                bord16.BorderBrush = BorderBrush;
                ft._previousButton.Text = "";
                but16.Text = "";
                ft._firstTap = "20";
                this.countIfEnded--;
                but16.IsTapEnabled = false;
                ft._previousButton.IsTapEnabled = false;
                ft._previousButton = null;
                if (this.countIfEnded == 0)
                {
                    timer.Stop(); scoreButton.Visibility = Visibility.Visible; textBlockScore.Visibility = Visibility.Visible;
                    person._Score = count.ToString();
                }
            }

        }

         private void scoreButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Scores),person);
        }

    }
}
