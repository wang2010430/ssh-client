﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ssh_client
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			
			// Bind our events
			MouseLeftButtonDown += OnMouseLeftButtonDown;
			AddConnectionButton.Click += (o, e) => AddConnectionForm.Visibility = Visibility.Visible;;
			ScrollTopButton.Click += (o, e) => OnScrollTopButtonClick();
			ScrollDownButton.Click += (o, e) => OnScrollDownButtonClick();
		}
		
		public void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs args)
		{
			if (args.ClickCount == 2)
			{
				WindowControls wc = (WindowControls) LayoutRoot.FindName("WindowControls");
				wc.OnMaximizeButtonClick();
			}
			else
			{
				DragMove();
			}
		}
		
		public void OnScrollTopButtonClick()
		{
			ConnectionPanel.ScrollToVerticalOffset(ConnectionPanel.VerticalOffset - 16);
		}
		
		public void OnScrollDownButtonClick()
		{
			ConnectionPanel.ScrollToVerticalOffset(ConnectionPanel.VerticalOffset + 16);
		}
    }
}