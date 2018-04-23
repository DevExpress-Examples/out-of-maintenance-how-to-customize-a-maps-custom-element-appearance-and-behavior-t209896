using System;
using System.Windows;

namespace MapCustomElement {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    class ShipwreckInformation {
        public Uri ImageUri { get; set; }
        public String Name { get; set; }
        public Int32 Year { get; set; }
        public String Description { get; set; }
    }
}
