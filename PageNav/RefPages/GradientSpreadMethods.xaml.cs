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

namespace PageNav.RefPages
{
    /// <summary>
    /// Interaction logic for GradientSpreadMethods.xaml
    /// </summary>
    public partial class GradientSpreadMethods : Page
    {

        LinearGradientBrush myLinGradBrush5 = new LinearGradientBrush ()
        {
        };


        //TODONT:  RUNTIME ERROR about new Uri
        //ImageBrush myImageBrush1 = new ImageBrush ()
        //{
        //    ImageSource = new BitmapImage (new Uri (@"Images\Pointer32.png, UriKind.Relative")),
        //};


        //public ImageBrush TheImageBrush1 
        //{ 
        //    get
        //    { return myImageBrush1; } 
        //}



    //    public static readonly DependencyProperty TheImageBrush1Property =
    //DependencyProperty.Register(
    //"TheImageBrush1", typeof (ImageBrush ),
    //typeof (PageNav )
    //);





        public GradientSpreadMethods ()
        {
            InitializeComponent ();
        }





        public void RectAndLinearGradBrush ()
        {
            Rectangle exampleRectangle = new Rectangle ();
            exampleRectangle.Width = 75;
            exampleRectangle.Height = 75;

            // Create a LinearGradientBrush and use it to
            // paint the rectangle.
            LinearGradientBrush myBrush = new LinearGradientBrush ();
            myBrush.GradientStops.Add ( new GradientStop ( Colors.Yellow, 0.0 ) );
            myBrush.GradientStops.Add ( new GradientStop ( Colors.Orange, 0.5 ) );
            myBrush.GradientStops.Add ( new GradientStop ( Colors.Red, 1.0 ) );

            exampleRectangle.Fill = myBrush;


            Rectangle exampleRectangle1 = new Rectangle ();
            exampleRectangle.Width = 75;
            exampleRectangle.Height = 75;

            // Create a RadialGradientBrush and use it to
            // paint the rectangle.
            RadialGradientBrush myBrush1 = new RadialGradientBrush ();
            myBrush1.GradientOrigin = new Point ( 0.75, 0.25 );
            myBrush1.GradientStops.Add ( new GradientStop ( Colors.Yellow, 0.0 ) );
            myBrush1.GradientStops.Add ( new GradientStop ( Colors.Orange, 0.5 ) );
            myBrush1.GradientStops.Add ( new GradientStop ( Colors.Red, 1.0 ) );

            exampleRectangle.Fill = myBrush1;


            //TODO:  Attach to a XAML Parent
        }



        /*
         * You can change certain behaviors of a dependency property by overriding the metadata for that property when you derive from the class that originally registers the dependency property. Overriding metadata relies on the DependencyProperty identifier. Overriding metadata does not require reimplementing the property. The metadata change is handled natively by the property system; each class potentially holds individual metadata for all properties that are inherited from base classes, on a per-type basis.

            The following example overrides metadata for a dependency property DefaultStyleKey. Overriding this particular dependency property metadata is part of an implementation pattern that creates controls that can use default styles from themes.
         */
        public class SpinnerControl : ItemsControl
        {
            static SpinnerControl ()
            {
                DefaultStyleKeyProperty.OverrideMetadata (
                    typeof ( SpinnerControl ),
                    new FrameworkPropertyMetadata ( typeof ( SpinnerControl ) )
                );
            }
        }





    }
}
