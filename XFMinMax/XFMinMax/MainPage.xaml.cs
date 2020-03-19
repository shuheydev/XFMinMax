using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFMinMax
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private double _sliderValue;
        public double SliderValue
        {
            get => _sliderValue;
            set
            {
                _sliderValue = value;
                OnPropertyChanged(nameof(SliderValue));
            }
        }
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double val = e.NewValue;

            //e.NewValueは0~100で変化するが
            //表示させる値としては上限80,下限20に制限する
            
            //Min,Maxメソッドで
            val = Math.Max(20, Math.Min(80, val));

            //if文で
            //if(val>80)
            //{
            //    val = 80;
            //}
            //if(val<20)
            //{
            //    val = 20;
            //}

            SliderValue = val;
        }
    }
}
