using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqliteExample.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BedRow : Grid
	{
        #region Bindable Properties
        public static readonly BindableProperty TitleProperty =
           BindableProperty.Create(
               nameof(Title), typeof(string), typeof(BedRow), default(string), BindingMode.TwoWay);
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty BedsQtyProperty =
           BindableProperty.Create(
               nameof(BedsQty), typeof(string), typeof(BedRow), default(string), BindingMode.TwoWay);
        public string BedsQty
        {
            get { return (string)GetValue(BedsQtyProperty); }
            set { SetValue(BedsQtyProperty, value); }
        }
        public static readonly BindableProperty BedCostPerDayProperty =
           BindableProperty.Create(
               nameof(BedCostPerDay), typeof(string), typeof(BedRow), default(string), BindingMode.TwoWay);
        public string BedCostPerDay
        {
            get { return (string)GetValue(BedCostPerDayProperty); }
            set { SetValue(BedCostPerDayProperty, value); }
        }
        public static readonly BindableProperty AvgBedCostPerDayProperty =
           BindableProperty.Create(
               nameof(AvgBedCostPerDay), typeof(string), typeof(BedRow), default(string), BindingMode.TwoWay);
        public string AvgBedCostPerDay
        {
            get { return (string)GetValue(AvgBedCostPerDayProperty); }
            set { SetValue(AvgBedCostPerDayProperty, value); }
        }
        public static readonly BindableProperty BedSpaceProperty =
           BindableProperty.Create(
               nameof(BedSpace), typeof(string), typeof(BedRow), default(string), BindingMode.TwoWay);
        public string BedSpace
        {
            get { return (string)GetValue(BedSpaceProperty); }
            set { SetValue(BedSpaceProperty, value); }
        }
        public static readonly BindableProperty DepositAmountProperty =
           BindableProperty.Create(
               nameof(DepositAmount), typeof(string), typeof(BedRow), default(string), BindingMode.TwoWay);
        public string DepositAmount
        {
            get { return (string)GetValue(DepositAmountProperty); }
            set { SetValue(DepositAmountProperty, value); }
        }
        #endregion

        public BedRow()
        {
            InitializeComponent();
            BedNameLable.Text = Title;
            BedsQtyEntry.Text = BedsQty;
            BedCostPerDayEntry.Text = BedCostPerDay;
            AvgBedCostPerDayEntry.Text = AvgBedCostPerDay;
            BedSpaceEntry.Text = BedSpace;
            DepositAmountEntry.Text = DepositAmount;
            BedsQtyEntry.TextChanged += BedsQtyEntry_TextChanged;
            BedCostPerDayEntry.TextChanged += BedCostPerDayEntry_TextChanged;
            AvgBedCostPerDayEntry.TextChanged += AvgBedCostPerDayEntry_TextChanged;
            BedSpaceEntry.TextChanged += BedSpaceEntry_TextChanged;
            DepositAmountEntry.TextChanged += DepositAmountEntry_TextChanged;
        }

        private void DepositAmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            DepositAmount = e.NewTextValue;
        }

        private void BedSpaceEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            BedSpace = e.NewTextValue;
        }

        private void AvgBedCostPerDayEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            AvgBedCostPerDay = e.NewTextValue;
        }

        private void BedCostPerDayEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            BedCostPerDay = e.NewTextValue;
        }

        private void BedsQtyEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            BedsQty = e.NewTextValue;
        }       

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                BedNameLable.Text = Title;
            } else if (propertyName == BedsQtyProperty.PropertyName)
            {
                BedsQtyEntry.Text = BedsQty;
            }
            else if(propertyName == BedCostPerDayProperty.PropertyName)
            {
                BedCostPerDayEntry.Text = BedCostPerDay;
            } else if (propertyName == AvgBedCostPerDayProperty.PropertyName)
            {
                AvgBedCostPerDayEntry.Text = AvgBedCostPerDay;
            }
            else if (propertyName == BedSpaceProperty.PropertyName)
            {
                BedSpaceEntry.Text = BedSpace;
            }
            else if (propertyName == DepositAmountProperty.PropertyName)
            {
                DepositAmountEntry.Text = DepositAmount;
            }
        }
    }
}