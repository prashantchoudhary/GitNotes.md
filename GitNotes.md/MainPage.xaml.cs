namespace GitNotes.md;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        Preview.Html = Markdig.Markdown.ToHtml(Editor.Text);
    }
}