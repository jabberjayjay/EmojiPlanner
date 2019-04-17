using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmojiPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {


        public CalendarPage()
        {
            
            InitializeComponent();

            DateTime time = DateTime.Now;

            int month = time.Month;
            DateTime monthCheck = new DateTime(time.Year, time.Month, 1);
            int cnt = 0;
            //string weekDay = monthCheck.DayOfWeek;

            var topGrid = new Grid
            {

                RowSpacing = 2,
                ColumnSpacing = 2,
                Padding = 2,
                BackgroundColor = Color.Silver,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.CenterAndExpand,


                ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },
                new ColumnDefinition { Width = new GridLength(10, GridUnitType.Auto) },

                },

                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                



            }
            };

            string MonthName(int m)
            {
                string res;
                switch (m)
                {
                    case 1:
                        res = "January";
                        break;
                    case 2:
                        res = "February";
                        break;
                    case 3:
                        res = "March";
                        break;
                    case 4:
                        res = "April";
                        break;
                    case 5:
                        res = "May";
                        break;
                    case 6:
                        res = "June";
                        break;
                    case 7:
                        res = "July";
                        break;
                    case 8:
                        res = "August";
                        break;
                    case 9:
                        res = "September";
                        break;
                    case 10:
                        res = "October";
                        break;
                    case 11:
                        res = "November";
                        break;
                    case 12:
                        res = "December";
                        break;
                    default:
                        res = "Null";
                        break;
                }
                return res;
            }


            var leftButton = new Button
            {
                Text = MonthName(monthCheck.Month - 1),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor= Color.Aqua,
                TextColor = Color.Gray
            };


            var rightButton = new Button
            {
                Text = MonthName(monthCheck.Month +1),
                // HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Gray,
                BackgroundColor = Color.Aqua,
                


            };

            //rightButton.Clicked += rightButtonClick();

            var topLabel = new Label
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = MonthName(monthCheck.Month)+", "+monthCheck.Year,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                



            };

            Grid.SetRowSpan(topLabel, 5);

            Grid.SetRowSpan(leftButton, 1);
            Grid.SetRowSpan(rightButton, 1);

            topGrid.Children.Add(leftButton, 0, 1);
            topGrid.Children.Add(topLabel, 4, 1);
            topGrid.Children.Add(rightButton, 7, 1);
            
 
            //System.DateTime moment = new System.DateTime();


            var monthGrid = new Grid
            {
                RowSpacing = 2,
                ColumnSpacing = 2,
                Padding = 2,
                BackgroundColor = Color.Silver,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,




                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },


            },
                ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(30, GridUnitType.Star) },



            }

            };

            //monthGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            //monthGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //monthGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200) });

            var sunLabel = new Label
            {
                BackgroundColor = Color.Lavender,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "SUN",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),



            };
            monthGrid.Children.Add(sunLabel, 0, 0);

            var monLabel = new Label
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "MON",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),



            };
            monthGrid.Children.Add(monLabel, 1, 0);

            var tueLabel = new Label
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "TUE",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),



            };
            monthGrid.Children.Add(tueLabel, 2, 0);

            var wedLabel = new Label
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "WED",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),


            };
            monthGrid.Children.Add(wedLabel, 3, 0);

            var thuLabel = new Label
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "THU",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),



            };
            monthGrid.Children.Add(thuLabel, 4, 0);

            var friLabel = new Label
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "FRI",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),


            };
            monthGrid.Children.Add(friLabel, 5, 0);

            var satLabel = new Label
            {
                BackgroundColor = Color.Lavender,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "SAT",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),


            };
            monthGrid.Children.Add(satLabel, 6, 0);


            int x, y;
            


           
            for (x = 1; x < 7; x++)
            {
                if (cnt > 30)
                    break;
                    //monthGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
                    for (y=0; y < 7; y++)
                {
                    if (cnt == 0)
                    {
                        if (monthCheck.DayOfWeek.ToString().Equals("Monday") && y < 7)
                            y = 1;
                        if (monthCheck.DayOfWeek.ToString().Equals("Tuesday") && y < 7)
                            y = 2;
                        if (monthCheck.DayOfWeek.ToString().Equals("Wednesday") && y < 7)
                            y = 3;
                        if (monthCheck.DayOfWeek.ToString().Equals("Thursday") && y < 7)
                            y = 4;
                        if (monthCheck.DayOfWeek.ToString().Equals("Friday") && y < 7)
                            y = 5;
                        if (monthCheck.DayOfWeek.ToString().Equals("Saturday") && y < 7)
                            y = 6;
                    }
                    cnt++;
                    //monthGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
                    
                    

                    if(y%2==0 && cnt <= 31)
                    { 
                    var dayLabel = new Label { BackgroundColor = Color.LightYellow,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            Text = cnt.ToString()
                       };
                        monthGrid.Children.Add(dayLabel, y, x);

                    }
                    if(!(y%2==0)&& cnt<=31)
                    {
                        var dayLabel = new Label { BackgroundColor = Color.White,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            Text = cnt.ToString()
                        };
                        monthGrid.Children.Add(dayLabel, y, x);
                    }

                    if (time.Day == cnt)
                    {
                        var dayLabel = new Label
                        {
                            BackgroundColor = Color.LightBlue,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            Text = cnt.ToString()
                        };
                        monthGrid.Children.Add(dayLabel, y, x);
                    }



                    if (cnt > 30)
                        break;
                    if (cnt > 27 && (monthCheck.Month == 2 && monthCheck.Year % 4 == 0 || (monthCheck.Month == 2 && monthCheck.Year % 100 == 0 && monthCheck.Year % 400 == 0)))
                    {
                        break;
                    }
                    if (cnt > 28 && monthCheck.Month == 2)
                        break;
                    if ((monthCheck.Month == 9 || monthCheck.Month == 4 || monthCheck.Month == 6 || monthCheck.Month == 11) && cnt > 29)
                        break;
                    if (cnt > 30)
                        break;
                    //monthGrid.RowDefinitions.Add(new RowDefinition
                    //{
                    //    Height = new GridLength(1, GridUnitType.Auto)
                    //});
                    //monthGrid.RowDefinitions.Add(new RowDefinition
                    //{
                    //    Height = new (1, GridUnitType.Star);
                    //});


                }


            }

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
               
                

                Children =
                {
                    topGrid,
                    monthGrid
                }




            };
        }

        //private EventHandler rightButtonClick()
        //{
            
            
        //    //throw new NotImplementedException();
        //}
    }
}