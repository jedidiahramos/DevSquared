using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using NLua;

namespace NLuaWPF
{
    public partial class MainWindow : Window
    {
        Lua state = new Lua();
        private string luaString;

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            
        }

        //string StringFromRichTextBox(RichTextBox rtb)
        //{
        //    TextRange textRange = new TextRange(
        //        // TextPointer to the start of content in the RichTextBox.
        //        rtb.Document.ContentStart,
        //        // TextPointer to the end of content in the RichTextBox.
        //        rtb.Document.ContentEnd
        //    );

        //    string text = textRange.Text;
        //    if (text.EndsWith("\n"))
        //    {
        //        text = text.Substring(0, text.Length - 1);
        //    }
        //    return text;
        //}

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string text = Editor.Text;
            state.DoString(text);
            Output.Text = (string)state["x"];
        }
    }
}
