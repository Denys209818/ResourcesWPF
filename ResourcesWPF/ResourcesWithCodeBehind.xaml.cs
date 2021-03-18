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
using System.Windows.Shapes;

namespace ResourcesWPF
{
    /// <summary>
    /// Interaction logic for ResourcesWithCodeBehind.xaml
    /// </summary>
    public partial class ResourcesWithCodeBehind : Window
    {
        public ResourcesWithCodeBehind()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            this.lbResult.Items.Clear();
            //  Пошук локального ресурса блока pnlMain
            this.lbResult.Items.Add(this.pnlMain.FindResource("strPnl").ToString());
            //  Пошук ресурса Windows
            this.lbResult.Items.Add(this.FindResource("strWindow").ToString());
            //  Пошук глобального ресурса який доступний у всьому проекті
            this.lbResult.Items.Add(Application.Current.FindResource("strApp").ToString());
        }
    }
}
