// from https://github.com/AngleSharp
// with https://github.com/ericchiang/pup
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html;

namespace WindowsFormsApplication1 {
  public partial class Form1 : Form {
    static IMarkupFormatter formatter = new PrettyMarkupFormatter { Indentation = "  ", NewLine = "\r\n" };
    IDocument html;

    public Form1() {
      InitializeComponent();

      // TODO: remove this when the shit gets real...
      urlTextBox.Text = "https://news.ycombinator.com/";

      if (urlTextBox.Text != "") {
        FetchHtml(urlTextBox.Text);
      }
    }

    void urlTextBox_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {

        Uri uri;
        if (!Uri.TryCreate(urlTextBox.Text, UriKind.Absolute, out uri)) {
          // try to tack on "http://"
          Uri.TryCreate("http://" + urlTextBox.Text, UriKind.Absolute, out uri);
        }

        if (uri == null) { MessageBox.Show($"invalid URL: '{urlTextBox.Text}'"); }
        FetchHtml(uri.ToString());
        e.Handled = e.SuppressKeyPress = true;
      }
    }

    void selectorTextBox_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter && this.html != null) {
        QueryHtml(selectorTextBox.Text);
        e.Handled = e.SuppressKeyPress = true;
      }
    }

    async void FetchHtml(string url) {
      this.html = await BrowsingContext.New(Configuration.Default.WithDefaultLoader()).OpenAsync(url);
      QueryHtml(selectorTextBox.Text);
    }

    static string ToHtml(IElement elem) {
      var writer = new StringWriter();
      elem.ToHtml(writer, formatter);
      return writer.ToString();
    }

    void QueryHtml(string selector) {
      Debug.Assert(this.html != null);

      try {
        var sb = new StringBuilder();

        foreach (var elem in html.QuerySelectorAll(selector)) {
          sb.AppendLine(ToHtml(elem));
        }
        contentTextBox.Text = sb.ToString();
      }
      catch (Exception ex) {
        contentTextBox.Text = ex.Message;
      }

    }

  }
}
