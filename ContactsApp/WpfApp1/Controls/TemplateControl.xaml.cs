using System;
using System.Collections.Generic;
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

namespace WpfApp1.Controls
{
    /// <summary>
    /// Interaction logic for TemplateControl.xaml
    /// </summary>
    public partial class TemplateControl : UserControl
    {



        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty);}
            set { SetValue(ContactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContactProperty =

            DependencyProperty.Register("Contact", typeof(Contact)
                , typeof(TemplateControl), new PropertyMetadata(new Contact() {Name= "Name Lastname", Number="number", EmailAddress="New Email" }, SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //Set values

            TemplateControl Control = d as TemplateControl;

            if (Control!=null)
            {
                Control.nameTextBlock.Text = (e.NewValue as Contact).Name;
                Control.EmailTextBlock.Text = (e.NewValue as Contact).EmailAddress;
                Control.PhoneTextBlock.Text = (e.NewValue as Contact).Number;

            }
        }

        public TemplateControl()
        {
            InitializeComponent();
        }
    }
}
   

  
    


