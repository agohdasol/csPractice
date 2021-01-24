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

namespace WpfTutorial
{
  /// <summary>
  /// Page1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class ExpenseReportPage : Page
  {
    public ExpenseReportPage()
    {
      InitializeComponent();
    }
    public ExpenseReportPage(object data) : this()
    {
      this.DataContext = data;
    }
  }
}