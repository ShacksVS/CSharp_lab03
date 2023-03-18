using System;
using System.Windows;
using System.Windows.Controls;

namespace lab02
{
    public partial class DateInputUserControl : UserControl
    {
        private DateInfo dateFromUser;

        public DateInputUserControl()
        {
            InitializeComponent();
            dateFromUser = new DateInfo();
            DataContext = dateFromUser;
        }


    }
}