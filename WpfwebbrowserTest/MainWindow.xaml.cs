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

namespace WpfwebbrowserTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string text = @"&nbsp;<span style='color:#1F497D'><span>y<span></span>&nbsp; &nbsp;<span style='color:#1F497D;'>1</span>&nbsp;<span style='color:#1F497D;background-color:#123456'>2</span><span style='color:#1F497D;background-color:#123456;text-align:center'>3</span>  <span style='color:#1F497D;background-color:#123456;text-align:center;'>4</span> <span style='color:#1F497D;background-color:#123456;text-align:center;tt-l: 134;'>5</span>ggjf<a>123456</a>";
            string html = "<!DOCTYPE html> < html > < head > < title > 这是个标题 </ title >  </ head > < body > < h1 > 这是一个一个简单的HTML </ h1 > < p > Hello World！</ p > </ body > </ html >";
            wb.Navigate("about:blank");     //一定要创建一个空白界面。不然即使写入html成功显示也不能再次回读其中内容。
            wb.Document.OpenNew(false);
            wb.Document.Write(html);
            wb.Refresh();
        }
    }
}
